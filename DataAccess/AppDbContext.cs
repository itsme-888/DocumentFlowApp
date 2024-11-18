using Microsoft.EntityFrameworkCore;
using DocumentFlowApp.Common.Entities;
using Microsoft.Extensions.Configuration;
using DocumentFlowApp.Common;
using DocumentFlowApp.DataAccess.EntityConfigurations;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        private readonly AppConfig _appConfig;

        public AppDbContext(IConfiguration configuration)
        {
            _appConfig = configuration.Get<AppConfig>();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<FileInfoDb> FileInfos { get; set; }
        public DbSet<FileRequest> FileRequests { get; set; }
        public DbSet<AttachedFilesToRequest> AttachedFilesToRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_appConfig.ConnectionString, 
                b => b.CommandTimeout(3)
                .MigrationsHistoryTable("migration_history", "public"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new NotificationsConfiguration());
            modelBuilder.ApplyConfiguration(new FileInfoConfiguration());
            modelBuilder.ApplyConfiguration(new AttachedFilesToRequestConfiguration());
            modelBuilder.ApplyConfiguration(new FileRequestConfiguration());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
               .Entries()
               .Where(e => e.Entity is IBaseEntity 
               && (e.State == EntityState.Added || e.State == EntityState.Modified));

            var currDateTime = DateTime.UtcNow;

            foreach (var entityEntry in entries)
            {
                ((IBaseEntity)entityEntry.Entity).UpdatedDateTime = currDateTime;

                if (entityEntry.State == EntityState.Added)
                {
                    ((IBaseEntity)entityEntry.Entity).CreatedDateTime = currDateTime;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}

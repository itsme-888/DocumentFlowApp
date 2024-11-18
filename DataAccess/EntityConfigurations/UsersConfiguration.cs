using Microsoft.EntityFrameworkCore;
using DocumentFlowApp.Common.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentFlowApp.DataAccess.Repositories;

namespace DocumentFlowApp.DataAccess.EntityConfigurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.ConfigureBaseEntity();

            builder.HasData(
                new User { Id = 1, UserName = "admin", IsAdmin = true, Name = "Администратор", PasswordHash = UserRepository.GetDefaultPasswordHash() },
                new User { Id = 2, UserName = "user", IsAdmin = false, Name = "Иванов И.И.", PasswordHash = UserRepository.GetDefaultPasswordHash() });

        }
    }
}

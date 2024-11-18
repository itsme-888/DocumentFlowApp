using DocumentFlowApp.Common.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DocumentFlowApp.DataAccess.EntityConfigurations
{
    public class AttachedFilesToRequestConfiguration : IEntityTypeConfiguration<AttachedFilesToRequest>
    {
        public void Configure(EntityTypeBuilder<AttachedFilesToRequest> builder)
        {
            builder.ToTable("attached_files_to_request");

            builder.ConfigureBaseEntity();

            builder.HasOne(x => x.FileInfo)
                .WithMany(x => x.AttachedFilesToRequests)
                .HasForeignKey(x => x.FileInfoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.FileRequest)
                .WithMany(x => x.AttachedFilesToRequests)
                .HasForeignKey(x => x.FileRequestId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using DocumentFlowApp.Common.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DocumentFlowApp.Common.Enums;

namespace DocumentFlowApp.DataAccess.EntityConfigurations
{
    public class FileRequestConfiguration : IEntityTypeConfiguration<FileRequest>
    {
        public void Configure(EntityTypeBuilder<FileRequest> builder)
        {
            builder.ToTable("file_request");

            builder.ConfigureBaseEntity();

            builder.Property(x => x.RequestStatus)
                .IsRequired()
                .HasDefaultValue(RequestStatusEnum.New);
        }
    }
}

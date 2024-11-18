using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DocumentFlowApp.Common.Entities;

namespace DocumentFlowApp.DataAccess.EntityConfigurations
{
    public class FileInfoConfiguration : IEntityTypeConfiguration<FileInfoDb>
    {
        public void Configure(EntityTypeBuilder<FileInfoDb> builder)
        {
            builder.ToTable("file_info");

            builder.ConfigureBaseEntity();
        }
    }
}

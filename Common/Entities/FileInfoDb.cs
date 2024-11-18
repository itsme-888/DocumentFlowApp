namespace DocumentFlowApp.Common.Entities
{
    public class FileInfoDb : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public required string Name { get; set; } = null!;

        public required string Ext { get; set; } = null!;

        public string Description { get; set; } = null!;

        public long Size { get; set; }

        public bool IsArchived { get; set; }

        public bool IsSoftDeleted { get; set; }

        public required string MinioPath { get; set; }

        public long UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<AttachedFilesToRequest> AttachedFilesToRequests { get; set; } = null!;
    }
}

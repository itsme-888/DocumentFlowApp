namespace DocumentFlowApp.Common.Entities
{
    public class AttachedFilesToRequest : IBaseEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public required long FileInfoId { get; set; }
        public FileInfoDb FileInfo { get; set; } = null!;

        public required long FileRequestId { get; set; }
        public FileRequest FileRequest { get; set; } = null!;
    }
}

using DocumentFlowApp.Common.Enums;

namespace DocumentFlowApp.Common.Entities
{
    public class FileRequest : IBaseEntity
    {
        public long Id { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public string Message { get; set; }

        public RequestStatusEnum RequestStatus { get; set; }

        public long CreatedByUserId { get; set; }

        public User CreatedByUser { get; set; } = null!;


        public long? ApprovedByUserId { get; set; }
        public User? ApprovedByUser { get; set; }

        public string? CommentDecline { get; set; }

        public ICollection<AttachedFilesToRequest> AttachedFilesToRequests { get; set; } = null!;
    }
}

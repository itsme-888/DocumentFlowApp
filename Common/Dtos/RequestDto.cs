using DocumentFlowApp.Common.Enums;

namespace DocumentFlowApp.Common.Dtos
{
    public class RequestDto
    {
        public long Id { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

        public string Message { get; set; }

        public RequestStatusEnum RequestStatus { get; set; }

        public string ApprovedUser { get; set; }

        public string Comment { get; set; }

        public int SelectedFileCount { get; set; }

        public string CreatedByUserName { get; set; }
        public long CreatedByUserId { get; set; }
        public List<long> SelectedFileIds { get; set; } = new List<long>();
    }
}

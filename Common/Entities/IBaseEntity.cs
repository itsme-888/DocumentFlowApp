namespace DocumentFlowApp.Common.Entities
{
    public interface IBaseEntity
    {
        long Id { get; set; }
        DateTime CreatedDateTime { get; set; }
        DateTime? UpdatedDateTime { get; set; }
    }
}

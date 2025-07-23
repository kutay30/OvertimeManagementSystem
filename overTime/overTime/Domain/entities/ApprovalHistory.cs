namespace Domain.Entities;
public class ApprovalHistory
{
    public int HistoryId { get; set; }

    public int RequestId { get; set; }
    public OvertimeRequest Request { get; set; }

    public int ActorId { get; set; }
    public Employee Actor { get; set; }

    public RequestStatus PreviousStatus { get; set; }
    public RequestStatus NewStatus { get; set; }

    public DateTime Timestamp { get; set; }
}

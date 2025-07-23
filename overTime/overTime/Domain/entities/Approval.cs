namespace Domain.Entities;
public class Approval
{
    public int ApprovalId { get; set; }

    public int RequestId { get; set; }
    public OvertimeRequest Request { get; set; }

    public int ApproverId { get; set; }
    public Employee Approver { get; set; }

    public RequestStatus Status { get; set; }
    public DateTime? ApprovedAt { get; set; }

    public int? RejectionReasonEnum { get; set; }
    public string? RejectionReasonText { get; set; }
}

namespace Domain.Entities;
public enum RequestType
{
    Assigned,
    SelfRequested,
    Emergency
}

public enum DateType
{
    RegularDay,
    PublicHoliday
}

public enum RequestStatus
{
    Pending,
    Approved,
    Rejected
}

public class OvertimeRequest
{
    public int RequestId { get; set; }
    public RequestType RequestType { get; set; }
    public DateType DateType { get; set; }
    public string Description { get; set; }

    public DateTime StartTime { get; set; }
    public int EstimatedDuration { get; set; } // minutes
    public DateTime CreatedAt { get; set; }
    public RequestStatus Status { get; set; }

    public int? RejectionReasonEnum { get; set; }
    public string? CustomRejectionReason { get; set; }

    public int OriginEmployeeId { get; set; }
    public Employee OriginEmployee { get; set; }

    public int? TargetEmployeeId { get; set; }
    public Employee? TargetEmployee { get; set; }
}

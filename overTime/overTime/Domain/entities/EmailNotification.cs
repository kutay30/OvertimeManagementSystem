namespace Domain.Entities;


public class EmailNotification
{
    public int NotificationId { get; set; }

    public int RecipientId { get; set; }
    public Employee Recipient { get; set; }

    public int RequestId { get; set; }
    public OvertimeRequest Request { get; set; }

    public EmailType EmailType { get; set; }
}

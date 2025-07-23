namespace Domain.Entities;

public class ApprovalHierarchy
{
    public int Id { get; set; }

    public int FromRoleId { get; set; }
    public Role FromRole { get; set; }

    public int ToRoleId { get; set; }
    public Role ToRole { get; set; }

    public int ApprovalLevel { get; set; }
}

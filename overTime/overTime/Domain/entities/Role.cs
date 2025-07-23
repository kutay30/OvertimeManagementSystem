namespace Domain.Entities;

public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public int Level { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}

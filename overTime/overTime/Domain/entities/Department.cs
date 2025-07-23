namespace Domain.Entities;

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }

    public int CompanyId { get; set; }
    public Company Company { get; set; }

    public int? DepartmentManagerId { get; set; }
    public Employee DepartmentManager { get; set; }

    public ICollection<Employee> Employees { get; set; }
}

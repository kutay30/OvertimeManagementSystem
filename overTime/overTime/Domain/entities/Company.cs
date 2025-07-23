﻿namespace Domain.Entities;

public class Company
{
    public int CompanyId { get; set; }
    public string CompanyName { get; set; }

    public ICollection<Department> Departments { get; set; }
}

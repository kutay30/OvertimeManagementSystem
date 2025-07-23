namespace Domain.Entities;

public class Holiday
{
    public DateOnly HolidayDate { get; set; }
    public string Name { get; set; }
    public bool IsOfficial { get; set; }
}

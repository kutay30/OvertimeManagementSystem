using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class AssignOvertimeDto
    {
        public int EmployeeId { get; set; }

        public DateTime StartTime { get; set; }

        public int EstimatedDuration { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateType DateType { get; set; }
    }
}
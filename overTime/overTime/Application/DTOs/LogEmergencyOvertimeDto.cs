using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class LogEmergencyOvertimeDto
    {

        public DateTime StartTime { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateType DateType { get; set; }
    }
}
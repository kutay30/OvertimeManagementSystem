using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateOvertimeRequestDto
    {
         public RequestType RequestType { get; set; }

        public DateType DateType { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public int EstimatedDuration { get; set; }

        public int? TargetEmployeeId { get; set; }
    }
}
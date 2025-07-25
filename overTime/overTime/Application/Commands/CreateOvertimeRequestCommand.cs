using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using overTime.Domain.entities.Enums;

namespace Application.Features
{
    public class CreateOverTimerRequestCommand
    {
        public RequestType RequestType { get; set; }

        public DateType DateType { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public int EstimatedDuration { get; set; } 

        public int OriginEmployeeId { get; set; } // dto içinde yer  alamaz çünkü o bilgi tokenlar tarafından alınır 

        public int? TargetEmployeeId { get; set; } 
    }
}


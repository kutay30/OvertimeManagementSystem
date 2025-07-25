using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Features
{
    public class LogEmergencyOvertime
    {
        public int EmployeeId { get; set; }  

        public DateTime StartTime { get; set; }  

        public int Duration { get; set; }  
        public string Description { get; set; } = string.Empty;  

        public DateType DateType { get; set; }  

        // RequestType burada yok çünkü Emergency sabit olarak handler'da setlenecek
    }
}
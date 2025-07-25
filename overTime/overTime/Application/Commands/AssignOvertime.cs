using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Features
{
    public class AssignOvertime
    {
        public int EmployeeId { get; set; }  

        public DateTime StartTime { get; set; }  

        public int EstimatedDuration { get; set; }  

        public string Description { get; set; } = string.Empty;  

        public int AssignedById { get; set; } // sistem giriş yapan kullanıcıdan alınır dto da olmaz 

        //public RequestType RequestType { get; set; }  -> bu olmasın bence çünkü bizim request typlearımız Assigned, SelfRequested, Emergency şeklinde. yani bu zaten assigned? b
        //bunu handler içerisinde default olarak assigned alabiliriz  RequestType = RequestType.Assigned şeklinde 

        public DateType DateType { get; set; }  
        
    }
}
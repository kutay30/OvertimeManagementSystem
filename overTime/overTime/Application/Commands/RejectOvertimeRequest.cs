using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Features
{
    public class RejectOvertimeRequest
    {
         public int RejectionId { get; set; }  // servisten dçner dto lazım değil 

        public int RequestId { get; set; }  // dto da olacaksa endpointlerde yazamıyoruz. endpointlerde [HttpPost("{id}/reject")] şeklinde id yi getirecekse dto da olmayacak  

        public int RejecterId { get; set; }   // servisten dçner dto lazım değil 

        public DateTime RejectedAt { get; set; }  // sotomatik set edilecek dto lazım değil 

        public RejectionReason RejectionReasonEnum { get; set; }  

        public string RejectionReasonText { get; set; }  // bu asla null olmamalı buraya dto eklerken dto içerisinde [required] kullanacağıuz '!!
    }
}
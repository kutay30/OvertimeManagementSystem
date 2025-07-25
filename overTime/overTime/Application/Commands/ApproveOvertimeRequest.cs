using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using overTime.Domain.entities.Enums;

namespace Application.Features
{
    public class ApproveOvertimeRequest
    {
         public int ApprovalId { get; set; } // sistem set eder 

         public int RequestId { get; set; } 

         public int ApproverId { get; set; } // dto da yok token döner 

         public RequestStatus Status { get; set; } 

         public DateTime? ApprovedAt { get; set; } // sistem tarafından set edilir 

         public RejectionReason? RejectionReasonEnum { get; set; } 
         
         public string? RejectionReasonText { get; set; } 
    }
}
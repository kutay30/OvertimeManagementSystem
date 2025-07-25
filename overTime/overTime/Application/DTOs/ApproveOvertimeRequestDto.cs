using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using overTime.Domain.entities.Enums;

namespace Application.DTOs
{
    public class ApproveOvertimeRequestDto
    {
        public int RequestId { get; set; }

        public RequestStatus Status { get; set; }

        public RejectionReason? RejectionReasonEnum { get; set; }

        public string? RejectionReasonText { get; set; }
    }
}
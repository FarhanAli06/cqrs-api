using SH.LeaveManagement.Application.DTOs.Common;
using SH.LeaveManagement.Application.DTOs.LeaveType;
using SH.LeaveManagement.Application.Models.Identity;

namespace SH.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto:BaseDto
    {
        public Employee Employee { get; set; }
        public string RequestingEmployeeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Approved { get; set; }
    }
}

using SH.LeaveManagement.Application.DTOs.Common;
using SH.LeaveManagement.Application.DTOs.LeaveType;
using SH.LeaveManagement.Application.Models.Identity;

namespace SH.LeaveManagement.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public Employee Employee { get; set; }
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}

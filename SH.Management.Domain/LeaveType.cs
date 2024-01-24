
using SH.LeaveManagement.Domain.Common;

namespace SH.LeaveManagement.Domain
{
    public class LeaveType: BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

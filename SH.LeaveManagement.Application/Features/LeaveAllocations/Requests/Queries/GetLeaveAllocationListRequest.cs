using MediatR;
using SH.LeaveManagement.Application.DTOs.LeaveAllocation;

namespace SH.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
        public bool IsLoggedInUser { get; set; }
    }
}

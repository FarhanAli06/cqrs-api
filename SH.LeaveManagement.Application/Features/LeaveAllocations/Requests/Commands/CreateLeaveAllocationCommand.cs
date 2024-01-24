using MediatR;
using SH.LeaveManagement.Application.DTOs.LeaveAllocation;
using SH.LeaveManagement.Application.Responses;

namespace SH.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}

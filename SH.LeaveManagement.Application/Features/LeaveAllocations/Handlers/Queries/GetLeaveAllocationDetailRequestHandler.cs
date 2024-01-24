using AutoMapper;
using MediatR;
using SH.LeaveManagement.Application.Contracts.Persistence;
using SH.LeaveManagement.Application.DTOs;
using SH.LeaveManagement.Application.DTOs.LeaveAllocation;
using SH.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace SH.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = new LeaveAllocationDto();
                //farhan comment await _leaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
        }
    }
}

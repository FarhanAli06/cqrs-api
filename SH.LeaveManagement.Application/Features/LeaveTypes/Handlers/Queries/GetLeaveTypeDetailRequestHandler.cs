
using AutoMapper;
using MediatR;
using SH.LeaveManagement.Application.Contracts.Persistence;
using SH.LeaveManagement.Application.DTOs.LeaveType;
using SH.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;

namespace SH.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    internal class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}

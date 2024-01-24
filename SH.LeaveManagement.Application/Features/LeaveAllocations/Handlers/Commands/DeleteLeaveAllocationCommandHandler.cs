using AutoMapper;
using SH.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using MediatR;
using SH.LeaveManagement.Application.Contracts.Persistence;
using SH.LeaveManagement.Application.Exceptions;
using SH.LeaveManagement.Domain;

namespace SH.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _unitOfWork.LeaveAllocationRepository.Get(request.Id);

            if (leaveAllocation == null)
                throw new NotFoundException(nameof(LeaveAllocation), request.Id);

            await _unitOfWork.LeaveAllocationRepository.Delete(leaveAllocation);
            await _unitOfWork.Save();
            return Unit.Value;
        }
    }
}

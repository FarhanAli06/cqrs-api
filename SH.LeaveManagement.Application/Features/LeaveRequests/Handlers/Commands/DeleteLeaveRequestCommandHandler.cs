﻿using AutoMapper;
using SH.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using MediatR;
using SH.LeaveManagement.Application.Contracts.Persistence;
using SH.LeaveManagement.Application.Exceptions;
using SH.LeaveManagement.Domain;

namespace SH.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteLeaveRequestCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _unitOfWork.LeaveRequestRepository.Get(request.Id);

            if (leaveRequest == null)
                throw new NotFoundException(nameof(LeaveRequest), request.Id);

            await _unitOfWork.LeaveRequestRepository.Delete(leaveRequest);
            await _unitOfWork.Save();
            return Unit.Value;
        }
    }
}

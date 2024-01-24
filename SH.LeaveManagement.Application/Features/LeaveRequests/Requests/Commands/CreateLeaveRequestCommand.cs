
using MediatR;
using SH.LeaveManagement.Application.DTOs.LeaveRequest;
using SH.LeaveManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SH.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }

    }
}

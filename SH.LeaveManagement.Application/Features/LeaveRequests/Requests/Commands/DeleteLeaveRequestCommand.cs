using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SH.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}

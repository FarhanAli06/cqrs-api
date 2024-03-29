﻿using SH.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SH.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }

    }
}

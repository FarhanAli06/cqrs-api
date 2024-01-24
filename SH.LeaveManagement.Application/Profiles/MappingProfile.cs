using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SH.LeaveManagement.Application.DTOs;
using SH.LeaveManagement.Application.DTOs.LeaveAllocation;
using SH.LeaveManagement.Application.DTOs.LeaveRequest;
using SH.LeaveManagement.Application.DTOs.LeaveType;
using SH.LeaveManagement.Domain;

namespace SH.LeaveManagement.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile() 
        {

            #region LeaveRequest Mappings
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>()
                .ForMember(dest => dest.DateRequested, opt => opt.MapFrom(src => src.DateCreated))
                .ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();
            #endregion LeaveRequest

            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, UpdateLeaveAllocationDto>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();

        }
    }
}

using AutoMapper;
using CollegeManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Infra.Dtos;

namespace CollegeManagement.Api
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<College, CollegeDto>();
			CreateMap<CollegeDto, College>();

			CreateMap<Building, BuildingDto>();
			CreateMap<BuildingDto, Building>();

			CreateMap<Group, GroupDto>();
			CreateMap<GroupDto, Group>();

			CreateMap<Employee, EmployeeDto>();
			CreateMap<EmployeeDto, Employee>();

			CreateMap<PayCheck, PayCheckDto>();
			CreateMap<PayCheckDto, PayCheck>();

			CreateMap<Student, StudentDto>();
			CreateMap<StudentDto, Student>();

			CreateMap<StudentTeacher, StudentTeacherDto>();
			CreateMap<StudentTeacherDto, StudentTeacher>();
		}
	}
}

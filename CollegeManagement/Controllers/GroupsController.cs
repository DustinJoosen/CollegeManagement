using AutoMapper;
using CollegeManagement.Api.Models;
using CollegeManagement.Api.Services;
using CollegeManagement.Infra.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GroupsController : ControllerBase
	{
		private IGroupService _service;
		private IEmployeeService _employeeService;

		private IMapper _mapper;

		public GroupsController(IGroupService service, IEmployeeService employeeService, IMapper mapper)
		{
			this._service = service;
			this._employeeService = employeeService;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult> Get()
		{
			var groups = await _service.GetAll();
			return Ok(_mapper.Map<List<GroupDto>>(groups));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetById(int id)
		{
			var group = await _service.GetById(id);

			if (group == null)
				return NotFound();

			return Ok(_mapper.Map<GroupDto>(group));
		}

		[HttpPost]
		public async Task<ActionResult> Create(GroupDto groupDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var group = _mapper.Map<Group>(groupDto);
			await _service.Create(group);

			return Ok(_mapper.Map<GroupDto>(group));
		}

		[HttpPut]
		public async Task<ActionResult> Update(GroupDto groupDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var group = await _service.GetById(groupDto.Id);
			if (group == null)
				return NotFound();

			_mapper.Map(groupDto, group);
			await _service.Update(group);

			return Ok(_mapper.Map<GroupDto>(group));
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var group = await _service.GetById(id);
			if (group == null)
				return NotFound();

			await _service.Remove(group);
			return Ok(_mapper.Map<GroupDto>(group));
		}

		[HttpGet("{id}/participants")]
		public async Task<ActionResult> GetParticipants(int id)
		{
			var group = await _service.GetById(id);
			if (group == null)
				return NotFound();

			var mentor = await _employeeService.GetById(group.MentorId);
			if (mentor == null)
				return NotFound();

			var students = await _employeeService.GetStudents(mentor.Id);

			return Ok(new ClassParticipantsDto()
			{
				Mentor = _mapper.Map<EmployeeDto>(mentor),
				Students = _mapper.Map<List<StudentDto>>(students)
			});
		} 

	}
}
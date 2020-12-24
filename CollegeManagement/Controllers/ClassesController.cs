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
	public class ClassesController : ControllerBase
	{
		private IClassService _service;
		private IEmployeeService _employeeService;

		private IMapper _mapper;

		public ClassesController(IClassService service, IEmployeeService employeeService, IMapper mapper)
		{
			this._service = service;
			this._employeeService = employeeService;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult> Get()
		{
			var classes = await _service.GetAll();
			return Ok(_mapper.Map<List<ClassDto>>(classes));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetById(int id)
		{
			var clas = await _service.GetById(id);

			if (clas == null)
				return NotFound();

			return Ok(_mapper.Map<ClassDto>(clas));
		}

		[HttpPost]
		public async Task<ActionResult> Create(ClassDto classDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var clas = _mapper.Map<Class>(classDto);
			await _service.Create(clas);

			return Ok(_mapper.Map<ClassDto>(clas));
		}

		[HttpPut]
		public async Task<ActionResult> Update(ClassDto classDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var clas = await _service.GetById(classDto.Id);
			if (clas == null)
				return NotFound();

			_mapper.Map(classDto, clas);
			await _service.Update(clas);

			return Ok(_mapper.Map<ClassDto>(clas));
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var clas = await _service.GetById(id);
			if (clas == null)
				return NotFound();

			await _service.Remove(clas);
			return Ok(_mapper.Map<ClassDto>(clas));
		}

		[HttpGet("{id}/participants")]
		public async Task<ActionResult> GetParticipants(int id)
		{
			var clas = await _service.GetById(id);
			if (clas == null)
				return NotFound();

			var mentor = await _employeeService.GetById(clas.MentorId);
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
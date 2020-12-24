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
	public class StudentsController : ControllerBase
	{
		private IStudentService _service;
		private IMapper _mapper;

		public StudentsController(IStudentService service, IMapper mapper)
		{
			this._service = service;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult<List<Student>>> Get()
		{
			var students = await _service.GetAll();
			return Ok(_mapper.Map<List<StudentDto>>(students));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Student>> GetById(int id)
		{
			var student = await _service.GetById(id);

			if (student == null)
				return NotFound();

			return Ok(_mapper.Map<StudentDto>(student));
		}

		[HttpPost]
		public async Task<ActionResult> Create(StudentDto studentDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var student = _mapper.Map<Student>(studentDto);
			await _service.Create(student);

			return Ok(_mapper.Map<StudentDto>(student));
		}

		[HttpPut]
		public async Task<ActionResult> Update(StudentDto studentDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var student = await _service.GetById(studentDto.Id);
			if (student == null)
				return NotFound();

			_mapper.Map(studentDto, student);
			await _service.Update(student);

			return Ok(_mapper.Map<StudentDto>(student));
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var student = await _service.GetById(id);
			if (student == null)
				return NotFound();

			await _service.Remove(student);
			return Ok(_mapper.Map<StudentDto>(student));
		}

	}
}
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
	public class StudentTeachersController : ControllerBase
	{
		private IStudentTeacherService _service;
		private IMapper _mapper;

		public StudentTeachersController(IStudentTeacherService service, IMapper mapper)
		{
			this._service = service;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult<List<StudentTeacher>>> Get()
		{
			var studentteachers = await _service.GetAll();
			return Ok(_mapper.Map<List<StudentTeacherDto>>(studentteachers));
		}

		//[HttpGet("{id}")]
		//public async Task<ActionResult<StudentTeacher>> GetById(int id)
		//{
		//	var studentteacher = await _service.GetById(id);

		//	if (studentteacher == null)
		//		return NotFound();

		//	return Ok(_mapper.Map<StudentTeacherDto>(studentteacher));
		//}

		//[HttpPost]
		//public async Task<ActionResult> Create(StudentTeacherDto studentteacherDto)
		//{
		//	if (!ModelState.IsValid)
		//		return BadRequest();

		//	var studentteacher = _mapper.Map<StudentTeacher>(studentteacherDto);
		//	await _service.Create(studentteacher);

		//	return Ok(_mapper.Map<StudentTeacherDto>(studentteacher));
		//}

		//[HttpPut]
		//public async Task<ActionResult> Update(StudentTeacherDto studentteacherDto)
		//{
		//	if (!ModelState.IsValid)
		//		return BadRequest();

		//	var studentteacher = await _service.GetById(studentteacherDto.Id);
		//	if (studentteacher == null)
		//		return NotFound();

		//	_mapper.Map(studentteacherDto, studentteacher);
		//	await _service.Update(studentteacher);

		//	return Ok(_mapper.Map<StudentTeacherDto>(studentteacher));
		//}

		//[HttpDelete("{id}")]
		//public async Task<ActionResult> Delete(int id)
		//{
		//	var studentteacher = await _service.GetById(id);
		//	if (studentteacher == null)
		//		return NotFound();

		//	await _service.Remove(studentteacher);
		//	return Ok(_mapper.Map<StudentTeacherDto>(studentteacher));
		//}

	}
}
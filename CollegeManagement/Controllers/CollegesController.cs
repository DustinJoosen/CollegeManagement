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
	public class CollegesController : ControllerBase
	{
		private ICollegeService _service;
		private IMapper _mapper;

		public CollegesController(ICollegeService service, IMapper mapper)
		{
			this._service = service;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult> Get()
		{
			var colleges = await _service.GetAll();
			return Ok(_mapper.Map<List<CollegeDto>>(colleges));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetById(int id)
		{
			var college = await _service.GetById(id);

			if (college == null)
				return NotFound();

			return Ok(_mapper.Map<CollegeDto>(college));
		}

		[HttpPost]
		public async Task<ActionResult> Create(CollegeDto collegeDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var college = _mapper.Map<College>(collegeDto);
			await _service.Create(college);

			return Ok(_mapper.Map<CollegeDto>(college));
		}

		[HttpPut]
		public async Task<ActionResult> Update(CollegeDto collegeDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var college = await _service.GetById(collegeDto.Id);
			if (college == null)
				return NotFound();

			_mapper.Map(collegeDto, college);
			await _service.Update(college);

			return Ok(_mapper.Map<CollegeDto>(college));
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var college = await _service.GetById(id);
			if (college == null)
				return NotFound();

			await _service.Remove(college);
			return Ok(_mapper.Map<CollegeDto>(college));
		}

	}
}
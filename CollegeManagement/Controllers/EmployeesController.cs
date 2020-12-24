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
	public class EmployeesController : ControllerBase
	{
		private IEmployeeService _service;
		private IMapper _mapper;

		public EmployeesController(IEmployeeService service, IMapper mapper)
		{
			this._service = service;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult<List<Employee>>> Get()
		{
			var employees = await _service.GetAll();
			return Ok(_mapper.Map<List<EmployeeDto>>(employees));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Employee>> GetById(int id)
		{
			var employee = await _service.GetById(id);

			if (employee == null)
				return NotFound();

			return Ok(_mapper.Map<EmployeeDto>(employee));
		}

		[HttpPost]
		public async Task<ActionResult> Create(EmployeeDto employeeDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var employee = _mapper.Map<Employee>(employeeDto);
			await _service.Create(employee);

			return Ok(_mapper.Map<EmployeeDto>(employee));
		}

		[HttpPut]
		public async Task<ActionResult> Update(EmployeeDto employeeDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var employee = await _service.GetById(employeeDto.Id);
			if (employee == null)
				return NotFound();

			_mapper.Map(employeeDto, employee);
			await _service.Update(employee);

			return Ok(_mapper.Map<EmployeeDto>(employee));
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var employee = await _service.GetById(id);
			if (employee == null)
				return NotFound();

			await _service.Remove(employee);
			return Ok(_mapper.Map<EmployeeDto>(employee));
		}

	}
}
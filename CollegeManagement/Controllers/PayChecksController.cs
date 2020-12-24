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
	public class PayChecksController : ControllerBase
	{
		private IPayCheckService _service;
		private IMapper _mapper;

		public PayChecksController(IPayCheckService service, IMapper mapper)
		{
			this._service = service;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult<List<PayCheck>>> Get()
		{
			var paychecks = await _service.GetAll();
			return Ok(_mapper.Map<List<PayCheckDto>>(paychecks));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<PayCheck>> GetById(int id)
		{
			var paycheck = await _service.GetById(id);

			if (paycheck == null)
				return NotFound();

			return Ok(_mapper.Map<PayCheckDto>(paycheck));
		}

		[HttpPost]
		public async Task<ActionResult> Create(PayCheckDto paycheckDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var paycheck = _mapper.Map<PayCheck>(paycheckDto);
			await _service.Create(paycheck);

			return Ok(_mapper.Map<PayCheckDto>(paycheck));
		}

		[HttpPut]
		public async Task<ActionResult> Update(PayCheckDto paycheckDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var paycheck = await _service.GetById(paycheckDto.Id);
			if (paycheck == null)
				return NotFound();

			_mapper.Map(paycheckDto, paycheck);
			await _service.Update(paycheck);

			return Ok(_mapper.Map<PayCheckDto>(paycheck));
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var paycheck = await _service.GetById(id);
			if (paycheck == null)
				return NotFound();

			await _service.Remove(paycheck);
			return Ok(_mapper.Map<PayCheckDto>(paycheck));
		}

	}
}
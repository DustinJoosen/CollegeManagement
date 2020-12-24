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
	public class BuildingsController : ControllerBase
	{
		private IBuildingService _service;
		private IMapper _mapper;

		public BuildingsController(IBuildingService service, IMapper mapper)
		{
			this._service = service;
			this._mapper = mapper;
		}


		[HttpGet]
		public async Task<ActionResult> Get()
		{
			var buildings = await _service.GetAll();
			return Ok(_mapper.Map<List<BuildingDto>>(buildings));
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetById(int id)
		{
			var building = await _service.GetById(id);

			if (building == null)
				return NotFound();

			return Ok(_mapper.Map<BuildingDto>(building));
		}

		[HttpPost]
		public async Task<ActionResult> Create(BuildingDto buildingDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var building = _mapper.Map<Building>(buildingDto);
			await _service.Create(building);

			return Ok(_mapper.Map<BuildingDto>(building));
		}

		[HttpPut]
		public async Task<ActionResult> Update(BuildingDto buildingDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();

			var building = await _service.GetById(buildingDto.Id);
			if (building == null)
				return NotFound();

			_mapper.Map(buildingDto, building);
			await _service.Update(building);

			return Ok(_mapper.Map<BuildingDto>(building));
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var building = await _service.GetById(id);
			if (building == null)
				return NotFound();

			await _service.Remove(building);
			return Ok(_mapper.Map<BuildingDto>(building));
		}

	}
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkyAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ParkyAPI.Models.Dtos;
using ParkyAPI.Models;
using Microsoft.AspNetCore.Authorization;

namespace ParkyAPI.Controllers
{
    [Route("api/v{version:apiversion}/trails")]
    [ApiController]
    [ProducesResponseType(400)]
    //[ApiExplorerSettings(GroupName = "ParkyOpenAPISpecTrails")]
    public class TrailsController : ControllerBase
    {
        private readonly ITrailsrepository _trailsRepo;
        private readonly IMapper _mapper;
        public TrailsController(ITrailsrepository trailsRepo, IMapper mapper)
        {
            _trailsRepo = trailsRepo;
            _mapper = mapper;
        }

        /// <summary>
        /// Get list of National Parks
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<TrailsDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetTrails()
        {
            var objList = _trailsRepo.GetTrails();
            var objDto = new List<TrailsDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<TrailsDto>(obj));
            }
            return Ok(objDto);
        }

        /// <summary>
        /// Get indiviual National Park
        /// </summary>
        /// <param name="trailId"> The ID of the trail</param>
        /// <returns></returns>
        [HttpGet ("{trailId:int}", Name = "GetTrail")]
        [ProducesResponseType(200, Type = typeof(TrailsDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        [Authorize(Roles = "Admin")]
        public IActionResult GetTrail(int trailId)
        {
            var obj = _trailsRepo.GetTrails(trailId);
            if (obj==null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<TrailsDto>(obj);
            return Ok(objDto);
        }

        [HttpGet("[action]/{nationalParkId:int}", Name = "GetTrailInNationalPark")]
        [ProducesResponseType(200, Type = typeof(TrailsDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesDefaultResponseType]
        public IActionResult GetTrailInNationalPark(int nationalParkId)
        {
            var objList = _trailsRepo.GetTrailsInNationalPark(nationalParkId);
            if (objList == null)
            {
                return NotFound();
            }
            var objDto = new List<TrailsDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<TrailsDto>(obj));
            }
            return Ok(objDto);
        }

        [HttpPost]
        [ProducesResponseType(201, Type = typeof(TrailsDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesDefaultResponseType]
        public IActionResult CreateTrail(TrailsCreateDto dto)
        {
            if (dto == null)
            {
                return BadRequest(ModelState);
            }

            if (_trailsRepo.TrailsExists(dto.Name))
            {
                ModelState.AddModelError("", "Trail already Exists!");
                return StatusCode(404, ModelState);
            }

            var trailObj = _mapper.Map<Trails>(dto);
            if (!_trailsRepo.CreateTrails(trailObj))
            {
                ModelState.AddModelError("", $"Something went wrong while saving {trailObj.Name}");
                return StatusCode(500, ModelState);
            }

            return CreatedAtRoute("GetTrail", new { trailId = trailObj.Id }, trailObj);
        }

        [HttpPatch ("{trailId:int}", Name = "UpdateTrail")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesDefaultResponseType]
        public IActionResult UpdateTrail(int trailId, TrailsUpdateDto dto)
        {
            if (dto == null || trailId != dto.Id)
            {
                return BadRequest(ModelState);
            }

            //if (_npRepo.TrailExists(dto.Name))
            //{
            //    ModelState.AddModelError("", "National Park already Exists!");
            //    return StatusCode(404, ModelState);
            //}
            var trailObj = _mapper.Map<Trails>(dto);
            if (!_trailsRepo.UpdateTrails(trailObj))
            {
                ModelState.AddModelError("", $"Something went wrong while updating {trailObj.Name}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }

        [HttpDelete("{trailId:int}", Name = "DeleteTrail")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        [ProducesResponseType(500)]
        public IActionResult DeleteTrail(int trailId)
        {
            if (!_trailsRepo.TrailsExists(trailId))
            {
                return NotFound();
            }
            var trailObj = _trailsRepo.GetTrails(trailId);
            if (!_trailsRepo.DeleteTrails(trailObj))
            {
                ModelState.AddModelError("", $"Something went wrong while deleting {trailObj.Name}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
    }
}

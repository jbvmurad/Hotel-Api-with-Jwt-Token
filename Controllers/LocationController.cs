using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaÖdev.Entity;
using PatikaTask.DTOs.LocationDTOs;
using PatikaTask.Services;

namespace PatikaTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LocationController(IGeneric<Location> _locationService , IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            var locations = _locationService.GetList();
            if (locations == null)
            {
                return NotFound("No locations found.");
            }
            return Ok(locations);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var existingLocation = _locationService.GetById(id);
            if (existingLocation == null)
            {
                return NotFound("Location not found.");
            }
            return Ok(existingLocation);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingLocation = _locationService.GetById(id);
            if (existingLocation == null)
            {
                return NotFound("Location not found.");
            }
            _locationService.Delete(id);
            return Ok("Location deleted successfully.");
        }
        [HttpPost]
        public IActionResult Create(CreateLocationDTO createLocationDTO)
        {
            var newLocation = _mapper.Map<Location>(createLocationDTO);
            _locationService.Create(newLocation);
            return Ok("Location created successfully.");
        }
        [HttpPut]
        public IActionResult Update(UpdateLocationDTO updateLocationDTO)
        {
            var updatedLocation = _mapper.Map<Location>(updateLocationDTO);
            _locationService.Update(updatedLocation);
            return Ok("Location updated successfully.");
        }
    }
}

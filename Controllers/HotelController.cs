using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaÖdev.Entity;
using PatikaTask.DTOs.HotelDTOs;
using PatikaTask.Services;

namespace PatikaTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HotelController(IGeneric<Hotel> _hotelService , IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            var hotels=_hotelService.GetList();
            if(hotels == null)
            {
                return NotFound("No hotels found.");
            }
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var existinghotel = _hotelService.GetById(id);
            if (existinghotel == null)
            {
                return NotFound("Hotel not found.");
            }
            return Ok(existinghotel);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existinghotel = _hotelService.GetById(id);
            if (existinghotel == null)
            {
                return NotFound("Hotel not found.");
            }
            _hotelService.Delete(id);
            return Ok("Hotel  deleted successfully.");
        }

        [HttpPost]
        public IActionResult Create (CreateHotelDTO createHotelDTO)
        {
            var newhotel=_mapper.Map<Hotel>(createHotelDTO);
            _hotelService.Create(newhotel);
            return Ok("Hotel created successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateHotelDTO updateHotelDTO)
        {
            var hotel = _mapper.Map<Hotel>(updateHotelDTO);
            _hotelService.Update(hotel);
            return Ok("Hotel updated successfully.");
        }
    }
}

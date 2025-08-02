using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatikaÖdev.Entity;
using PatikaTask.DTOs.RoomDTOs;
using PatikaTask.Services;

namespace PatikaTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RoomController(IGeneric<Room> _roomService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            var rooms = _roomService.GetList();
            if (rooms == null)
            {
                return NotFound("No rooms found.");
            }
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var existingRoom = _roomService.GetById(id);
            if (existingRoom == null)
            {
                return NotFound("Room not found.");
            }
            return Ok(existingRoom);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingRoom = _roomService.GetById(id);
            if (existingRoom == null)
            {
                return NotFound("Room not found.");
            }
            _roomService.Delete(id);
            return Ok("Room deleted successfully.");
        }

        [HttpPost]
        public IActionResult Create(CreateRoomDTO createRoomDTO)
        {
            var newroom = _mapper.Map<Room>(createRoomDTO);
            _roomService.Create(newroom);
            return Ok("Room created successfully.");
        }

        [HttpPut]
        public IActionResult Update(UpdateRoomDTO updateRoomDTO)
        {

            var updatedRoom = _mapper.Map<Room>(updateRoomDTO);
            _roomService.Update(updatedRoom);
            return Ok("Room created successfully.");
        }
    }
}

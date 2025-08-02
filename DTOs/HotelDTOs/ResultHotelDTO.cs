using PatikaTask.DTOs.CustomerDTOs;
using PatikaTask.DTOs.LocationDTOs;
using PatikaTask.DTOs.RoomDTOs;

namespace PatikaTask.DTOs.HotelDTOs
{
    public class ResultHotelDTO
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public ResultLocationDTO Location { get; set; }
        public List<ResultRoomDTO> Rooms { get; set; } = new List<ResultRoomDTO>();
        public List<ResultCustomerDTO> Customers { get; set; } = new List<ResultCustomerDTO>();
    }
}

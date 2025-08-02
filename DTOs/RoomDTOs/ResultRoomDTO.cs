using PatikaTask.DTOs.CustomerDTOs;
using PatikaTask.DTOs.HotelDTOs;

namespace PatikaTask.DTOs.RoomDTOs
{
    public class ResultRoomDTO
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }

        public int HotelId { get; set; }
        public ResultHotelDTO Hotel { get; set; }

        public List<ResultCustomerDTO> Customers { get; set; } = new List<ResultCustomerDTO>();
    }
}

using PatikaTask.DTOs.HotelDTOs;

namespace PatikaTask.DTOs.LocationDTOs
{
    public class ResultLocationDTO
    {
        public int LocationId { get; set; }
        public string Address { get; set; }

        public int HotelId { get; set; }
        public ResultHotelDTO Hotel { get; set; }
    }
}

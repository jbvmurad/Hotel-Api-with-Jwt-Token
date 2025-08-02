using PatikaTask.DTOs.HotelDTOs;
using PatikaTask.DTOs.RoomDTOs;

namespace PatikaTask.DTOs.CustomerDTOs
{
    public class UpdateCustomerDTO
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int HotelId { get; set; }

        public int RoomId { get; set; }
    }
}

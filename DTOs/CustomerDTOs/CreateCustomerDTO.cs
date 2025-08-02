namespace PatikaTask.DTOs.CustomerDTOs
{
    public class CreateCustomerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int HotelId { get; set; }

        public int RoomId { get; set; }
    }
}

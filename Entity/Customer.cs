namespace PatikaÖdev.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public int RoomId { get; set; } 
        public Room Room { get; set; }
    }
}
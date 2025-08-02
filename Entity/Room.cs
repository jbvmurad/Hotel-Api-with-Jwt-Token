namespace PatikaÖdev.Entity
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
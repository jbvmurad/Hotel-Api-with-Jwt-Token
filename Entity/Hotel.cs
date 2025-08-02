namespace PatikaÖdev.Entity
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>();

        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}
namespace PatikaÖdev.Entity
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Address { get; set; } 

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
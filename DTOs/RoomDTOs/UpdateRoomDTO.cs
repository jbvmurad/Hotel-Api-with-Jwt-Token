namespace PatikaTask.DTOs.RoomDTOs
{
    public class UpdateRoomDTO
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }

        public int HotelId { get; set; }
    }
}

using AutoMapper;
using PatikaÖdev.Entity;
using PatikaTask.DTOs.CustomerDTOs;
using PatikaTask.DTOs.HotelDTOs;
using PatikaTask.DTOs.LocationDTOs;
using PatikaTask.DTOs.RoomDTOs;
namespace PatikaTask.Map
{
    public class UniversalMap:Profile
    {
        public UniversalMap() 
        {
            ConfigureHotelMap();
            ConfigureRoomMap();
            ConfigureCustomerMap();
            ConfigureLocationMap();
        }
        private void ConfigureHotelMap()
        {
            CreateMap<CreateHotelDTO , Hotel>().ReverseMap();
            CreateMap<UpdateHotelDTO, Hotel>().ReverseMap();
            CreateMap<ResultHotelDTO, Hotel>().ReverseMap();
        }
        private void ConfigureRoomMap()
        {
            CreateMap<CreateRoomDTO, Room>().ReverseMap();
            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
            CreateMap<ResultRoomDTO, Room>().ReverseMap();
        }
        private void ConfigureCustomerMap()
        {
            CreateMap<CreateCustomerDTO, Customer>().ReverseMap();
            CreateMap<UpdateCustomerDTO, Customer>().ReverseMap();
            CreateMap<ResultCustomerDTO, Customer>().ReverseMap();
        }
        private void ConfigureLocationMap()
        {
            CreateMap<CreateLocationDTO, Location>().ReverseMap();
            CreateMap<UpdateLocationDTO, Location>().ReverseMap();
            CreateMap<ResultLocationDTO, Location>().ReverseMap();
        }
    }
}

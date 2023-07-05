using AutoMapper;
using Training.Infrastucture.DbModels;

namespace Training.App.Utils
{
    public class MapperProfile : Profile
    {
        public static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                //Configuring ClientResponse and Client
                cfg.CreateMap<Client, ClientResponse>()
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name + " " + src.Surname))
                .ForMember(dest => dest.Phone, act => act.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                .ForMember(dest => dest.DocumentationNumber, act => act.MapFrom(src => src.NumDocument));

                //Configuring WorkingArea and WorkingAreaResponse
                cfg.CreateMap<WorkingArea, WorkingAreaResponse>()
                .ForMember(dest => dest.WorkingAreaId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Zone, act => act.MapFrom(src => src.Zone));

                //Configuring Accommodation and AccommodationResponse
                cfg.CreateMap<Accommodation, AccommodationResponse>()
                .ForMember(dest => dest.AccommodationId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.AccommodationName))
                .ForMember(dest => dest.WorkingAreaId, act => act.MapFrom(src => src.WorkingAreaId));

                //Configuring AccommodationTemplate and AccommodationTemplateResponse
                cfg.CreateMap<AccommodationTemplate, AccommodationTemplateResponse>()
                .ForMember(dest => dest.AccommodationTemplateId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.AccommodationId, act => act.MapFrom(src => src.AccommodationId))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Message));

                //Configuring Sendtype and SendTypeResponse
                cfg.CreateMap<SendType, SendTypeResponse>()
                .ForMember(dest => dest.SendTypeId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.TypeMessage, act => act.MapFrom(src => src.Message))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.ClientId));

                //Configuring ClientSendtype and ClientSendTypeResponse
                cfg.CreateMap<ClientSendType, ClientSendTypeResponse>()
                .ForMember(dest => dest.ClientSendTypeId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.SendTypeId, act => act.MapFrom(src => src.SendTypeId))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.ClientId));

                //Configuring Booking and BookingResponse
                cfg.CreateMap<Booking, BookingResponse>()
                .ForMember(dest => dest.BookingId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.AccommodationId, act => act.MapFrom(src => src.AccommodationId))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.ClientId))
                .ForMember(dest => dest.SendTypeId, act => act.MapFrom(src => src.SendTypeId));

                //Configuring Booking and BookingResponse
                cfg.CreateMap<Log, LogResponse>()
                .ForMember(dest => dest.LogId, act => act.MapFrom(src => src.Id))
                .ForMember(dest => dest.AccommodationId, act => act.MapFrom(src => src.AccommodationId))
                .ForMember(dest => dest.SendTypeId, act => act.MapFrom(src => src.SendTypeId))
                .ForMember(dest => dest.Message, act => act.MapFrom(src => src.Message));

            });

            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}

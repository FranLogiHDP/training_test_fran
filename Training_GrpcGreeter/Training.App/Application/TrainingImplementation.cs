using Grpc.Core;
using Training.App.Application.Services.AccommodationService;
using Training.App.Application.Services.AccommodationTemplateService;
using Training.App.Application.Services.BookingService;
using Training.App.Application.Services.ClientSendTypeService;
using Training.App.Application.Services.ClientService;
using Training.App.Application.Services.LogService;
using Training.App.Application.Services.SendTypeService;
using Training.App.Application.Services.WorkingAreaService;

namespace Training.App.Application
{
    public class TrainingImplementation : Training.TrainingBase
    {

        private readonly IClientService _clientService;
        private readonly IWorkingAreaService _workingAreaService;
        private readonly IAccommodationService _accommodationService;
        private readonly IAccommodationTemplateService _accommodationTemplateService;
        private readonly ISendTypeService _sendTypeService;
        private readonly IClientSendTypeService _clientSendTypeService;
        private readonly ILogService _logservice;
        private readonly IBookingService _bookingservice;


        public TrainingImplementation(
            IClientService clientService,
            IWorkingAreaService workingAreaService,
            IAccommodationService accommodationService,
            IAccommodationTemplateService accommodationTemplateService,
            ISendTypeService sendTypeService,
            IClientSendTypeService clientSendTypeService,
            ILogService logService,
            IBookingService bookingService)
        {
            _clientService = clientService;
            _workingAreaService = workingAreaService;
            _accommodationService = accommodationService;
            _accommodationTemplateService = accommodationTemplateService;
            _sendTypeService = sendTypeService;
            _clientSendTypeService = clientSendTypeService;
            _logservice = logService;
            _bookingservice = bookingService;
        }

        public override async Task<ClientResponse> GetClient(ClientRequest request, ServerCallContext context)
        {
            return await _clientService.GetClientAsync(request);
        }
        public override async Task<ClientListResponse> GetClientList(ClientListRequest request, ServerCallContext context)
        {
            return await _clientService.GetListClientAsync(request);
        }

        public override async Task<WorkingAreaListResponse> GetWorkingAreaList(WorkingAreaListRequest request, ServerCallContext context)
        {
            return await _workingAreaService.GetWorkingAreaListAsync(request);
        }

        public override async Task<AccommodationListResponse> GetAccommodationList(AccommodationListRequest request, ServerCallContext context)
        {
            return await _accommodationService.GetAccommodationListAsync(request);
        }

        public override async Task<AccommodationTemplateListResponse> GetAccommodationTemplateList(AccommodationTemplateListRequest request, ServerCallContext context)
        {
            return await _accommodationTemplateService.GetAccommodationTemplateListAsync(request);
        }
        public override async Task<SendTypeListResponse> GetSendTypeList(SendTypeListRequest request, ServerCallContext context)
        {
            return await _sendTypeService.GetSendTypeListAsync(request);
        }
        public override async Task<ClientSendTypeListResponse> GetClientSendTypeList(ClientSendTypeListRequest request, ServerCallContext context)
        {
            return await _clientSendTypeService.GetClientSendTypeListAsync(request);
        }
        public override async Task<LogListResponse> GetLogList(LogListRequest request, ServerCallContext context)
        {
            return await _logservice.GetLogListAsync(request);
        }
        public override async Task<BookingListResponse> GetBookingList(BookingListRequest request, ServerCallContext context)
        {
            return await _bookingservice.GetBookingListAsync(request);
        }
        public override async Task<BookingUpsertResponse> UpsertBooking(BookingUpsertRequest request, ServerCallContext context)
        {
            return await _bookingservice.UpsertBookingAsync(request);
        }

    }
}

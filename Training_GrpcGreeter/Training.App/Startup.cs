using Microsoft.EntityFrameworkCore;
using Prometheus;
using Training.App.Application;
using Training.App.Application.Services.AccommodationService;
using Training.App.Application.Services.AccommodationTemplateService;
using Training.App.Application.Services.BookingService;
using Training.App.Application.Services.ClientSendTypeService;
using Training.App.Application.Services.ClientService;
using Training.App.Application.Services.LogService;
using Training.App.Application.Services.SendMessageService;
using Training.App.Application.Services.SendTypeService;
using Training.App.Application.Services.WorkingAreaService;
using Training.Infrastucture.Context;
using Training.Infrastucture.Repository.AccommodationRepository;
using Training.Infrastucture.Repository.BookingRepository;

namespace Training.App
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment enviroment)
        {
            Configuration = configuration;
            Environment = enviroment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(p =>
            {
                var connectionString = Configuration.GetSection("ConnectionString")["PostgresSQLConnection"];

                return new DbContextOptionsBuilder<TrainingDbContext>()
                    .UseNpgsql(connectionString)
                    .Options;
            });

            //Services
            services.AddSingleton<TrainingImplementation>();
            services.AddSingleton<IClientService, ClientService>();
            services.AddSingleton<IWorkingAreaService, WorkingAreaService>();
            services.AddSingleton<IAccommodationService, AccommodationService>();
            services.AddSingleton<IAccommodationTemplateService, AccommodationTemplateService>();
            services.AddSingleton<ISendTypeService, SendTypeService>();
            services.AddSingleton<IClientSendTypeService, ClientSendTypeService>();
            services.AddSingleton<ILogService, LogService>();
            services.AddSingleton<IBookingService, BookingService>();
            services.AddSingleton<ICommunicationService, CommunicationService>();

            //Repository
            services.AddSingleton<IBookingRepository, BookingRepository>();
            services.AddSingleton<IAccommodationRepository, AccommodationRepository>();

            services.AddGrpc();
            services.AddGrpcReflection();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseHttpMetrics();
            app.UseGrpcMetrics();

            // Configure the HTTP request pipeline.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<TrainingImplementation>();

                endpoints.MapGrpcReflectionService();
            });
        }
    }
}

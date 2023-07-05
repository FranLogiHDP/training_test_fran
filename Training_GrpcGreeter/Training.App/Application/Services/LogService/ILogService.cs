namespace Training.App.Application.Services.LogService
{
    public interface ILogService
    {
        Task<LogListResponse> GetLogListAsync(LogListRequest request);
    }
}

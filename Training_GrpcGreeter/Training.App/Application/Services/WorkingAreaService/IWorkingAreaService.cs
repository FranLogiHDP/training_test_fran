namespace Training.App.Application.Services.WorkingAreaService
{
    public interface IWorkingAreaService
    {
        Task<WorkingAreaListResponse> GetWorkingAreaListAsync(WorkingAreaListRequest request);
    }
}

using Training.Infrastucture.DbModels;

namespace Training.Infrastucture.Repository.AccommodationRepository
{
    public interface IAccommodationRepository
    {
        List<Accommodation> GetAccommodationListByZoneId(int? zoneId);
    }
}

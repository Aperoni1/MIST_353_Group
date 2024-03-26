using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherServices
    {
        public Task<List<Weather>> GetWeatherDetails();
    }
}

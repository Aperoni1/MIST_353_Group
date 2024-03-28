using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        Task<List<Weather>> CarterProctorSP3(int WeatherID); // Weather Status by ID SP
        Task<List<Location>> CarterProctorSPs(int LocationID); // Park Status SP
    }
}
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
       public Task<List<Weather>> CarterProctorSP2(int WeatherID); // Weather Status by ID SP
       public Task<List<Location>> CarterProctorSPs(int LocationID); // Park Status SP
    }
}
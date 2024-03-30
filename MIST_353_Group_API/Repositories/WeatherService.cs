using MIST_353_Group_API.Entities;
using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;

namespace MIST_353_Group_API.Repositories
{
    public class WeatherService : IWeatherService
    {
        private readonly DbContextClass _dbContextClass;

        public WeatherService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<Weather> GetWeatherByParkName(string parkName)
        {
            var result = await _dbContextClass.Weather
                .FromSqlInterpolated($"EXEC CarterProctorSPs @ParkName={parkName}")
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<Weather> GetWeatherByLocation(int locationId)
        {
            var result = await _dbContextClass.Weather
                .FromSqlInterpolated($"EXEC CarterProctorSP2 {locationId}")
                .FirstOrDefaultAsync();

            return result;
        }
    }
}

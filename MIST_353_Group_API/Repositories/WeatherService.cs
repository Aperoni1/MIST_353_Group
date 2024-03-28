
using MIST_353_Group_API.Entities;
using Microsoft.Data.SqlClient;
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

        public async Task<string> GetParkName(int locationId)
        {
            var parkName = await _dbContextClass.Location
                .FromSqlInterpolated($"EXEC CarterProctorSPs {locationId}")
                .Select(l => l.ParkName)
                .FirstOrDefaultAsync();

            return parkName;
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
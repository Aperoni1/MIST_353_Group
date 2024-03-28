
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

        public async Task<string> GetParkStatus(int locationId)
        {
            var param = new SqlParameter("@LocationID", locationId);
            var result = await _dbContextClass.Weather
                .FromSqlRaw("EXEC CarterProctorSPs @LocationID", param)
                .FirstOrDefaultAsync();

            if (result != null)
            {
                return result.ParkStatus;
            }
            else
            {
                return null; // Or any default value you want to return if no data is found
            }
        }

        public async Task<Weather> GetWeatherByLocation(int locationId)
        {
            var param = new SqlParameter("@LocationID", locationId);
            var result = await _dbContextClass.Weather
                .FromSqlRaw("EXEC CarterProctorSP2 @LocationID", param)
                .FirstOrDefaultAsync();

            return result;
        }
    }
}

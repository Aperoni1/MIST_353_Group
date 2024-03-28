
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
                .AsQueryable()
                .Select(p => p.ParkStatus)
                .FirstOrDefaultAsync();

            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public async Task<Weather> GetWeatherByLocation(int locationId)
        {
            var param = new SqlParameter("@LocationID", locationId);
            var result = await _dbContextClass.Weather
                .FromSqlRaw("EXEC CarterProctorSP2 @LocationID", param)
                .AsQueryable()
                .FirstOrDefaultAsync();


            return result;
        }
    }
}


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

        public async Task<List<Weather>> CarterProctorSP2(int LocationID)
        {
            var param = new SqlParameter("@LocationID", LocationID);
            return await _dbContextClass.Weather.FromSqlRaw("exec CarterProctorSP3 @WeatherID", param).ToListAsync();
        }

        public async Task<List<Location>>CarterProctorSPs(int LocationID)
        {
            var param = new SqlParameter("@LocationID", LocationID);
            return await _dbContextClass.Location.FromSqlRaw("exec CarterProctorSPs @LocationID", param).ToListAsync();

        }

      
    }
}
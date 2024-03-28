
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

        public async Task<string> CarterProctorSP2(int LocationID)
        {
            var param = new SqlParameter("@LocationID", LocationID);
            var result = await _dbContextClass.Database.ExecuteSqlRawAsync("exec CarterProctorSP2 @LocationID", param);
            return result.ToString();
        }


        public async Task<string> CarterProctorSPs(int LocationID)
        {
            var param = new SqlParameter("@LocationID", LocationID);
            var result = await _dbContextClass.Database.ExecuteSqlRawAsync("exec CarterProctorSPs @LocationID", param);
            return result.ToString();
        }



    }
}
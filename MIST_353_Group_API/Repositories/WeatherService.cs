
using MIST_353_Group_API.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;


 

namespace MIST_353_Group_API.Repositories
{
    public class WeatherService : IWeatherService
    {
        private readonly DbContextClass  _dbcontextClass;
        public WeatherService(DbContextClass dbcontextClass) 
        {
            _dbcontextClass = dbcontextClass;
        }

        public async Task<List<Weather>> CarterProctorSPs(int WeatherID)//SPCarter1 Humidity SP
        {
            var param = new SqlParameter("@WeatherID", WeatherID);
            var humidityDetails = await Task.Run(() => _dbcontextClass.Weather.FromSqlRaw("exec CarterProctorSPs @WeatherID", param).ToListAsync());
            return humidityDetails;

        }    


    }
}

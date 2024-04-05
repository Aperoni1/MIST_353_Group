using MIST_353_Group_API.Entities;
using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

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
            var ParkWeather =  _dbContextClass.Weather
                .FromSqlRaw("EXEC CarterProctorSPs @parkName",
                            new SqlParameter("@parkName", parkName))
                .AsEnumerable()
                .FirstOrDefault();

            return ParkWeather;
        }

        public async Task<Weather> GetWeatherByLocation(int locationID)
        {
            var WeatherLocation =  _dbContextClass.Weather
                .FromSqlRaw("EXEC CarterProctorSP2 @locationID",
                            new SqlParameter("@locationID", locationID))
                .AsEnumerable() 
                .FirstOrDefault();

            return WeatherLocation;
        }
    }
}

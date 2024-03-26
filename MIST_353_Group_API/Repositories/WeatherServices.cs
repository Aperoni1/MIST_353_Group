using MIST_353_Group_API.Data;
using MIST_353_Group_API.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace MIST_353_Group_API.Repositories
{
    public class WeatherServices : IWeatherServices
    {
        private readonly DbContextClass _dbcontextClass;
        public WeatherServices(DbContextClass dbcontextClass) 
        {
            _dbcontextClass = dbcontextClass;
        }

        public async Task<List<Weather>> GetWeatherDetails()
        {
            await Task.Delay(1000);

            return new List<Weather>();

        }


    }
}

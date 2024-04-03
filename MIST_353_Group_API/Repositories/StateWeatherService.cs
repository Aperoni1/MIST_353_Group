using MIST_353_Group_API.Entities;
using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Data.SqlClient;

namespace MIST_353_Group_API.Repositories
{
    public class StateWeatherService : IStateWeatherService
    {
        private readonly DbContextClass _dbContextClass;

        public StateWeatherService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<Weather> GetWeatherByState(string State)
        {
            var stateWeather = await _dbContextClass.Weather
                .FromSqlInterpolated($"EXEC spGetWeatherByState {State}")
                .ToListAsync();

            var result = stateWeather.AsEnumerable().FirstOrDefault();
            
            
            return result;
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using MIST_353_Group_API.Entities;


namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        Task<Weather> GetWeatherByParkName(string parkName); // Weather by Park Name SP

        Task<Weather> GetWeatherByLocation(int locationId); // Weather by Location ID SP
    }
}


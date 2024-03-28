using System.Collections.Generic;
using System.Threading.Tasks;
using MIST_353_Group_API.Entities;


namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        Task<string> GetParkName(int locationId); // Park Name by Location ID SP

        Task<Weather> GetWeatherByLocation(int locationId); // Weather by Location ID SP
    }
}


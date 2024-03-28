using System.Collections.Generic;
using System.Threading.Tasks;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        Task<string> GetParkStatus(int locationId); // Park Status SP
        Task<Weather> GetWeatherByLocation(int locationId); // Weather by Location ID SP
    }
}



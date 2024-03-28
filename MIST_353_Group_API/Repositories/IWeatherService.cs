using System.Collections.Generic;
using System.Threading.Tasks;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        Task<string> GetWeatherStatusByLocation(int locationId); // Weather Status by LocationID SP
        Task<string> GetParkStatus(int locationId); // Park Status SP
    }
}


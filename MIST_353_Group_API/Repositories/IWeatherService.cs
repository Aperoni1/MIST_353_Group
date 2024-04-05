using System.Threading.Tasks;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        Task<Weather> GetWeatherByParkName(string parkName);
        Task<Weather> GetWeatherByLocation(int locationId);
    }
}

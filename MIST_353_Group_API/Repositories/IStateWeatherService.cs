using System.Collections.Generic;
using System.Threading.Tasks;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IStateWeatherService
    {
        public Task<Weather> GetWeatherByState(string State); 
    }
}

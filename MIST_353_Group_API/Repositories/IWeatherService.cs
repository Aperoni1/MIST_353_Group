using System.Collections.Generic;
using System.Threading.Tasks;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IWeatherService
    {
        Task<string> CarterProctorSP2(int LocationID); // Weather Status by LocationID SP
        Task<string> CarterProctorSPs(int LocationID); // Park Status SP
    }
}

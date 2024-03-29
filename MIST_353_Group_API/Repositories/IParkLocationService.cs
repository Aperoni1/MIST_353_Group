using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Data.SqlClient;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Repositories
{
    public interface IParkLocationService
    {
        public Task<Location> GetNearestPark(int inputLat, int inputLon);



    }
}

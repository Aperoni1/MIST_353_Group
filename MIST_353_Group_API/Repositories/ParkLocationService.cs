using MIST_353_Group_API.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;
using Microsoft.AspNetCore.Components.Forms;

namespace MIST_353_Group_API.Repositories
{
    public class ParkLocationService : IParkLocationService
    {
        private readonly DbContextClass _dbContextClass;
        public ParkLocationService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<Location> GetNearestPark(int inputLat, int inputLon)
        {
            var param = new SqlParameter("@inputLat", inputLat);
            var param2 = new SqlParameter("@inputLon", inputLon);
            var parkResult = await Task.Run(() => _dbContextClass.Location.FromSqlRaw("exec spGetNearestPark @inputLat, @inputLon", param, param2).FirstOrDefaultAsync());
            return parkResult;
        }
    }
}

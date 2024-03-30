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
        public async Task<Location> GetNearestPark(string inputLat, string inputLon)
        {

            var locations = _dbContextClass.Location
                                            .FromSqlRaw("EXEC spGetNearestPark @inputLat, @inputLon",
                                                        new SqlParameter("@inputLat", inputLat),
                                                        new SqlParameter("@inputLon", inputLon))
                                            .AsEnumerable(); 
            var parkResult = locations.FirstOrDefault();

            return parkResult;
        }

    }
}

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MIST_353_Group_API.Repositories
{
    public class ParkStatusService : IParkStatusService
    {
        private readonly DbContextClass _dbContextClass;

        public ParkStatusService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<string> GetParkStatus(string parkName)
        {
            var connection = _dbContextClass.Database.GetDbConnection();
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandText = "CarterProctorSP3";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ParkName", parkName));

            var result = await command.ExecuteScalarAsync();

            return result.ToString();
        }
    }
}

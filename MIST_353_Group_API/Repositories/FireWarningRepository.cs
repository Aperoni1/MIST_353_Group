using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MIST_353_Group_API.Data;
using MIST_353_Group_API.Entities;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MIST_353_Group_API.Repositories
{
    public class FireWarningRepository : IFireWarningRepository
    {
        private readonly DbContextClass _dbContextClass;

        public FireWarningRepository(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task CreateFireWarning(FireWarning fireWarning)
        {
            var connectionString = _dbContextClass.Database.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AlexPeroniSPs", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TimeLastUpdated", fireWarning.TimeLastUpdated);
                command.Parameters.AddWithValue("@TimeFirstReported", fireWarning.TimeFirstReported);
                command.Parameters.AddWithValue("@Status", fireWarning.Status);
                command.Parameters.AddWithValue("@LocationID", fireWarning.LocationID);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<IEnumerable<FireWarning>> GetFireWarnings()
        {
            var connectionString = _dbContextClass.Database.GetConnectionString();
            var fireWarnings = new List<FireWarning>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AlexPeroniSP2", connection);
                command.CommandType = CommandType.StoredProcedure;

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var fireWarning = new FireWarning
                        {
                            FireWarningID = reader.GetInt32(0),
                            TimeLastUpdated = reader.GetDateTime(1),
                            TimeFirstReported = reader.GetDateTime(2),
                            Status = reader.GetString(3),
                            LocationID = reader.GetInt32(4)
                        };

                        fireWarnings.Add(fireWarning);
                    }
                }
            }

            return fireWarnings;
        }

        public async Task<FireWarning> GetFireWarningById(int id)
        {
            var connectionString = _dbContextClass.Database.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("YourSPNameHere", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", id);

                await connection.OpenAsync();

                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new FireWarning
                        {
                            FireWarningID = reader.GetInt32(0),
                            TimeLastUpdated = reader.GetDateTime(1),
                            TimeFirstReported = reader.GetDateTime(2),
                            Status = reader.GetString(3),
                            LocationID = reader.GetInt32(4)
                        };
                    }
                }
            }

            return null; // Return null if the fire warning with the given id is not found
        }
    }
}

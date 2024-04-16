using MIST_353_Group_API.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MIST_353_Group_API.Repositories
{
    public interface IFireWarningRepository
    {
        Task CreateFireWarning(FireWarning fireWarning);
        Task<IEnumerable<FireWarning>> GetFireWarnings();
        Task<FireWarning> GetFireWarningById(int id);
    }
}

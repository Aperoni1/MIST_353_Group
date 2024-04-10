using System.Threading.Tasks;

namespace MIST_353_Group_API.Repositories
{
    public interface IParkStatusService
    {
        Task<string> GetParkStatus(string parkName);
    }
}

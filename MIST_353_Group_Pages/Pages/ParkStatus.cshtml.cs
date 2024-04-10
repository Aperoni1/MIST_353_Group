using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Repositories;
using System.Threading.Tasks;

namespace MIST_353_Group_Pages.Pages
{
    public class ParkStatusModel : PageModel
    {
        private readonly IParkStatusService _parkStatusService;

        public ParkStatusModel(IParkStatusService parkStatusService)
        {
            _parkStatusService = parkStatusService;
        }

        [BindProperty]
        public string ParkName { get; set; }

        public string Status { get; set; }

        public async Task<IActionResult> OnGetAsync(string parkName)
        {
            if (!string.IsNullOrEmpty(parkName))
            {
                Status = await _parkStatusService.GetParkStatus(parkName);
            }

            return Page();
        }
    }
}

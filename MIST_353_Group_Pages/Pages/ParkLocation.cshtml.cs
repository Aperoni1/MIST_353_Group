using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Repositories;

namespace MIST_353_Group_Pages.Pages
{
    public class ParkLocationModel : PageModel
    {
        public readonly IParkLocationService _ParkLocationService;

        public ParkLocationModel(IParkLocationService ParkLocationService)
        {
            _ParkLocationService = ParkLocationService;
        }
        public async Task<IActionResult> OnGet(string inputLon, string inputLat)
        {
            if (string.IsNullOrEmpty(inputLon) || string.IsNullOrEmpty(inputLat))
            {
                return Page();
            }
            var parkLocation = await _ParkLocationService.GetNearestPark(inputLat, inputLon);

            if (parkLocation == null)
            {
                return Page();
            }
            ViewData["ParkLocation"] = parkLocation;
            return Page();
        }
    }
}

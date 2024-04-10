using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_Pages.Pages
{
    public class AddFireWarningModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public AddFireWarningModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [BindProperty]
        public FireWarning NewFireWarning { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var response = await _httpClient.PostAsJsonAsync("api/firewarning", NewFireWarning);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("/ViewFireWarnings"); // Redirect to the view page after successful addition
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Failed to add the fire warning. Please try again.");
                return Page();
            }
        }
    }
}

using System;
using System.Net.Http;
using System.Threading.Tasks;
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

            try
            {
                // Post the new fire warning to the API
                var response = await _httpClient.PostAsJsonAsync("api/firewarning", NewFireWarning);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                // Redirect to the view page after successful addition
                return RedirectToPage("/ViewFireWarnings");
            }
            catch (HttpRequestException)
            {
                // If an exception occurs, add an error message to the model state
                ModelState.AddModelError(string.Empty, "Failed to add the fire warning. Please try again.");
                return Page();
            }
        }
    }
}

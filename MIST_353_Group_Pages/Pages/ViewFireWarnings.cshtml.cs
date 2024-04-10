using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_Pages.Pages
{
    public class ViewFireWarningsModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ViewFireWarningsModel(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IList<FireWarning> SearchResults { get; set; }

        public async Task OnGetAsync(int? locationId, int? weatherId, DateTime? timeLastUpdated, DateTime? timeFirstReported, string status)
        {
            var httpClient = _httpClientFactory.CreateClient();

            var apiUrl = $"https://localhost:7183/api/FireWarning?locationId={locationId}&weatherId={weatherId}&timeLastUpdated={timeLastUpdated}&timeFirstReported={timeFirstReported}&status={status}";

            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                SearchResults = await response.Content.ReadFromJsonAsync<List<FireWarning>>();
            }
            else
            {
                SearchResults = new List<FireWarning>();
            }
        }
    }
}


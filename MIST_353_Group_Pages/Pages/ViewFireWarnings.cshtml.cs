using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Entities;
using MIST_353_Group_API.Repositories;

namespace MIST_353_Group_Pages.Pages
{
    public class ViewFireWarningsModel : PageModel
    {
        private readonly IFireWarningRepository _fireWarningRepository;

        public ViewFireWarningsModel(IFireWarningRepository fireWarningRepository)
        {
            _fireWarningRepository = fireWarningRepository;
        }

        public IList<FireWarning> SearchResults { get; set; }

        public async Task OnGetAsync()
        {
            // Call the GetFireWarnings method from the repository
            var fireWarnings = await _fireWarningRepository.GetFireWarnings();

            // Explicitly convert the result to IList<FireWarning>
            SearchResults = new List<FireWarning>(fireWarnings);
        }
    }
}

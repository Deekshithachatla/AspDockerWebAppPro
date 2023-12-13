using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspDockerWebAppPro.Pages
{
    public class ViewModel : PageModel
    {
        // Replace these properties with your actual account data model
        public int AccountId { get; set; }
        public string AccountName { get; set; }

        // Simulated data - replace with logic to retrieve account info
        public void OnGet()
        {
            // Simulated account data
            AccountId = 12345;
            AccountName = "Example Account";
            // Retrieve account details or perform necessary logic here
        }

    }
}


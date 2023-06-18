using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppServiceWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string GreetMessage { get; private init; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            //GreetMessage = configuration.GetValue<string?>("GreetMessage") ?? "wtf";
            GreetMessage = configuration["GreetMessage"] ?? "wtff";

        }

        public void OnGet()
        {

        }
    }
}
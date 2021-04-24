using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace MultiContainerDocker.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _apiClientt;
        public string WeatherData { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpFactory)
        {
            _logger = logger;
            _apiClientt = httpFactory.CreateClient("apiContainer");
        }

        public async Task OnGet()
        {
            WeatherData = await _apiClientt.GetStringAsync("WeatherForecast");          
            
        }

    }
}

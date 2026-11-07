using Microsoft.Extensions.Options;

namespace ValidateOptionDemo
{
    public class DemoClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly IOptions<DomainSiteDemo> _options;
        public DemoClient(IOptions<DomainSiteDemo> options)
        {
            _options = options;
        }

        public void Log()
        {
            Console.WriteLine(_options.Value.SiteUrl);
        }
    }
}

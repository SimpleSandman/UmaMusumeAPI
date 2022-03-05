using System.Net.Http;

using Microsoft.AspNetCore.Mvc.Testing;

using Xunit;

namespace UmaMusumeAPI.Test.Fixtures
{
    [Trait("Category", "Integration")]
    public abstract class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _client;

        public IntegrationTest(WebApplicationFactory<Startup> application)
        {
            _client = application.CreateClient();
        }
    }
}

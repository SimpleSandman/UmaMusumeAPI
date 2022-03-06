using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.Test.Utils;

using Xunit;

namespace UmaMusumeAPI.Test.Fixtures
{
    public abstract class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _client;

        public IntegrationTest(WebApplicationFactory<Startup> api)
        {
            _client = api.CreateClient();
        }

        /// <summary>
        /// Get the deserialized response from the API request
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint">The actual request for API testing which is already prefixed with the <see cref="string"/>, /api/</param>
        /// <param name="hasSingleReturn">Will the returning object contain a list of objects?</param>
        /// <returns></returns>
        protected async Task<object?> ReturnResponseAsync<T>(string endpoint, bool hasSingleReturn)
        {
            return hasSingleReturn
                ? await _client.GetAndDeserialize<T>(endpoint)
                : await _client.GetAndDeserialize<IEnumerable<T>>(endpoint);
        }
    }
}

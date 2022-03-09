using System.Collections.Generic;
using System.Linq;
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
        /// <param name="endpointUrl">The actual request for API testing which is already prefixed with the <see cref="string"/>, /api/</param>
        /// <param name="hasSingleReturn">Will the returning object contain a list of objects?</param>
        /// <returns></returns>
        protected async Task<object?> ReturnResponseAsync<T>(string endpointUrl, bool hasSingleReturn)
        {
            return hasSingleReturn
                ? await _client.GetAndDeserialize<T>(endpointUrl)
                : await _client.GetAndDeserialize<IEnumerable<T>>(endpointUrl);
        }

        /// <summary>
        /// Check the API response for the expected outcome
        /// </summary>
        /// <param name="response">The API response in question</param>
        /// <param name="hasSingleReturn">Validate non-enumerable objects</param>
        /// <param name="knownEmptyTable">Check if response is empty as expected</param>
        protected static void ValidateResponse<T>(object? response, bool hasSingleReturn, bool knownEmptyTable = false)
        {
            if (response == null)
            {
                return; // don't assert anything
            }

            if (hasSingleReturn)
            {
                T singleResponse = (T)response;
                Assert.NotNull(singleResponse);
            }
            else
            {
                IEnumerable<T> listResponse = (IEnumerable<T>)response;
                if (knownEmptyTable)
                {
                    Assert.True(!listResponse.Any());
                }
                else
                {
                    Assert.True(listResponse.Any());
                }
            }
        }
    }
}

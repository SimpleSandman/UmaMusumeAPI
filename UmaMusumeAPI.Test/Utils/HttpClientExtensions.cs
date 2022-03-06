using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace UmaMusumeAPI.Test.Utils
{
    public static class HttpClientExtensions
    {
        /// <summary>
        /// Using a GET request, deserialize the response into a given type and return it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client">HTTP client to make requests</param>
        /// <param name="requestUri">The actual request for API testing which is already prefixed with the <see cref="string"/>, /api/</param>
        /// <returns></returns>
        public static async Task<T?> GetAndDeserialize<T>(this HttpClient client, string requestUri)
        {
            return await client.GetFromJsonAsync<T>($"/api/{requestUri}");
        }
    }
}

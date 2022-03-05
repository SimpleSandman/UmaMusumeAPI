using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace UmaMusumeAPI.Test.Utils
{
    public static class HttpClientExtensions
    {
        public static async Task<T> GetAndDeserialize<T>(this HttpClient client, string requestUri)
        {
            return await client.GetFromJsonAsync<T>(requestUri);
        }
    }
}

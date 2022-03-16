using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.Models.Views;

using UmaMusumeAPI.Test.Fixtures;

using Xunit;

namespace UmaMusumeAPI.Test
{
    /// <summary>
    /// Test every view from the API
    /// </summary>
    public class ViewTests : IntegrationTest
    {
        public ViewTests(WebApplicationFactory<Startup> api) : base(api) { }

        #region GET Tests
        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicCardDataInfo", false)]
        [InlineData("BasicCardDataInfo/100101", true)]
        public async Task GetBasicCardDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<BasicCardDataInfo>(endpointUrl, hasSingleReturn);
        }
        #endregion
    }
}

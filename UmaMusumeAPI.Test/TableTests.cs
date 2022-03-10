using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.Models.Tables;

using UmaMusumeAPI.Test.Fixtures;

using Xunit;

namespace UmaMusumeAPI.Test
{
    /// <summary>
    /// Test every actual database table from the API
    /// </summary>
    public class TableTests : IntegrationTest
    {
        public TableTests(WebApplicationFactory<Startup> api) : base(api) { }

        #region GET Tests
        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceCharacter", false)]
        [InlineData("AnnounceCharacter/101", true)]
        public async Task GetAnnounceCharacter(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AnnounceCharacter>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceData", false)]
        [InlineData("AnnounceData/30004", true)]
        public async Task GetAnnounceData(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AnnounceData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceEvent", false)]
        [InlineData("AnnounceEvent/1", true)]
        public async Task GetAnnounceEvent(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AnnounceEvent>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceSupportCard", false)]
        [InlineData("AnnounceSupportCard/501", true)]
        public async Task GetAnnounceSupportCard(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AnnounceSupportCard>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceData", false)]
        [InlineData("AudienceData/1", true)]
        public async Task GetAudienceData(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AudienceData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceDressColorSet", false)]
        [InlineData("AudienceDressColorSet/1", true)]
        public async Task GetAudienceDressColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AudienceDressColorSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceHairColorSet", false)]
        [InlineData("AudienceHairColorSet/1", true)]
        public async Task GetAudienceHairColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AudienceHairColorSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceImpostor", false)]
        [InlineData("AudienceImpostor/110", false)]
        public async Task GetAudienceImpostor(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AudienceImpostor>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceImpostorColorSet", false)]
        [InlineData("AudienceImpostorColorSet/1", false)]
        public async Task GetAudienceImpostorColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestEndpointAsync<AudienceImpostorColorSet>(endpointUrl, hasSingleReturn, true);
        }
        #endregion
    }
}

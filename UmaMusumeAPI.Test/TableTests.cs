using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.Models.Tables;

using UmaMusumeAPI.Test.Fixtures;

using Xunit;

namespace UmaMusumeAPI.Test
{
    /// <summary>
    /// Testing every actual database table from the API
    /// </summary>
    public class TableTests : IntegrationTest
    {
        public TableTests(WebApplicationFactory<Startup> api) : base(api) { }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceCharacter", false)]
        [InlineData("AnnounceCharacter/101", true)]
        public async Task GetAnnounceCharacter(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AnnounceCharacter>(endpointUrl, hasSingleReturn);
            ValidateResponse<AnnounceCharacter>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceData", false)]
        [InlineData("AnnounceData/30004", true)]
        public async Task GetAnnounceData(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AnnounceData>(endpointUrl, hasSingleReturn);
            ValidateResponse<AnnounceData>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceEvent", false)]
        [InlineData("AnnounceEvent/1", true)]
        public async Task GetAnnounceEvent(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AnnounceEvent>(endpointUrl, hasSingleReturn);
            ValidateResponse<AnnounceEvent>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceSupportCard", false)]
        [InlineData("AnnounceSupportCard/501", true)]
        public async Task GetAnnounceSupportCard(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AnnounceSupportCard>(endpointUrl, hasSingleReturn);
            ValidateResponse<AnnounceSupportCard>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceData", false)]
        [InlineData("AudienceData/1", true)]
        public async Task GetAudienceData(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AudienceData>(endpointUrl, hasSingleReturn);
            ValidateResponse<AudienceData>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceDressColorSet", false)]
        [InlineData("AudienceDressColorSet/1", true)]
        public async Task GetAudienceDressColorSet(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AudienceDressColorSet>(endpointUrl, hasSingleReturn);
            ValidateResponse<AudienceDressColorSet>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceHairColorSet", false)]
        [InlineData("AudienceHairColorSet/1", true)]
        public async Task GetAudienceHairColorSet(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AudienceHairColorSet>(endpointUrl, hasSingleReturn);
            ValidateResponse<AudienceHairColorSet>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceImpostor", false)]
        [InlineData("AudienceImpostor/110", false)]
        public async Task GetAudienceImpostor(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AudienceImpostor>(endpointUrl, hasSingleReturn);
            ValidateResponse<AudienceImpostor>(response, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceImpostorColorSet", false)]
        [InlineData("AudienceImpostorColorSet/1", false)]
        public async Task GetAudienceImpostorColorSet(string endpointUrl, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AudienceImpostorColorSet>(endpointUrl, hasSingleReturn);
            ValidateResponse<AudienceImpostorColorSet>(response, hasSingleReturn, true);
        }
    }
}

using System.Threading.Tasks;

using FluentAssertions;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.Models.Tables;
using UmaMusumeAPI.Test.Fixtures;

using Xunit;

namespace UmaMusumeAPI.Test
{
    public class TableTests : IntegrationTest
    {
        public TableTests(WebApplicationFactory<Startup> api) : base(api) { }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceCharacter", false)]
        [InlineData("AnnounceCharacter/101", true)]
        public async Task GetAnnounceCharacter(string endpoint, bool hasSingleReturn)
        {
            object? response = await ReturnResponseAsync<AnnounceCharacter>(endpoint, hasSingleReturn);
            response.Should().NotBeNull();
        }
    }
}

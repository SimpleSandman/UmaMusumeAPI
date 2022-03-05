using System.Collections.Generic;
using System.Threading.Tasks;

using FluentAssertions;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.Models.Tables;

using UmaMusumeAPI.Test.Fixtures;
using UmaMusumeAPI.Test.Utils;

using Xunit;

namespace UmaMusumeAPI.Test
{
    public class UnitTests : IntegrationTest
    {
        public UnitTests(WebApplicationFactory<Startup> application)
            : base(application) { }

        [Fact]
        public async Task GetAnnounceCharacters()
        {
            var response = await _client.GetAndDeserialize<List<AnnounceCharacter>>($"/api/AnnounceCharacter");
            response.Should().NotBeNull();
        }
    }
}

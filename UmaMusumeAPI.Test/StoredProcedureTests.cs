using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.DTO;
using UmaMusumeAPI.Models.StoredProcedures;

using UmaMusumeAPI.Test.Fixtures;

using Xunit;

namespace UmaMusumeAPI.Test
{
    /// <summary>
    /// Test every stored procedure from the API
    /// </summary>
    public class StoredProcedureTests : IntegrationTest
    {
        public StoredProcedureTests(WebApplicationFactory<Startup> api) : base(api) { }

        #region GET Tests
        [Theory]
        [Trait("EndpointType", "StoredProc")]
        [InlineData("SpSuccessionGrandparentRecommendation/1008/1011", false)]
        public async Task GetSpSuccessionGrandparentRecommendation(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SpSuccessionGrandparentRecommendation>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "StoredProc")]
        [InlineData("SpSuccessionParentRecommendation/1008", false)]
        public async Task GetSpSuccessionParentRecommendation(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SpSuccessionParentRecommendation>(endpointUrl, hasSingleReturn);
        }
        #endregion

        #region POST Test
        [Theory]
        [Trait("EndpointType", "StoredProc")]
        [InlineData(1008, 1011, 1008, 1009, 1014, 1009, 1011)]
        public async Task PostSpSuccessionPointSum(int child, 
            int parent1, int grandparent1A, int grandparent1B,
            int parent2, int grandparent2A, int grandparent2B)
        {
            string endpointUrl = "SpSuccessionPointSum";
            SpSuccessionPointSumDTO requestBody = new SpSuccessionPointSumDTO
            { 
                Child = child,
                Parent1 = parent1,
                Grandparent1A = grandparent1A,
                Grandparent1B = grandparent1B,
                Parent2 = parent2,
                Grandparent2A = grandparent2A,
                Grandparent2B = grandparent2B
            };

            await TestPostEndpointAsync<SpSuccessionPointSum, SpSuccessionPointSumDTO>(endpointUrl, true, requestBody);
        }
        #endregion
    }
}

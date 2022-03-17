using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Testing;

using UmaMusumeAPI.DTO;
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
            await TestGetEndpointAsync<BasicCardDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicCharaDataInfo", false)]
        [InlineData("BasicCharaDataInfo/1001", false)]
        public async Task GetBasicCharaDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicCharaDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicDressDataInfo", false)]
        [InlineData("BasicDressDataInfo/1", true)]
        public async Task GetBasicDressDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicDressDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicGachaDataInfo", false)]
        [InlineData("BasicGachaDataInfo/30002", true)]
        public async Task GetBasicGachaDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicGachaDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicGiftMessageInfo", false)]
        [InlineData("BasicGiftMessageInfo/6", false)]
        public async Task GetBasicGiftMessageInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicGiftMessageInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicItemDataInfo", false)]
        [InlineData("BasicItemDataInfo/1", true)]
        public async Task GetBasicItemDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicItemDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicItemExchangeInfo", false)]
        [InlineData("BasicItemExchangeInfo/27", true)]
        public async Task GetBasicItemExchangeInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicItemExchangeInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicItemExchangeTopInfo", false)]
        [InlineData("BasicItemExchangeTopInfo/2000", true)]
        public async Task GetBasicItemExchangeTopInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicItemExchangeTopInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicLiveDataInfo", false)]
        [InlineData("BasicLiveDataInfo/1001", true)]
        public async Task GetBasicLiveDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicLiveDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicLoginBonusDataInfo", false)]
        [InlineData("BasicLoginBonusDataInfo/10001", true)]
        public async Task GetBasicLoginBonusDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicLoginBonusDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicMainStoryDataInfo", false)]
        [InlineData("BasicMainStoryDataInfo/101", true)]
        public async Task GetBasicMainStoryDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicMainStoryDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicMissionDataInfo", false)]
        [InlineData("BasicMissionDataInfo/100000", false)]
        public async Task GetBasicMissionDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicMissionDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicMobDataInfo", false)]
        [InlineData("BasicMobDataInfo/8008", true)]
        public async Task GetBasicMobDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicMobDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicPieceDataInfo", false)]
        [InlineData("BasicPieceDataInfo/100000", true)]
        public async Task GetBasicPieceDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicPieceDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicRaceInfo", false)]
        [InlineData("BasicRaceInfo/1001", true)]
        public async Task GetBasicRaceInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicRaceInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicRaceInstanceInfo", false)]
        [InlineData("BasicRaceInstanceInfo/100101", true)]
        public async Task GetBasicRaceInstanceInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicRaceInstanceInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicRaceTrackInfo", false)]
        [InlineData("BasicRaceTrackInfo/10001", true)]
        public async Task GetBasicRaceTrackInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicRaceTrackInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicSingleModeCharaGradeInfo", false)]
        [InlineData("BasicSingleModeCharaGradeInfo/1", true)]
        public async Task GetBasicSingleModeCharaGradeInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicSingleModeCharaGradeInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicSkillDataInfo", false)]
        [InlineData("BasicSkillDataInfo/10071", false)]
        public async Task GetBasicSkillDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicSkillDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicStoryEventDataInfo", false)]
        [InlineData("BasicStoryEventDataInfo/1001", true)]
        public async Task GetBasicStoryEventDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicStoryEventDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicStoryEventMissionInfo", false)]
        [InlineData("BasicStoryEventMissionInfo/1", false)]
        public async Task GetBasicStoryEventMissionInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicStoryEventMissionInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicStoryEventStoryDataInfo", false)]
        [InlineData("BasicStoryEventStoryDataInfo/1", true)]
        public async Task GetBasicStoryEventStoryDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicStoryEventStoryDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicSupportCardDataInfo", false)]
        [InlineData("BasicSupportCardDataInfo/10001", true)]
        public async Task GetBasicSupportCardDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicSupportCardDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicSupportCardUniqueEffectInfo", false)]
        [InlineData("BasicSupportCardUniqueEffectInfo/20001", true)]
        public async Task GetBasicSupportCardUniqueEffectInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicSupportCardUniqueEffectInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicTeamStadiumScoreBonusInfo", false)]
        [InlineData("BasicTeamStadiumScoreBonusInfo/1", true)]
        public async Task GetBasicTeamStadiumScoreBonusInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicTeamStadiumScoreBonusInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("BasicTextDataEnglish", false)]
        [InlineData("BasicTextDataEnglish/1", false)]
        [InlineData("BasicTextDataEnglish/1/101", false)]
        public async Task GetBasicTextDataEnglish(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BasicTextDataEnglish>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Condensed")]
        [InlineData("CondensedSkillDataInfo", false)]
        [InlineData("CondensedSkillDataInfo/10071", true)]
        public async Task GetCondensedSkillDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CondensedSkillDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceCardDataInfo", false)]
        [InlineData("NiceCardDataInfo/100101", true)]
        public async Task GetNiceCardDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceCardDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceCharaBioInfo", false)]
        [InlineData("NiceCharaBioInfo/1001", true)]
        public async Task GetNiceCharaBioInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceCharaBioInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceErrorMessage", false)]
        [InlineData("NiceErrorMessage/1", false)]
        public async Task GetNiceErrorMessage(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceErrorMessage>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceItemNamesCommentsInfo", false)]
        [InlineData("NiceItemNamesCommentsInfo/1", true)]
        public async Task GetNiceItemNamesCommentsInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceItemNamesCommentsInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceObjectivesInfo", false)]
        [InlineData("NiceObjectivesInfo/1", true)]
        public async Task GetNiceObjectivesInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceObjectivesInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceRaceInfo", false)]
        [InlineData("NiceRaceInfo/1001", true)]
        public async Task GetNiceRaceInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceRaceInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceSkillDataInfo", false)]
        [InlineData("NiceSkillDataInfo/200162", false)]
        public async Task GetNiceSkillDataInfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceSkillDataInfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceSuccessionRelationMemberType", false)]
        [InlineData("NiceSuccessionRelationMemberType/1", true)]
        public async Task GetNiceSuccessionRelationMemberType(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceSuccessionRelationMemberType>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Nice")]
        [InlineData("NiceTutorialMessage", false)]
        [InlineData("NiceTutorialMessage/3", false)]
        public async Task GetNiceTutorialMessage(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NiceTutorialMessage>(endpointUrl, hasSingleReturn);
        }
        #endregion

        #region POST Test
        [Theory]
        [Trait("EndpointType", "Basic")]
        [InlineData("Special Week", true)]
        [InlineData("スペシャルウィーク", false)]
        public async Task PostBasicTextDataEnglish(string searchQuery, bool isEnglishQuery)
        {
            string endpointUrl = "BasicTextDataEnglish";
            BasicTextEnglishDTO englishRequestBody = new BasicTextEnglishDTO 
            { 
                SearchQuery = searchQuery, 
                IsEnglishQuery = isEnglishQuery
            };

            await TestPostEndpointAsync<BasicTextDataEnglish, BasicTextEnglishDTO>(endpointUrl, false, englishRequestBody);
        }
        #endregion
    }
}

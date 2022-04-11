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
            await TestGetEndpointAsync<AnnounceCharacter>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceData", false)]
        [InlineData("AnnounceData/30004", true)]
        public async Task GetAnnounceData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AnnounceData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceEvent", false)]
        [InlineData("AnnounceEvent/1", true)]
        public async Task GetAnnounceEvent(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AnnounceEvent>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AnnounceSupportCard", false)]
        [InlineData("AnnounceSupportCard/501", true)]
        public async Task GetAnnounceSupportCard(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AnnounceSupportCard>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceData", false)]
        [InlineData("AudienceData/1", true)]
        public async Task GetAudienceData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudienceData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceDressColorSet", false)]
        [InlineData("AudienceDressColorSet/1", true)]
        public async Task GetAudienceDressColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudienceDressColorSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceHairColorSet", false)]
        [InlineData("AudienceHairColorSet/1", true)]
        public async Task GetAudienceHairColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudienceHairColorSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceImpostor", false)]
        [InlineData("AudienceImpostor/110", false)]
        public async Task GetAudienceImpostor(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudienceImpostor>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceImpostorColorSet", false)]
        [InlineData("AudienceImpostorColorSet/1", false)]
        public async Task GetAudienceImpostorColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudienceImpostorColorSet>(endpointUrl, hasSingleReturn, true);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudienceImpostorLottery", false)]
        [InlineData("AudienceImpostorLottery/100", false)]
        public async Task GetAudienceImpostorLottery(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudienceImpostorLottery>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudioCuesheet", false)]
        [InlineData("AudioCuesheet/1", true)]
        public async Task GetAudioCuesheet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudioCuesheet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudioIgnoredCueOnHighspeed", false)]
        [InlineData("AudioIgnoredCueOnHighspeed/1", true)]
        public async Task GetAudioIgnoredCueOnHighspeed(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudioIgnoredCueOnHighspeed>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AudioStoryEffect", false)]
        [InlineData("AudioStoryEffect/1", true)]
        public async Task GetAudioStoryEffect(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AudioStoryEffect>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("AvailableSkillSet", false)]
        [InlineData("AvailableSkillSet/1", true)]
        public async Task GetAvailableSkillSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<AvailableSkillSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("BackgroundData", false)]
        [InlineData("BackgroundData/1", true)]
        public async Task GetBackgroundData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BackgroundData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("BackgroundOffsetData", false)]
        [InlineData("BackgroundOffsetData/1", true)]
        public async Task GetBackgroundOffsetData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BackgroundOffsetData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("BannerData", false)]
        [InlineData("BannerData/1", true)]
        public async Task GetBannerData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<BannerData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CampaignCharaStorySchedule", false)]
        [InlineData("CampaignCharaStorySchedule/6", false)]
        public async Task GetCampaignCharaStorySchedule(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CampaignCharaStorySchedule>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CampaignData", false)]
        [InlineData("CampaignData/1", true)]
        public async Task GetCampaignData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CampaignData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CampaignPresentBonusDetail", false)]
        [InlineData("CampaignPresentBonusDetail/1", true)]
        public async Task GetCampaignPresentBonusDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CampaignPresentBonusDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CampaignSingleRaceAddData", false)]
        [InlineData("CampaignSingleRaceAddData/1", true)]
        public async Task GetCampaignSingleRaceAddData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CampaignSingleRaceAddData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CampaignSingleRaceAddReward", false)]
        [InlineData("CampaignSingleRaceAddReward/1", true)]
        public async Task GetCampaignSingleRaceAddReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CampaignSingleRaceAddReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CardData", false)]
        [InlineData("CardData/100101", true)]
        public async Task GetCardData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CardData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CardRarityData", false)]
        [InlineData("CardRarityData/10010103", true)]
        public async Task GetCardRarityData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CardRarityData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CardTalentHintUpgrade", false)]
        [InlineData("CardTalentHintUpgrade/1001", true)]
        public async Task GetCardTalentHintUpgrade(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CardTalentHintUpgrade>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CardTalentUpgrade", false)]
        [InlineData("CardTalentUpgrade/1", true)]
        public async Task GetCardTalentUpgrade(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CardTalentUpgrade>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChallengeMatchBossNpc", false)]
        [InlineData("ChallengeMatchBossNpc/1", true)]
        public async Task GetChallengeMatchBossNpc(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChallengeMatchBossNpc>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChallengeMatchData", false)]
        [InlineData("ChallengeMatchData/1", true)]
        public async Task GetChallengeMatchData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChallengeMatchData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChallengeMatchRace", false)]
        [InlineData("ChallengeMatchRace/1", true)]
        public async Task GetChallengeMatchRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChallengeMatchRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChallengeMatchRaceNpc", false)]
        [InlineData("ChallengeMatchRaceNpc/101", true)]
        public async Task GetChallengeMatchRaceNpc(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChallengeMatchRaceNpc>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChallengeMatchRawPoint", false)]
        [InlineData("ChallengeMatchRawPoint/1", true)]
        public async Task GetChallengeMatchRawPoint(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChallengeMatchRawPoint>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChallengeMatchRetryBonus", false)]
        [InlineData("ChallengeMatchRetryBonus/1", true)]
        public async Task GetChallengeMatchRetryBonus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChallengeMatchRetryBonus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsBgm", false)]
        [InlineData("ChampionsBgm/1", true)]
        public async Task GetChampionsBgm(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsBgm>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsEntryReward", false)]
        [InlineData("ChampionsEntryReward/0", false)]
        public async Task GetChampionsEntryReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsEntryReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsEvaluationRate", false)]
        [InlineData("ChampionsEvaluationRate/1", true)]
        public async Task GetChampionsEvaluationRate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsEvaluationRate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsCharaComment", false)]
        [InlineData("ChampionsNewsCharaComment/1", true)]
        public async Task GetChampionsNewsCharaComment(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsCharaComment>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsCharaDetail", false)]
        [InlineData("ChampionsNewsCharaDetail/100", true)]
        public async Task GetChampionsNewsCharaDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsCharaDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsCharaWininfo", false)]
        [InlineData("ChampionsNewsCharaWininfo/1", true)]
        public async Task GetChampionsNewsCharaWininfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsCharaWininfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsRace", false)]
        [InlineData("ChampionsNewsRace/1001", true)]
        public async Task GetChampionsNewsRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsTitle", false)]
        [InlineData("ChampionsNewsTitle/1", true)]
        public async Task GetChampionsNewsTitle(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsTitle>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsTrainerDetail", false)]
        [InlineData("ChampionsNewsTrainerDetail/100", true)]
        public async Task GetChampionsNewsTrainerDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsTrainerDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsTrainerWininfo", false)]
        [InlineData("ChampionsNewsTrainerWininfo/1", true)]
        public async Task GetChampionsNewsTrainerWininfo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsTrainerWininfo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsWinComment", false)]
        [InlineData("ChampionsNewsWinComment/1", true)]
        public async Task GetChampionsNewsWinComment(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsWinComment>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsNewsWinTitle", false)]
        [InlineData("ChampionsNewsWinTitle/1", true)]
        public async Task GetChampionsNewsWinTitle(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsNewsWinTitle>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsRaceCondition", false)]
        [InlineData("ChampionsRaceCondition/1", false)]
        public async Task GetChampionsRaceCondition(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsRaceCondition>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsRewardRate", false)]
        [InlineData("ChampionsRewardRate/1", true)]
        public async Task GetChampionsRewardRate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsRewardRate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsRoundDetail", false)]
        [InlineData("ChampionsRoundDetail/1", true)]
        public async Task GetChampionsRoundDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsRoundDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsRoundSchedule", false)]
        [InlineData("ChampionsRoundSchedule/1", true)]
        public async Task GetChampionsRoundSchedule(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsRoundSchedule>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsSchedule", false)]
        [InlineData("ChampionsSchedule/1", true)]
        public async Task GetChampionsSchedule(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsSchedule>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ChampionsStandMotion", false)]
        [InlineData("ChampionsStandMotion/0", false)]
        public async Task GetChampionsStandMotion(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ChampionsStandMotion>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharaCategoryMotion", false)]
        [InlineData("CharaCategoryMotion/1001", true)]
        public async Task GetCharaCategoryMotion(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharaCategoryMotion>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharacterPropAnimation", false)]
        [InlineData("CharacterPropAnimation/1", true)]
        public async Task GetCharacterPropAnimation(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharacterPropAnimation>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharacterSystemLottery", false)]
        [InlineData("CharacterSystemLottery/1", true)]
        public async Task GetCharacterSystemLottery(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharacterSystemLottery>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharacterSystemText", false)]
        [InlineData("CharacterSystemText/1001", false)]
        public async Task GetCharacterSystemText(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharacterSystemText>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharaData", false)]
        [InlineData("CharaData/1001", true)]
        public async Task GetCharaData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharaData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharaMotionAct", false)]
        [InlineData("CharaMotionAct/1", true)]
        public async Task GetCharaMotionAct(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharaMotionAct>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharaMotionSet", false)]
        [InlineData("CharaMotionSet/1", true)]
        public async Task GetCharaMotionSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharaMotionSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharaStoryData", false)]
        [InlineData("CharaStoryData/1", true)]
        public async Task GetCharaStoryData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharaStoryData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CharaType", false)]
        [InlineData("CharaType/1001", true)]
        public async Task GetCharaType(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CharaType>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CircleRankData", false)]
        [InlineData("CircleRankData/1", true)]
        public async Task GetCircleRankData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CircleRankData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CircleStampData", false)]
        [InlineData("CircleStampData/100001", true)]
        public async Task GetCircleStampData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CircleStampData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGameArmSwing", false)]
        [InlineData("CraneGameArmSwing/1", true)]
        public async Task GetCraneGameArmSwing(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGameArmSwing>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGameCatchResult", false)]
        [InlineData("CraneGameCatchResult/1", false)]
        public async Task GetCraneGameCatchResult(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGameCatchResult>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGameDefineParam", false)]
        [InlineData("CraneGameDefineParam/1", true)]
        public async Task GetCraneGameDefineParam(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGameDefineParam>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGameExtraOddsCondition", false)]
        [InlineData("CraneGameExtraOddsCondition/3", true)]
        public async Task GetCraneGameExtraOddsCondition(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGameExtraOddsCondition>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGameHiddenOdd", false)]
        [InlineData("CraneGameHiddenOdd/1", true)]
        public async Task GetCraneGameHiddenOdd(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGameHiddenOdd>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGamePrizeFace", false)]
        [InlineData("CraneGamePrizeFace/1", true)]
        public async Task GetCraneGamePrizeFace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGamePrizeFace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGamePrizePattern", false)]
        [InlineData("CraneGamePrizePattern/1", true)]
        public async Task GetCraneGamePrizePattern(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGamePrizePattern>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("CraneGameProp", false)]
        [InlineData("CraneGameProp/1", true)]
        public async Task GetCraneGameProp(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<CraneGameProp>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("DailyLegendRace", false)]
        [InlineData("DailyLegendRace/10001", true)]
        public async Task GetDailyLegendRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<DailyLegendRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("DailyPack", false)]
        [InlineData("DailyPack/16", false)]
        public async Task GetDailyPack(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<DailyPack>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("DailyRace", false)]
        [InlineData("DailyRace/1", true)]
        public async Task GetDailyRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<DailyRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("DailyRaceBilling", false)]
        [InlineData("DailyRaceBilling/1", true)]
        public async Task GetDailyRaceBilling(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<DailyRaceBilling>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("DailyRaceNpc", false)]
        [InlineData("DailyRaceNpc/1", true)]
        public async Task GetDailyRaceNpc(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<DailyRaceNpc>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("Directory", false)]
        [InlineData("Directory/1", true)]
        public async Task GetDirectory(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<Directory>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("DressData", false)]
        [InlineData("DressData/1", true)]
        public async Task GetDressData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<DressData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("EventMotionData", false)]
        [InlineData("EventMotionData/1", true)]
        public async Task GetEventMotionData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<EventMotionData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("EventMotionPlusData", false)]
        [InlineData("EventMotionPlusData/1", true)]
        public async Task GetEventMotionPlusData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<EventMotionPlusData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FaceTypeData", false)]
        [InlineData("FaceTypeData/Base", true)]
        public async Task GetFaceTypeData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FaceTypeData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FacialMouthChange", false)]
        [InlineData("FacialMouthChange/1", true)]
        public async Task GetFacialMouthChange(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FacialMouthChange>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidAllReward", false)]
        [InlineData("FanRaidAllReward/1", true)]
        public async Task GetFanRaidAllReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidAllReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidBonusChara", false)]
        [InlineData("FanRaidBonusChara/1", true)]
        public async Task GetFanRaidBonusChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidBonusChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidBonusSupportCard", false)]
        [InlineData("FanRaidBonusSupportCard/1", true)]
        public async Task GetFanRaidBonusSupportCard(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidBonusSupportCard>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidData", false)]
        [InlineData("FanRaidData/1001", true)]
        public async Task GetFanRaidData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidIndividualReward", false)]
        [InlineData("FanRaidIndividualReward/1", true)]
        public async Task GetFanRaidIndividualReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidIndividualReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidStoryData", false)]
        [InlineData("FanRaidStoryData/1", true)]
        public async Task GetFanRaidStoryData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidStoryData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidTopChara", false)]
        [InlineData("FanRaidTopChara/1", true)]
        public async Task GetFanRaidTopChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidTopChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("FanRaidTopData", false)]
        [InlineData("FanRaidTopData/1", true)]
        public async Task GetFanRaidTopData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<FanRaidTopData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaAvailable", false)]
        [InlineData("GachaAvailable/10001", false)]
        public async Task GetGachaAvailable(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaAvailable>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaData", false)]
        [InlineData("GachaData/10001", true)]
        public async Task GetGachaData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaExchange", false)]
        [InlineData("GachaExchange/30002", false)]
        public async Task GetGachaExchange(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaExchange>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaFreeCampaign", false)]
        [InlineData("GachaFreeCampaign/1", true)]
        public async Task GetGachaFreeCampaign(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaFreeCampaign>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaPiece", false)]
        [InlineData("GachaPiece/1", true)]
        public async Task GetGachaPiece(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaPiece>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaPrizeOdd", false)]
        [InlineData("GachaPrizeOdd/1", false)]
        public async Task GetGachaPrizeOdd(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaPrizeOdd>(endpointUrl, hasSingleReturn, true);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaStockCampaign", false)]
        [InlineData("GachaStockCampaign/1", true)]
        public async Task GetGachaStockCampaign(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaStockCampaign>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaStockDetail", false)]
        [InlineData("GachaStockDetail/1", true)]
        public async Task GetGachaStockDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaStockDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GachaTopBg", false)]
        [InlineData("GachaTopBg/1", true)]
        public async Task GetGachaTopBg(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GachaTopBg>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("GiftMessage", false)]
        [InlineData("GiftMessage/6", true)]
        public async Task GetGiftMessage(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<GiftMessage>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HighlightInterpolate", false)]
        [InlineData("HighlightInterpolate/1", true)]
        public async Task GetHighlightInterpolate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HighlightInterpolate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomeCharacterType", false)]
        [InlineData("HomeCharacterType/1", false)]
        public async Task GetHomeCharacterType(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomeCharacterType>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomeEat", false)]
        [InlineData("HomeEat/1001", false)]
        public async Task GetHomeEat(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomeEat>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomeEnvSetting", false)]
        [InlineData("HomeEnvSetting/1", true)]
        public async Task GetHomeEnvSetting(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomeEnvSetting>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomeEventSchedule", false)]
        [InlineData("HomeEventSchedule/1", true)]
        public async Task GetHomeEventSchedule(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomeEventSchedule>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomePosterData", false)]
        [InlineData("HomePosterData/1004", true)]
        public async Task GetHomePosterData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomePosterData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomePropSetting", false)]
        [InlineData("HomePropSetting/1", false)]
        public async Task GetHomePropSetting(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomePropSetting>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomeStoryHipOffset", false)]
        [InlineData("HomeStoryHipOffset/1", false)]
        public async Task GetHomeStoryHipOffset(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomeStoryHipOffset>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomeStoryTrigger", false)]
        [InlineData("HomeStoryTrigger/1", true)]
        public async Task GetHomeStoryTrigger(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomeStoryTrigger>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HomeWalkGroup", false)]
        [InlineData("HomeWalkGroup/1", true)]
        public async Task GetHomeWalkGroup(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HomeWalkGroup>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("HonorData", false)]
        [InlineData("HonorData/100101", true)]
        public async Task GetHonorData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<HonorData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ItemData", false)]
        [InlineData("ItemData/1", true)]
        public async Task GetItemData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ItemData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ItemExchange", false)]
        [InlineData("ItemExchange/2001", true)]
        public async Task GetItemExchange(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ItemExchange>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ItemExchangeTop", false)]
        [InlineData("ItemExchangeTop/2000", true)]
        public async Task GetItemExchangeTop(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ItemExchangeTop>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ItemGroup", false)]
        [InlineData("ItemGroup/1", true)]
        public async Task GetItemGroup(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ItemGroup>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ItemPack", false)]
        [InlineData("ItemPack/1", true)]
        public async Task GetItemPack(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ItemPack>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ItemPlace", false)]
        [InlineData("ItemPlace/1", false)]
        public async Task GetItemPlace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ItemPlace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("JukeboxCharaTagData", false)]
        [InlineData("JukeboxCharaTagData/1", true)]
        public async Task GetJukeboxCharaTagData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<JukeboxCharaTagData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("JukeboxComment", false)]
        [InlineData("JukeboxComment/1", true)]
        public async Task GetJukeboxComment(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<JukeboxComment>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("JukeboxMotionData", false)]
        [InlineData("JukeboxMotionData/1", true)]
        public async Task GetJukeboxMotionData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<JukeboxMotionData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("JukeboxMusicData", false)]
        [InlineData("JukeboxMusicData/1001", true)]
        public async Task GetJukeboxMusicData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<JukeboxMusicData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("JukeboxReactionData", false)]
        [InlineData("JukeboxReactionData/1", true)]
        public async Task GetJukeboxReactionData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<JukeboxReactionData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("JukeboxRequestData", false)]
        [InlineData("JukeboxRequestData/1", true)]
        public async Task GetJukeboxRequestData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<JukeboxRequestData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LegendRace", false)]
        [InlineData("LegendRace/2", true)]
        public async Task GetLegendRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LegendRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LegendRaceBilling", false)]
        [InlineData("LegendRaceBilling/1", true)]
        public async Task GetLegendRaceBilling(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LegendRaceBilling>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LegendRaceBossNpc", false)]
        [InlineData("LegendRaceBossNpc/103", true)]
        public async Task GetLegendRaceBossNpc(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LegendRaceBossNpc>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LegendRaceNpc", false)]
        [InlineData("LegendRaceNpc/101", true)]
        public async Task GetLegendRaceNpc(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LegendRaceNpc>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LimitedExchange", false)]
        [InlineData("LimitedExchange/1", true)]
        public async Task GetLimitedExchange(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LimitedExchange>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LimitedExchangeReward", false)]
        [InlineData("LimitedExchangeReward/1", true)]
        public async Task GetLimitedExchangeReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LimitedExchangeReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LimitedExchangeRewardOdd", false)]
        [InlineData("LimitedExchangeRewardOdd/1", true)]
        public async Task GetLimitedExchangeRewardOdd(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LimitedExchangeRewardOdd>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LiveData", false)]
        [InlineData("LiveData/1001", true)]
        public async Task GetLiveData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LiveData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LiveExtraData", false)]
        //[InlineData("LiveExtraData/1001", true)]
        public async Task GetLiveExtraData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LiveExtraData>(endpointUrl, hasSingleReturn, true);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LivePermissionData", false)]
        [InlineData("LivePermissionData/1004", false)]
        public async Task GetLivePermissionData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LivePermissionData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LoginBonusData", false)]
        [InlineData("LoginBonusData/10001", true)]
        public async Task GetLoginBonusData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LoginBonusData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LoginBonusDetail", false)]
        [InlineData("LoginBonusDetail/1", true)]
        public async Task GetLoginBonusDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LoginBonusDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("LoveRank", false)]
        [InlineData("LoveRank/1", true)]
        public async Task GetLoveRank(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<LoveRank>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MainStoryData", false)]
        [InlineData("MainStoryData/101", true)]
        public async Task GetMainStoryData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MainStoryData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MainStoryPart", false)]
        [InlineData("MainStoryPart/1", true)]
        public async Task GetMainStoryPart(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MainStoryPart>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MainStoryRaceBonus", false)]
        [InlineData("MainStoryRaceBonus/1", true)]
        public async Task GetMainStoryRaceBonus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MainStoryRaceBonus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MainStoryRaceBonusCondition", false)]
        [InlineData("MainStoryRaceBonusCondition/1", true)]
        public async Task GetMainStoryRaceBonusCondition(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MainStoryRaceBonusCondition>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MainStoryRaceCharaData", false)]
        [InlineData("MainStoryRaceCharaData/71", true)]
        public async Task GetMainStoryRaceCharaData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MainStoryRaceCharaData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MainStoryRaceData", false)]
        [InlineData("MainStoryRaceData/1", true)]
        public async Task GetMainStoryRaceData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MainStoryRaceData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MiniBg", false)]
        [InlineData("MiniBg/10001", true)]
        public async Task GetMiniBg(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MiniBg>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MiniBgCharaMotion", false)]
        [InlineData("MiniBgCharaMotion/1000101", true)]
        public async Task GetMiniBgCharaMotion(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MiniBgCharaMotion>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MiniFaceTypeData", false)]
        [InlineData("MiniFaceTypeData/BoobooA", true)]
        public async Task GetMiniFaceTypeData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MiniFaceTypeData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MiniMotionSet", false)]
        [InlineData("MiniMotionSet/Bit01", true)]
        public async Task GetMiniMotionSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MiniMotionSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MiniMouthType", false)]
        [InlineData("MiniMouthType/1", true)]
        public async Task GetMiniMouthType(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MiniMouthType>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MissionData", false)]
        [InlineData("MissionData/100000", true)]
        public async Task GetMissionData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MissionData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MobData", false)]
        [InlineData("MobData/8008", true)]
        public async Task GetMobData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MobData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MobDressColorSet", false)]
        [InlineData("MobDressColorSet/8008", true)]
        public async Task GetMobDressColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MobDressColorSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("MobHairColorSet", false)]
        [InlineData("MobHairColorSet/1", true)]
        public async Task GetMobHairColorSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<MobHairColorSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("NameCardBg", false)]
        [InlineData("NameCardBg/2001", true)]
        public async Task GetNameCardBg(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NameCardBg>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("NeedPieceNumData", false)]
        [InlineData("NeedPieceNumData/1", true)]
        public async Task GetNeedPieceNumData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NeedPieceNumData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("Nickname", false)]
        [InlineData("Nickname/1", true)]
        public async Task GetNickname(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<Nickname>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("NoteProfile", false)]
        [InlineData("NoteProfile/1", true)]
        public async Task GetNoteProfile(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NoteProfile>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("NoteProfileTextType", false)]
        [InlineData("NoteProfileTextType/1", true)]
        public async Task GetNoteProfileTextType(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<NoteProfileTextType>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("PieceData", false)]
        [InlineData("PieceData/100000", true)]
        public async Task GetPieceData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<PieceData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("PriceChange", false)]
        [InlineData("PriceChange/1", true)]
        public async Task GetPriceChange(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<PriceChange>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ProfileCardBg", false)]
        [InlineData("ProfileCardBg/1", true)]
        public async Task GetProfileCardBg(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ProfileCardBg>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("Race", false)]
        [InlineData("Race/1001", true)]
        public async Task GetRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<Race>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceBgm", false)]
        [InlineData("RaceBgm/1", true)]
        public async Task GetRaceBgm(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceBgm>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceBgmCutinExtensionTime", false)]
        [InlineData("RaceBgmCutinExtensionTime/1", true)]
        public async Task GetRaceBgmCutinExtensionTime(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceBgmCutinExtensionTime>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceBgmPattern", false)]
        [InlineData("RaceBgmPattern/1", true)]
        public async Task GetRaceBgmPattern(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceBgmPattern>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceBibColor", false)]
        [InlineData("RaceBibColor/0", false)]
        public async Task GetRaceBibColor(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceBibColor>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceCondition", false)]
        [InlineData("RaceCondition/1", true)]
        public async Task GetRaceCondition(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceCondition>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceCourseSet", false)]
        [InlineData("RaceCourseSet/10101", true)]
        public async Task GetRaceCourseSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceCourseSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceCourseSetStatus", false)]
        [InlineData("RaceCourseSetStatus/1", true)]
        public async Task GetRaceCourseSetStatus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceCourseSetStatus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceEnvDefine", false)]
        [InlineData("RaceEnvDefine/1", true)]
        public async Task GetRaceEnvDefine(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceEnvDefine>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceFenceSet", false)]
        [InlineData("RaceFenceSet/10101", true)]
        public async Task GetRaceFenceSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceFenceSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceInstance", false)]
        [InlineData("RaceInstance/100101", true)]
        public async Task GetRaceInstance(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceInstance>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceJikkyoBase", false)]
        [InlineData("RaceJikkyoBase/1", true)]
        public async Task GetRaceJikkyoBase(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceJikkyoBase>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceJikkyoComment", false)]
        [InlineData("RaceJikkyoComment/1", true)]
        public async Task GetRaceJikkyoComment(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceJikkyoComment>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceJikkyoCue", false)]
        [InlineData("RaceJikkyoCue/1", false)]
        public async Task GetRaceJikkyoCue(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceJikkyoCue>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceJikkyoMessage", false)]
        [InlineData("RaceJikkyoMessage/1", true)]
        public async Task GetRaceJikkyoMessage(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceJikkyoMessage>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceJikkyoRace", false)]
        [InlineData("RaceJikkyoRace/1001", true)]
        public async Task GetRaceJikkyoRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceJikkyoRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceJikkyoTrigger", false)]
        [InlineData("RaceJikkyoTrigger/1", true)]
        public async Task GetRaceJikkyoTrigger(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceJikkyoTrigger>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceMotivationRate", false)]
        [InlineData("RaceMotivationRate/1", true)]
        public async Task GetRaceMotivationRate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceMotivationRate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceOverrunPattern", false)]
        [InlineData("RaceOverrunPattern/1", true)]
        public async Task GetRaceOverrunPattern(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceOverrunPattern>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RacePlayerCamera", false)]
        [InlineData("RacePlayerCamera/100000", true)]
        public async Task GetRacePlayerCamera(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RacePlayerCamera>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RacePopularityProperValue", false)]
        [InlineData("RacePopularityProperValue/1", true)]
        public async Task GetRacePopularityProperValue(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RacePopularityProperValue>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceProperDistanceRate", false)]
        [InlineData("RaceProperDistanceRate/1", true)]
        public async Task GetRaceProperDistanceRate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceProperDistanceRate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceProperGroundRate", false)]
        [InlineData("RaceProperGroundRate/1", true)]
        public async Task GetRaceProperGroundRate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceProperGroundRate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceProperRunningstyleRate", false)]
        [InlineData("RaceProperRunningstyleRate/1", true)]
        public async Task GetRaceProperRunningstyleRate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceProperRunningstyleRate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceSingleModeTeamStatus", false)]
        [InlineData("RaceSingleModeTeamStatus/1", true)]
        public async Task GetRaceSingleModeTeamStatus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceSingleModeTeamStatus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceTrack", false)]
        [InlineData("RaceTrack/10001", true)]
        public async Task GetRaceTrack(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceTrack>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceTrophy", false)]
        [InlineData("RaceTrophy/1", true)]
        public async Task GetRaceTrophy(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceTrophy>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RaceTrophyReward", false)]
        [InlineData("RaceTrophyReward/1001", true)]
        public async Task GetRaceTrophyReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RaceTrophyReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("RandomEarTailMotion", false)]
        [InlineData("RandomEarTailMotion/1", true)]
        public async Task GetRandomEarTailMotion(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<RandomEarTailMotion>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SeasonData", false)]
        [InlineData("SeasonData/1", true)]
        public async Task GetSeasonData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SeasonData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("ShortEpisode", false)]
        [InlineData("ShortEpisode/1", true)]
        public async Task GetShortEpisode(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<ShortEpisode>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeAnalyzeMessage", false)]
        [InlineData("SingleModeAnalyzeMessage/1", true)]
        public async Task GetSingleModeAnalyzeMessage(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeAnalyzeMessage>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeAnalyzeTicket", false)]
        [InlineData("SingleModeAnalyzeTicket/1", true)]
        public async Task GetSingleModeAnalyzeTicket(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeAnalyzeTicket>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeAoharuCuttType", false)]
        [InlineData("SingleModeAoharuCuttType/1", true)]
        public async Task GetSingleModeAoharuCuttType(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeAoharuCuttType>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeAoharuResultCutt", false)]
        [InlineData("SingleModeAoharuResultCutt/1", true)]
        public async Task GetSingleModeAoharuResultCutt(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeAoharuResultCutt>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeAoharuSchedule", false)]
        [InlineData("SingleModeAoharuSchedule/1", true)]
        public async Task GetSingleModeAoharuSchedule(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeAoharuSchedule>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeAoOffset", false)]
        [InlineData("SingleModeAoOffset/1", true)]
        public async Task GetSingleModeAoOffset(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeAoOffset>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeAoTrainingPlate", false)]
        [InlineData("SingleModeAoTrainingPlate/1", true)]
        public async Task GetSingleModeAoTrainingPlate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeAoTrainingPlate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeChangeCharaRoute", false)]
        [InlineData("SingleModeChangeCharaRoute/1", true)]
        public async Task GetSingleModeChangeCharaRoute(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeChangeCharaRoute>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeCharaEffect", false)]
        [InlineData("SingleModeCharaEffect/1", true)]
        public async Task GetSingleModeCharaEffect(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeCharaEffect>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeCharaGrade", false)]
        [InlineData("SingleModeCharaGrade/1", true)]
        public async Task GetSingleModeCharaGrade(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeCharaGrade>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeCharaProgram", false)]
        [InlineData("SingleModeCharaProgram/1", true)]
        public async Task GetSingleModeCharaProgram(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeCharaProgram>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeConclusionSet", false)]
        [InlineData("SingleModeConclusionSet/400000035", false)]
        public async Task GetSingleModeConclusionSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeConclusionSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeDifficultyBox", false)]
        [InlineData("SingleModeDifficultyBox/1", false)]
        public async Task GetSingleModeDifficultyBox(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeDifficultyBox>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeDifficultyBoxGauge", false)]
        [InlineData("SingleModeDifficultyBoxGauge/1", true)]
        public async Task GetSingleModeDifficultyBoxGauge(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeDifficultyBoxGauge>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeDifficultyBoxReward", false)]
        [InlineData("SingleModeDifficultyBoxReward/1", true)]
        public async Task GetSingleModeDifficultyBoxReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeDifficultyBoxReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeDifficultyData", false)]
        [InlineData("SingleModeDifficultyData/1000", false)]
        public async Task GetSingleModeDifficultyData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeDifficultyData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeDifficultyMode", false)]
        [InlineData("SingleModeDifficultyMode/1000", true)]
        public async Task GetSingleModeDifficultyMode(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeDifficultyMode>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeEvaluation", false)]
        [InlineData("SingleModeEvaluation/1", true)]
        public async Task GetSingleModeEvaluation(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeEvaluation>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeEventConclusion", false)]
        [InlineData("SingleModeEventConclusion/1", false)]
        public async Task GetSingleModeEventConclusion(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeEventConclusion>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeEventItemDetail", false)]
        [InlineData("SingleModeEventItemDetail/1", true)]
        public async Task GetSingleModeEventItemDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeEventItemDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeEventProduction", false)]
        [InlineData("SingleModeEventProduction/400001017", true)]
        public async Task GetSingleModeEventProduction(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeEventProduction>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFanCount", false)]
        [InlineData("SingleModeFanCount/1", true)]
        public async Task GetSingleModeFanCount(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFanCount>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFreeCoinRace", false)]
        [InlineData("SingleModeFreeCoinRace/1", true)]
        public async Task GetSingleModeFreeCoinRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFreeCoinRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFreeShop", false)]
        [InlineData("SingleModeFreeShop/1", true)]
        public async Task GetSingleModeFreeShop(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFreeShop>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFreeShopBg", false)]
        [InlineData("SingleModeFreeShopBg/1", true)]
        public async Task GetSingleModeFreeShopBg(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFreeShopBg>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFreeShopEffect", false)]
        [InlineData("SingleModeFreeShopEffect/1", true)]
        public async Task GetSingleModeFreeShopEffect(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFreeShopEffect>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFreeShopItem", false)]
        [InlineData("SingleModeFreeShopItem/1", true)]
        public async Task GetSingleModeFreeShopItem(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFreeShopItem>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFreeTrainingPlate", false)]
        [InlineData("SingleModeFreeTrainingPlate/1", true)]
        public async Task GetSingleModeFreeTrainingPlate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFreeTrainingPlate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeFreeWinPoint", false)]
        [InlineData("SingleModeFreeWinPoint/1", true)]
        public async Task GetSingleModeFreeWinPoint(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeFreeWinPoint>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeHintGain", false)]
        [InlineData("SingleModeHintGain/1", true)]
        public async Task GetSingleModeHintGain(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeHintGain>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeMemberRank", false)]
        [InlineData("SingleModeMemberRank/1", true)]
        public async Task GetSingleModeMemberRank(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeMemberRank>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeMemberRankPoint", false)]
        [InlineData("SingleModeMemberRankPoint/1", true)]
        public async Task GetSingleModeMemberRankPoint(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeMemberRankPoint>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeMessage", false)]
        [InlineData("SingleModeMessage/1", true)]
        public async Task GetSingleModeMessage(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeMessage>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeNpc", false)]
        [InlineData("SingleModeNpc/1", true)]
        public async Task GetSingleModeNpc(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeNpc>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeOuting", false)]
        [InlineData("SingleModeOuting/1", true)]
        public async Task GetSingleModeOuting(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeOuting>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeOutingSet", false)]
        [InlineData("SingleModeOutingSet/1", true)]
        public async Task GetSingleModeOutingSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeOutingSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeProgram", false)]
        [InlineData("SingleModeProgram/1", true)]
        public async Task GetSingleModeProgram(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeProgram>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRaceGroup", false)]
        [InlineData("SingleModeRaceGroup/1", true)]
        public async Task GetSingleModeRaceGroup(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRaceGroup>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRaceLive", false)]
        [InlineData("SingleModeRaceLive/1", true)]
        public async Task GetSingleModeRaceLive(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRaceLive>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRank", false)]
        [InlineData("SingleModeRank/1", true)]
        public async Task GetSingleModeRank(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRank>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRecommend", false)]
        [InlineData("SingleModeRecommend/1", true)]
        public async Task GetSingleModeRecommend(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRecommend>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRecommendSetting", false)]
        [InlineData("SingleModeRecommendSetting/1", true)]
        public async Task GetSingleModeRecommendSetting(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRecommendSetting>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRestrictSupport", false)]
        [InlineData("SingleModeRestrictSupport/1", true)]
        public async Task GetSingleModeRestrictSupport(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRestrictSupport>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRewardSet", false)]
        [InlineData("SingleModeRewardSet/1", true)]
        public async Task GetSingleModeRewardSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRewardSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRival", false)]
        [InlineData("SingleModeRival/1", true)]
        public async Task GetSingleModeRival(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRival>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRoute", false)]
        [InlineData("SingleModeRoute/1", true)]
        public async Task GetSingleModeRoute(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRoute>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRouteAnnounce", false)]
        [InlineData("SingleModeRouteAnnounce/4001", true)]
        public async Task GetSingleModeRouteAnnounce(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRouteAnnounce>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRouteCondition", false)]
        [InlineData("SingleModeRouteCondition/1", true)]
        public async Task GetSingleModeRouteCondition(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRouteCondition>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeRouteRace", false)]
        [InlineData("SingleModeRouteRace/1", true)]
        public async Task GetSingleModeRouteRace(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeRouteRace>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeScenario", false)]
        [InlineData("SingleModeScenario/1", true)]
        public async Task GetSingleModeScenario(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeScenario>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeScenarioRecord", false)]
        [InlineData("SingleModeScenarioRecord/1", true)]
        public async Task GetSingleModeScenarioRecord(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeScenarioRecord>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeScoutChara", false)]
        [InlineData("SingleModeScoutChara/1", true)]
        public async Task GetSingleModeScoutChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeScoutChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeSkillNeedPoint", false)]
        [InlineData("SingleModeSkillNeedPoint/200011", true)]
        public async Task GetSingleModeSkillNeedPoint(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeSkillNeedPoint>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeSpecialChara", false)]
        [InlineData("SingleModeSpecialChara/11", true)]
        public async Task GetSingleModeSpecialChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeSpecialChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeStoryData", false)]
        [InlineData("SingleModeStoryData/1", true)]
        public async Task GetSingleModeStoryData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeStoryData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeStoryGuide", false)]
        [InlineData("SingleModeStoryGuide/400002041", true)]
        public async Task GetSingleModeStoryGuide(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeStoryGuide>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTagCardPos", false)]
        [InlineData("SingleModeTagCardPos/1", true)]
        public async Task GetSingleModeTagCardPos(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTagCardPos>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTeamName", false)]
        [InlineData("SingleModeTeamName/1", true)]
        public async Task GetSingleModeTeamName(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTeamName>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTopBg", false)]
        [InlineData("SingleModeTopBg/1", true)]
        public async Task GetSingleModeTopBg(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTopBg>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTopBgChara", false)]
        [InlineData("SingleModeTopBgChara/212401", true)]
        public async Task GetSingleModeTopBgChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTopBgChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTraining", false)]
        [InlineData("SingleModeTraining/1", true)]
        public async Task GetSingleModeTraining(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTraining>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTrainingEffect", false)]
        [InlineData("SingleModeTrainingEffect/1", true)]
        public async Task GetSingleModeTrainingEffect(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTrainingEffect>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTrainingSe", false)]
        [InlineData("SingleModeTrainingSe/1", true)]
        public async Task GetSingleModeTrainingSe(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTrainingSe>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeTurn", false)]
        [InlineData("SingleModeTurn/1", true)]
        public async Task GetSingleModeTurn(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeTurn>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeUniqueChara", false)]
        [InlineData("SingleModeUniqueChara/1", true)]
        public async Task GetSingleModeUniqueChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeUniqueChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SingleModeWinsSaddle", false)]
        [InlineData("SingleModeWinsSaddle/1", true)]
        public async Task GetSingleModeWinsSaddle(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SingleModeWinsSaddle>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SkillData", false)]
        [InlineData("SkillData/10071", true)]
        public async Task GetSkillData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SkillData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SkillExp", false)]
        [InlineData("SkillExp/1", true)]
        public async Task GetSkillExp(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SkillExp>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SkillLevelValue", false)]
        [InlineData("SkillLevelValue/1", true)]
        public async Task GetSkillLevelValue(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SkillLevelValue>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SkillRarity", false)]
        [InlineData("SkillRarity/1", true)]
        public async Task GetSkillRarity(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SkillRarity>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SkillSet", false)]
        [InlineData("SkillSet/8008", true)]
        public async Task GetSkillSet(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SkillSet>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventBingoReward", false)]
        [InlineData("StoryEventBingoReward/1", true)]
        public async Task GetStoryEventBingoReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventBingoReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventBonusCard", false)]
        [InlineData("StoryEventBonusCard/1", true)]
        public async Task GetStoryEventBonusCard(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventBonusCard>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventBonusSupportCard", false)]
        [InlineData("StoryEventBonusSupportCard/1", true)]
        public async Task GetStoryEventBonusSupportCard(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventBonusSupportCard>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventData", false)]
        [InlineData("StoryEventData/1001", true)]
        public async Task GetStoryEventData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventMission", false)]
        [InlineData("StoryEventMission/1", true)]
        public async Task GetStoryEventMission(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventMission>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventMissionTopChara", false)]
        [InlineData("StoryEventMissionTopChara/1", true)]
        public async Task GetStoryEventMissionTopChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventMissionTopChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventNicknameBonus", false)]
        [InlineData("StoryEventNicknameBonus/1", true)]
        public async Task GetStoryEventNicknameBonus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventNicknameBonus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventPointReward", false)]
        [InlineData("StoryEventPointReward/1", true)]
        public async Task GetStoryEventPointReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventPointReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventRouletteBingo", false)]
        [InlineData("StoryEventRouletteBingo/1", true)]
        public async Task GetStoryEventRouletteBingo(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventRouletteBingo>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventStoryData", false)]
        [InlineData("StoryEventStoryData/1", true)]
        public async Task GetStoryEventStoryData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventStoryData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventTopChara", false)]
        [InlineData("StoryEventTopChara/1", true)]
        public async Task GetStoryEventTopChara(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventTopChara>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryEventWinBonus", false)]
        [InlineData("StoryEventWinBonus/1", true)]
        public async Task GetStoryEventWinBonus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryEventWinBonus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryExtraData", false)]
        [InlineData("StoryExtraData/1001", true)]
        public async Task GetStoryExtraData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryExtraData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryExtraStoryData", false)]
        [InlineData("StoryExtraStoryData/1", true)]
        public async Task GetStoryExtraStoryData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryExtraStoryData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryHipOffset", false)]
        [InlineData("StoryHipOffset/40", false)]
        public async Task GetStoryHipOffset(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryHipOffset>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryLivePosition", false)]
        [InlineData("StoryLivePosition/1", true)]
        public async Task GetStoryLivePosition(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryLivePosition>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("StoryStill", false)]
        [InlineData("StoryStill/1", true)]
        public async Task GetStoryStill(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<StoryStill>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SuccessionFactor", false)]
        [InlineData("SuccessionFactor/101", true)]
        public async Task GetSuccessionFactor(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SuccessionFactor>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SuccessionFactorEffect", false)]
        [InlineData("SuccessionFactorEffect/1", true)]
        public async Task GetSuccessionFactorEffect(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SuccessionFactorEffect>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SuccessionInitialFactor", false)]
        [InlineData("SuccessionInitialFactor/1", true)]
        public async Task GetSuccessionInitialFactor(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SuccessionInitialFactor>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SuccessionRelation", false)]
        [InlineData("SuccessionRelation/101", true)]
        public async Task GetSuccessionRelation(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SuccessionRelation>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SuccessionRelationMember", false)]
        [InlineData("SuccessionRelationMember/1", true)]
        public async Task GetSuccessionRelationMember(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SuccessionRelationMember>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SuccessionRelationRank", false)]
        [InlineData("SuccessionRelationRank/1", true)]
        public async Task GetSuccessionRelationRank(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SuccessionRelationRank>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SuccessionRental", false)]
        [InlineData("SuccessionRental/1", true)]
        public async Task GetSuccessionRental(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SuccessionRental>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardData", false)]
        [InlineData("SupportCardData/10001", true)]
        public async Task GetSupportCardData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardEffectTable", false)]
        [InlineData("SupportCardEffectTable/10001", false)]
        public async Task GetSupportCardEffectTable(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardEffectTable>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardGroup", false)]
        [InlineData("SupportCardGroup/1", true)]
        public async Task GetSupportCardGroup(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardGroup>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardLevel", false)]
        [InlineData("SupportCardLevel/1001", true)]
        public async Task GetSupportCardLevel(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardLevel>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardLimit", false)]
        [InlineData("SupportCardLimit/1", true)]
        public async Task GetSupportCardLimit(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardLimit>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardLimitBreak", false)]
        [InlineData("SupportCardLimitBreak/2020", true)]
        public async Task GetSupportCardLimitBreak(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardLimitBreak>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardTeamScoreBonus", false)]
        [InlineData("SupportCardTeamScoreBonus/1", true)]
        public async Task GetSupportCardTeamScoreBonus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardTeamScoreBonus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("SupportCardUniqueEffect", false)]
        [InlineData("SupportCardUniqueEffect/20001", true)]
        public async Task GetSupportCardUniqueEffect(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<SupportCardUniqueEffect>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadium", false)]
        [InlineData("TeamStadium/1", true)]
        public async Task GetTeamStadium(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadium>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumBgm", false)]
        [InlineData("TeamStadiumBgm/1", true)]
        public async Task GetTeamStadiumBgm(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumBgm>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumClass", false)]
        [InlineData("TeamStadiumClass/1", true)]
        public async Task GetTeamStadiumClass(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumClass>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumClassReward", false)]
        [InlineData("TeamStadiumClassReward/1", true)]
        public async Task GetTeamStadiumClassReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumClassReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumEvaluationRate", false)]
        [InlineData("TeamStadiumEvaluationRate/1", false)]
        public async Task GetTeamStadiumEvaluationRate(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumEvaluationRate>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumRaceResultMotion", false)]
        [InlineData("TeamStadiumRaceResultMotion/1001", false)]
        public async Task GetTeamStadiumRaceResultMotion(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumRaceResultMotion>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumRank", false)]
        [InlineData("TeamStadiumRank/1", true)]
        public async Task GetTeamStadiumRank(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumRank>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumRawScore", false)]
        [InlineData("TeamStadiumRawScore/1", true)]
        public async Task GetTeamStadiumRawScore(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumRawScore>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumScoreBonus", false)]
        [InlineData("TeamStadiumScoreBonus/1", true)]
        public async Task GetTeamStadiumScoreBonus(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumScoreBonus>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumStandMotion", false)]
        [InlineData("TeamStadiumStandMotion/1010", false)]
        public async Task GetTeamStadiumStandMotion(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumStandMotion>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TeamStadiumSupportText", false)]
        [InlineData("TeamStadiumSupportText/1", true)]
        public async Task GetTeamStadiumSupportText(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TeamStadiumSupportText>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TextData", false)]
        [InlineData("TextData/1", false)]
        public async Task GetTextData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TextData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TextDataEnglish", false)]
        [InlineData("TextDataEnglish/1", true)]
        public async Task GetTextDataEnglish(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TextDataEnglish>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TimezoneData", false)]
        [InlineData("TimezoneData/1", true)]
        public async Task GetTimezoneData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TimezoneData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("Topic", false)]
        [InlineData("Topic/1", true)]
        public async Task GetTopic(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<Topic>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TrainedCharaTradeItem", false)]
        [InlineData("TrainedCharaTradeItem/1", true)]
        public async Task GetTrainedCharaTradeItem(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TrainedCharaTradeItem>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TrainingChallengeExam", false)]
        [InlineData("TrainingChallengeExam/1", true)]
        public async Task GetTrainingChallengeExam(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TrainingChallengeExam>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TrainingChallengeMaster", false)]
        [InlineData("TrainingChallengeMaster/2001", true)]
        public async Task GetTrainingChallengeMaster(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TrainingChallengeMaster>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TrainingChallengeScore", false)]
        [InlineData("TrainingChallengeScore/1", true)]
        public async Task GetTrainingChallengeScore(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TrainingChallengeScore>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TrainingChallengeTotalScore", false)]
        [InlineData("TrainingChallengeTotalScore/1", true)]
        public async Task GetTrainingChallengeTotalScore(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TrainingChallengeTotalScore>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TrainingCuttCharaData", false)]
        [InlineData("TrainingCuttCharaData/1", true)]
        public async Task GetTrainingCuttCharaData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TrainingCuttCharaData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TrainingCuttData", false)]
        [InlineData("TrainingCuttData/101045", false)]
        public async Task GetTrainingCuttData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TrainingCuttData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TransferEventData", false)]
        [InlineData("TransferEventData/1", true)]
        public async Task GetTransferEventData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TransferEventData>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TransferEventDetail", false)]
        [InlineData("TransferEventDetail/1001", true)]
        public async Task GetTransferEventDetail(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TransferEventDetail>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TransferEventReward", false)]
        [InlineData("TransferEventReward/10010101", true)]
        public async Task GetTransferEventReward(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TransferEventReward>(endpointUrl, hasSingleReturn);
        }

        [Theory]
        [Trait("EndpointType", "Raw")]
        [InlineData("TutorialGuideData", false)]
        [InlineData("TutorialGuideData/1", true)]
        public async Task GetTutorialGuideData(string endpointUrl, bool hasSingleReturn)
        {
            await TestGetEndpointAsync<TutorialGuideData>(endpointUrl, hasSingleReturn);
        }
        #endregion
    }
}

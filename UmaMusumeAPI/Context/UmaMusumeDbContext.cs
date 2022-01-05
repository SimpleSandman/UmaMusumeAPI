using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using UmaMusumeAPI.Models.StoredProcedures;
using UmaMusumeAPI.Models.Tables;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Context
{
    public partial class UmaMusumeDbContext : DbContext
    {
        public UmaMusumeDbContext(DbContextOptions<UmaMusumeDbContext> options) : base(options) { }

        #region DbSets Tables
        public virtual DbSet<AnnounceCharacter> AnnounceCharacters { get; set; }
        public virtual DbSet<AnnounceData> AnnounceData { get; set; }
        public virtual DbSet<AnnounceEvent> AnnounceEvents { get; set; }
        public virtual DbSet<AnnounceSupportCard> AnnounceSupportCards { get; set; }
        public virtual DbSet<AudioCuesheet> AudioCuesheets { get; set; }
        public virtual DbSet<AudioIgnoredCueOnHighspeed> AudioIgnoredCueOnHighspeeds { get; set; }
        public virtual DbSet<AudioStoryEffect> AudioStoryEffects { get; set; }
        public virtual DbSet<AvailableSkillSet> AvailableSkillSets { get; set; }
        public virtual DbSet<BackgroundData> BackgroundData { get; set; }
        public virtual DbSet<BackgroundOffsetData> BackgroundOffsetData { get; set; }
        public virtual DbSet<BannerData> BannerData { get; set; }
        public virtual DbSet<CampaignCharaStorySchedule> CampaignCharaStorySchedules { get; set; }
        public virtual DbSet<CampaignData> CampaignData { get; set; }
        public virtual DbSet<CampaignSingleRaceAddData> CampaignSingleRaceAddData { get; set; }
        public virtual DbSet<CampaignSingleRaceAddReward> CampaignSingleRaceAddRewards { get; set; }
        public virtual DbSet<CardData> CardData { get; set; }
        public virtual DbSet<CardRarityData> CardRarityData { get; set; }
        public virtual DbSet<CardTalentUpgrade> CardTalentUpgrades { get; set; }
        public virtual DbSet<ChallengeMatchBossNpc> ChallengeMatchBossNpcs { get; set; }
        public virtual DbSet<ChallengeMatchData> ChallengeMatchData { get; set; }
        public virtual DbSet<ChallengeMatchRace> ChallengeMatchRaces { get; set; }
        public virtual DbSet<ChallengeMatchRaceNpc> ChallengeMatchRaceNpcs { get; set; }
        public virtual DbSet<ChallengeMatchRawPoint> ChallengeMatchRawPoints { get; set; }
        public virtual DbSet<ChallengeMatchRetryBonus> ChallengeMatchRetryBonus { get; set; }
        public virtual DbSet<ChampionsBgm> ChampionsBgms { get; set; }
        public virtual DbSet<ChampionsEntryReward> ChampionsEntryRewards { get; set; }
        public virtual DbSet<ChampionsEvaluationRate> ChampionsEvaluationRates { get; set; }
        public virtual DbSet<ChampionsNewsCharaComment> ChampionsNewsCharaComments { get; set; }
        public virtual DbSet<ChampionsNewsCharaDetail> ChampionsNewsCharaDetails { get; set; }
        public virtual DbSet<ChampionsNewsCharaWininfo> ChampionsNewsCharaWininfos { get; set; }
        public virtual DbSet<ChampionsNewsRace> ChampionsNewsRaces { get; set; }
        public virtual DbSet<ChampionsNewsTitle> ChampionsNewsTitles { get; set; }
        public virtual DbSet<ChampionsNewsTrainerDetail> ChampionsNewsTrainerDetails { get; set; }
        public virtual DbSet<ChampionsNewsTrainerWininfo> ChampionsNewsTrainerWininfos { get; set; }
        public virtual DbSet<ChampionsRaceCondition> ChampionsRaceConditions { get; set; }
        public virtual DbSet<ChampionsRewardRate> ChampionsRewardRates { get; set; }
        public virtual DbSet<ChampionsRoundDetail> ChampionsRoundDetails { get; set; }
        public virtual DbSet<ChampionsRoundSchedule> ChampionsRoundSchedules { get; set; }
        public virtual DbSet<ChampionsSchedule> ChampionsSchedules { get; set; }
        public virtual DbSet<ChampionsStandMotion> ChampionsStandMotions { get; set; }
        public virtual DbSet<CharaCategoryMotion> CharaCategoryMotions { get; set; }
        public virtual DbSet<CharaData> CharaData { get; set; }
        public virtual DbSet<CharaMotionAct> CharaMotionActs { get; set; }
        public virtual DbSet<CharaMotionSet> CharaMotionSets { get; set; }
        public virtual DbSet<CharaStoryData> CharaStoryData { get; set; }
        public virtual DbSet<CharaType> CharaTypes { get; set; }
        public virtual DbSet<CharacterPropAnimation> CharacterPropAnimations { get; set; }
        public virtual DbSet<CharacterSystemLottery> CharacterSystemLotteries { get; set; }
        public virtual DbSet<CharacterSystemText> CharacterSystemTexts { get; set; }
        public virtual DbSet<CircleRankData> CircleRankData { get; set; }
        public virtual DbSet<CircleStampData> CircleStampData { get; set; }
        public virtual DbSet<CraneGameArmSwing> CraneGameArmSwings { get; set; }
        public virtual DbSet<CraneGameCatchResult> CraneGameCatchResults { get; set; }
        public virtual DbSet<CraneGameDefineParam> CraneGameDefineParams { get; set; }
        public virtual DbSet<CraneGameExtraOddsCondition> CraneGameExtraOddsConditions { get; set; }
        public virtual DbSet<CraneGameHiddenOdd> CraneGameHiddenOdds { get; set; }
        public virtual DbSet<CraneGamePrizeFace> CraneGamePrizeFaces { get; set; }
        public virtual DbSet<CraneGamePrizePattern> CraneGamePrizePatterns { get; set; }
        public virtual DbSet<CraneGameProp> CraneGameProps { get; set; }
        public virtual DbSet<DailyPack> DailyPacks { get; set; }
        public virtual DbSet<DailyRace> DailyRaces { get; set; }
        public virtual DbSet<DailyRaceBilling> DailyRaceBillings { get; set; }
        public virtual DbSet<DailyRaceNpc> DailyRaceNpcs { get; set; }
        public virtual DbSet<Directory> Directories { get; set; }
        public virtual DbSet<DressData> DressData { get; set; }
        public virtual DbSet<EventMotionData> EventMotionData { get; set; }
        public virtual DbSet<EventMotionPlusData> EventMotionPlusData { get; set; }
        public virtual DbSet<FaceTypeData> FaceTypeData { get; set; }
        public virtual DbSet<FacialMouthChange> FacialMouthChanges { get; set; }
        public virtual DbSet<GachaAvailable> GachaAvailables { get; set; }
        public virtual DbSet<GachaData> GachaData { get; set; }
        public virtual DbSet<GachaExchange> GachaExchanges { get; set; }
        public virtual DbSet<GachaFreeCampaign> GachaFreeCampaigns { get; set; }
        public virtual DbSet<GachaPiece> GachaPieces { get; set; }
        public virtual DbSet<GachaPrizeOdd> GachaPrizeOdds { get; set; }
        public virtual DbSet<GachaStockCampaign> GachaStockCampaigns { get; set; }
        public virtual DbSet<GachaStockDetail> GachaStockDetails { get; set; }
        public virtual DbSet<GachaTopBg> GachaTopBgs { get; set; }
        public virtual DbSet<GiftMessage> GiftMessages { get; set; }
        public virtual DbSet<HighlightInterpolate> HighlightInterpolates { get; set; }
        public virtual DbSet<HomeCharacterType> HomeCharacterTypes { get; set; }
        public virtual DbSet<HomeEnvSetting> HomeEnvSettings { get; set; }
        public virtual DbSet<HomeEventSchedule> HomeEventSchedules { get; set; }
        public virtual DbSet<HomePosterData> HomePosterData { get; set; }
        public virtual DbSet<HomePropSetting> HomePropSettings { get; set; }
        public virtual DbSet<HomeStoryTrigger> HomeStoryTriggers { get; set; }
        public virtual DbSet<HomeWalkGroup> HomeWalkGroups { get; set; }
        public virtual DbSet<HomeStoryHipOffset> HomeStoryHipOffsets { get; set; }
        public virtual DbSet<HonorData> HonorData { get; set; }
        public virtual DbSet<ItemData> ItemData { get; set; }
        public virtual DbSet<ItemExchange> ItemExchanges { get; set; }
        public virtual DbSet<ItemExchangeTop> ItemExchangeTops { get; set; }
        public virtual DbSet<ItemGroup> ItemGroups { get; set; }
        public virtual DbSet<ItemPack> ItemPacks { get; set; }
        public virtual DbSet<ItemPlace> ItemPlaces { get; set; }
        public virtual DbSet<JukeboxCharaTagData> JukeboxCharaTagData { get; set; }
        public virtual DbSet<JukeboxComment> JukeboxComments { get; set; }
        public virtual DbSet<JukeboxMotionData> JukeboxMotionData { get; set; }
        public virtual DbSet<JukeboxMusicData> JukeboxMusicData { get; set; }
        public virtual DbSet<JukeboxReactionData> JukeboxReactionData { get; set; }
        public virtual DbSet<JukeboxRequestData> JukeboxRequestData { get; set; }
        public virtual DbSet<LegendRace> LegendRaces { get; set; }
        public virtual DbSet<LegendRaceBilling> LegendRaceBillings { get; set; }
        public virtual DbSet<LegendRaceBossNpc> LegendRaceBossNpcs { get; set; }
        public virtual DbSet<LegendRaceNpc> LegendRaceNpcs { get; set; }
        public virtual DbSet<LimitedExchange> LimitedExchanges { get; set; }
        public virtual DbSet<LimitedExchangeReward> LimitedExchangeRewards { get; set; }
        public virtual DbSet<LimitedExchangeRewardOdd> LimitedExchangeRewardOdds { get; set; }
        public virtual DbSet<LiveData> LiveData { get; set; }
        public virtual DbSet<LivePermissionData> LivePermissionData { get; set; }
        public virtual DbSet<LoginBonusData> LoginBonusData { get; set; }
        public virtual DbSet<LoginBonusDetail> LoginBonusDetails { get; set; }
        public virtual DbSet<LoveRank> LoveRanks { get; set; }
        public virtual DbSet<MainStoryData> MainStoryData { get; set; }
        public virtual DbSet<MainStoryPart> MainStoryParts { get; set; }
        public virtual DbSet<MainStoryRaceBonus> MainStoryRaceBonus { get; set; }
        public virtual DbSet<MainStoryRaceBonusCondition> MainStoryRaceBonusConditions { get; set; }
        public virtual DbSet<MainStoryRaceCharaData> MainStoryRaceCharaData { get; set; }
        public virtual DbSet<MainStoryRaceData> MainStoryRaceData { get; set; }
        public virtual DbSet<MiniBg> MiniBgs { get; set; }
        public virtual DbSet<MiniBgCharaMotion> MiniBgCharaMotions { get; set; }
        public virtual DbSet<MiniFaceTypeData> MiniFaceTypeData { get; set; }
        public virtual DbSet<MiniMotionSet> MiniMotionSets { get; set; }
        public virtual DbSet<MiniMouthType> MiniMouthTypes { get; set; }
        public virtual DbSet<MissionData> MissionData { get; set; }
        public virtual DbSet<MobData> MobData { get; set; }
        public virtual DbSet<MobDressColorSet> MobDressColorSets { get; set; }
        public virtual DbSet<MobHairColorSet> MobHairColorSets { get; set; }
        public virtual DbSet<NeedPieceNumData> NeedPieceNumData { get; set; }
        public virtual DbSet<Nickname> Nicknames { get; set; }
        public virtual DbSet<NoteProfile> NoteProfiles { get; set; }
        public virtual DbSet<NoteProfileTextType> NoteProfileTextTypes { get; set; }
        public virtual DbSet<PieceData> PieceData { get; set; }
        public virtual DbSet<PriceChange> PriceChanges { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<RaceBgm> RaceBgms { get; set; }
        public virtual DbSet<RaceBgmCutinExtensionTime> RaceBgmCutinExtensionTimes { get; set; }
        public virtual DbSet<RaceBgmPattern> RaceBgmPatterns { get; set; }
        public virtual DbSet<RaceBibColor> RaceBibColors { get; set; }
        public virtual DbSet<RaceCondition> RaceConditions { get; set; }
        public virtual DbSet<RaceCourseSet> RaceCourseSets { get; set; }
        public virtual DbSet<RaceCourseSetStatus> RaceCourseSetStatuses { get; set; }
        public virtual DbSet<RaceEnvDefine> RaceEnvDefines { get; set; }
        public virtual DbSet<RaceFenceSet> RaceFenceSets { get; set; }
        public virtual DbSet<RaceInstance> RaceInstances { get; set; }
        public virtual DbSet<RaceJikkyoBase> RaceJikkyoBases { get; set; }
        public virtual DbSet<RaceJikkyoComment> RaceJikkyoComments { get; set; }
        public virtual DbSet<RaceJikkyoCue> RaceJikkyoCues { get; set; }
        public virtual DbSet<RaceJikkyoMessage> RaceJikkyoMessages { get; set; }
        public virtual DbSet<RaceJikkyoRace> RaceJikkyoRaces { get; set; }
        public virtual DbSet<RaceJikkyoTrigger> RaceJikkyoTriggers { get; set; }
        public virtual DbSet<RaceMotivationRate> RaceMotivationRates { get; set; }
        public virtual DbSet<RaceOverrunPattern> RaceOverrunPatterns { get; set; }
        public virtual DbSet<RacePlayerCamera> RacePlayerCameras { get; set; }
        public virtual DbSet<RacePopularityProperValue> RacePopularityProperValues { get; set; }
        public virtual DbSet<RaceProperDistanceRate> RaceProperDistanceRates { get; set; }
        public virtual DbSet<RaceProperGroundRate> RaceProperGroundRates { get; set; }
        public virtual DbSet<RaceProperRunningstyleRate> RaceProperRunningstyleRates { get; set; }
        public virtual DbSet<RaceSingleModeTeamStatus> RaceSingleModeTeamStatuses { get; set; }
        public virtual DbSet<RaceTrack> RaceTracks { get; set; }
        public virtual DbSet<RaceTrophy> RaceTrophies { get; set; }
        public virtual DbSet<RaceTrophyReward> RaceTrophyRewards { get; set; }
        public virtual DbSet<RandomEarTailMotion> RandomEarTailMotions { get; set; }
        public virtual DbSet<SeasonData> SeasonData { get; set; }
        public virtual DbSet<ShortEpisode> ShortEpisodes { get; set; }
        public virtual DbSet<SingleModeAnalyzeMessage> SingleModeAnalyzeMessages { get; set; }
        public virtual DbSet<SingleModeAnalyzeTicket> SingleModeAnalyzeTickets { get; set; }
        public virtual DbSet<SingleModeAoOffset> SingleModeAoOffsets { get; set; }
        public virtual DbSet<SingleModeAoTrainingPlate> SingleModeAoTrainingPlates { get; set; }
        public virtual DbSet<SingleModeAoharuCuttType> SingleModeAoharuCuttTypes { get; set; }
        public virtual DbSet<SingleModeAoharuResultCutt> SingleModeAoharuResultCutts { get; set; }
        public virtual DbSet<SingleModeAoharuSchedule> SingleModeAoharuSchedules { get; set; }
        public virtual DbSet<SingleModeCharaEffect> SingleModeCharaEffects { get; set; }
        public virtual DbSet<SingleModeCharaGrade> SingleModeCharaGrades { get; set; }
        public virtual DbSet<SingleModeCharaProgram> SingleModeCharaPrograms { get; set; }
        public virtual DbSet<SingleModeConclusionSet> SingleModeConclusionSets { get; set; }
        public virtual DbSet<SingleModeDifficultyBox> SingleModeDifficultyBoxes { get; set; }
        public virtual DbSet<SingleModeDifficultyBoxGauge> SingleModeDifficultyBoxGauges { get; set; }
        public virtual DbSet<SingleModeDifficultyBoxReward> SingleModeDifficultyBoxRewards { get; set; }
        public virtual DbSet<SingleModeDifficultyData> SingleModeDifficultyData { get; set; }
        public virtual DbSet<SingleModeDifficultyMode> SingleModeDifficultyModes { get; set; }
        public virtual DbSet<SingleModeEvaluation> SingleModeEvaluations { get; set; }
        public virtual DbSet<SingleModeEventConclusion> SingleModeEventConclusions { get; set; }
        public virtual DbSet<SingleModeEventItemDetail> SingleModeEventItemDetails { get; set; }
        public virtual DbSet<SingleModeEventProduction> SingleModeEventProductions { get; set; }
        public virtual DbSet<SingleModeFanCount> SingleModeFanCounts { get; set; }
        public virtual DbSet<SingleModeHintGain> SingleModeHintGains { get; set; }
        public virtual DbSet<SingleModeMemberRank> SingleModeMemberRanks { get; set; }
        public virtual DbSet<SingleModeMemberRankPoint> SingleModeMemberRankPoints { get; set; }
        public virtual DbSet<SingleModeMessage> SingleModeMessages { get; set; }
        public virtual DbSet<SingleModeNpc> SingleModeNpcs { get; set; }
        public virtual DbSet<SingleModeOuting> SingleModeOutings { get; set; }
        public virtual DbSet<SingleModeOutingSet> SingleModeOutingSets { get; set; }
        public virtual DbSet<SingleModeProgram> SingleModePrograms { get; set; }
        public virtual DbSet<SingleModeRaceGroup> SingleModeRaceGroups { get; set; }
        public virtual DbSet<SingleModeRaceLive> SingleModeRaceLives { get; set; }
        public virtual DbSet<SingleModeRank> SingleModeRanks { get; set; }
        public virtual DbSet<SingleModeRecommend> SingleModeRecommends { get; set; }
        public virtual DbSet<SingleModeRecommendSetting> SingleModeRecommendSettings { get; set; }
        public virtual DbSet<SingleModeRewardSet> SingleModeRewardSets { get; set; }
        public virtual DbSet<SingleModeRival> SingleModeRivals { get; set; }
        public virtual DbSet<SingleModeRoute> SingleModeRoutes { get; set; }
        public virtual DbSet<SingleModeRouteRace> SingleModeRouteRaces { get; set; }
        public virtual DbSet<SingleModeScenario> SingleModeScenarios { get; set; }
        public virtual DbSet<SingleModeScenarioRecord> SingleModeScenarioRecords { get; set; }
        public virtual DbSet<SingleModeScoutChara> SingleModeScoutCharas { get; set; }
        public virtual DbSet<SingleModeSkillNeedPoint> SingleModeSkillNeedPoints { get; set; }
        public virtual DbSet<SingleModeSpecialChara> SingleModeSpecialCharas { get; set; }
        public virtual DbSet<SingleModeStoryData> SingleModeStoryData { get; set; }
        public virtual DbSet<SingleModeStoryGuide> SingleModeStoryGuides { get; set; }
        public virtual DbSet<SingleModeTagCardPo> SingleModeTagCardPos { get; set; }
        public virtual DbSet<SingleModeTeamName> SingleModeTeamNames { get; set; }
        public virtual DbSet<SingleModeTopBg> SingleModeTopBgs { get; set; }
        public virtual DbSet<SingleModeTopBgChara> SingleModeTopBgCharas { get; set; }
        public virtual DbSet<SingleModeTraining> SingleModeTrainings { get; set; }
        public virtual DbSet<SingleModeTrainingEffect> SingleModeTrainingEffects { get; set; }
        public virtual DbSet<SingleModeTrainingSe> SingleModeTrainingSes { get; set; }
        public virtual DbSet<SingleModeTurn> SingleModeTurns { get; set; }
        public virtual DbSet<SingleModeUniqueChara> SingleModeUniqueCharas { get; set; }
        public virtual DbSet<SingleModeWinsSaddle> SingleModeWinsSaddles { get; set; }
        public virtual DbSet<SkillData> SkillData { get; set; }
        public virtual DbSet<SkillExp> SkillExps { get; set; }
        public virtual DbSet<SkillLevelValue> SkillLevelValues { get; set; }
        public virtual DbSet<SkillRarity> SkillRarities { get; set; }
        public virtual DbSet<SkillSet> SkillSets { get; set; }
        public virtual DbSet<StoryEventBingoReward> StoryEventBingoRewards { get; set; }
        public virtual DbSet<StoryEventBonusCard> StoryEventBonusCards { get; set; }
        public virtual DbSet<StoryEventBonusSupportCard> StoryEventBonusSupportCards { get; set; }
        public virtual DbSet<StoryEventData> StoryEventData { get; set; }
        public virtual DbSet<StoryEventMission> StoryEventMissions { get; set; }
        public virtual DbSet<StoryEventMissionTopChara> StoryEventMissionTopCharas { get; set; }
        public virtual DbSet<StoryEventNicknameBonus> StoryEventNicknameBonus { get; set; }
        public virtual DbSet<StoryEventPointReward> StoryEventPointRewards { get; set; }
        public virtual DbSet<StoryEventRouletteBingo> StoryEventRouletteBingos { get; set; }
        public virtual DbSet<StoryEventStoryData> StoryEventStoryData { get; set; }
        public virtual DbSet<StoryEventTopChara> StoryEventTopCharas { get; set; }
        public virtual DbSet<StoryEventWinBonus> StoryEventWinBonus { get; set; }
        public virtual DbSet<StoryExtraData> StoryExtraData { get; set; }
        public virtual DbSet<StoryExtraStoryData> StoryExtraStoryData { get; set; }
        public virtual DbSet<StoryHipOffset> StoryHipOffsets { get; set; }
        public virtual DbSet<StoryLivePosition> StoryLivePositions { get; set; }
        public virtual DbSet<StoryLiveSet> StoryLiveSets { get; set; }
        public virtual DbSet<StoryStill> StoryStills { get; set; }
        public virtual DbSet<SuccessionFactor> SuccessionFactors { get; set; }
        public virtual DbSet<SuccessionFactorEffect> SuccessionFactorEffects { get; set; }
        public virtual DbSet<SuccessionInitialFactor> SuccessionInitialFactors { get; set; }
        public virtual DbSet<SuccessionRelation> SuccessionRelations { get; set; }
        public virtual DbSet<SuccessionRelationMember> SuccessionRelationMembers { get; set; }
        public virtual DbSet<SuccessionRelationRank> SuccessionRelationRanks { get; set; }
        public virtual DbSet<SuccessionRental> SuccessionRentals { get; set; }
        public virtual DbSet<SupportCardData> SupportCardData { get; set; }
        public virtual DbSet<SupportCardEffectTable> SupportCardEffectTables { get; set; }
        public virtual DbSet<SupportCardLevel> SupportCardLevels { get; set; }
        public virtual DbSet<SupportCardLimit> SupportCardLimits { get; set; }
        public virtual DbSet<SupportCardLimitBreak> SupportCardLimitBreaks { get; set; }
        public virtual DbSet<SupportCardTeamScoreBonus> SupportCardTeamScoreBonus { get; set; }
        public virtual DbSet<SupportCardUniqueEffect> SupportCardUniqueEffects { get; set; }
        public virtual DbSet<TeamStadium> TeamStadia { get; set; }
        public virtual DbSet<TeamStadiumBgm> TeamStadiumBgms { get; set; }
        public virtual DbSet<TeamStadiumClass> TeamStadiumClasses { get; set; }
        public virtual DbSet<TeamStadiumClassReward> TeamStadiumClassRewards { get; set; }
        public virtual DbSet<TeamStadiumEvaluationRate> TeamStadiumEvaluationRates { get; set; }
        public virtual DbSet<TeamStadiumRaceResultMotion> TeamStadiumRaceResultMotions { get; set; }
        public virtual DbSet<TeamStadiumRank> TeamStadiumRanks { get; set; }
        public virtual DbSet<TeamStadiumRawScore> TeamStadiumRawScores { get; set; }
        public virtual DbSet<TeamStadiumScoreBonus> TeamStadiumScoreBonus { get; set; }
        public virtual DbSet<TeamStadiumStandMotion> TeamStadiumStandMotions { get; set; }
        public virtual DbSet<TeamStadiumSupportText> TeamStadiumSupportTexts { get; set; }
        public virtual DbSet<TextData> TextData { get; set; }
        public virtual DbSet<TextDataEnglish> TextDataEnglish { get; set; }
        public virtual DbSet<TimezoneData> TimezoneData { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TrainedCharaTradeItem> TrainedCharaTradeItems { get; set; }
        public virtual DbSet<TrainingChallengeExam> TrainingChallengeExams { get; set; }
        public virtual DbSet<TrainingChallengeMaster> TrainingChallengeMasters { get; set; }
        public virtual DbSet<TrainingChallengeScore> TrainingChallengeScores { get; set; }
        public virtual DbSet<TrainingChallengeTotalScore> TrainingChallengeTotalScores { get; set; }
        public virtual DbSet<TrainingCuttCharaData> TrainingCuttCharaData { get; set; }
        public virtual DbSet<TrainingCuttData> TrainingCuttData { get; set; }
        public virtual DbSet<TransferEventData> TransferEventData { get; set; }
        public virtual DbSet<TransferEventDetail> TransferEventDetails { get; set; }
        public virtual DbSet<TransferEventReward> TransferEventRewards { get; set; }
        public virtual DbSet<TutorialGuideData> TutorialGuideData { get; set; }
        #endregion

        #region DbSets Views
        public virtual DbSet<BasicCardDataInfo> BasicCardDataInfos { get; set; }
        public virtual DbSet<BasicCharaDataInfo> BasicCharaDataInfos { get; set; }
        public virtual DbSet<BasicDressDataInfo> BasicDressDataInfos { get; set; }
        public virtual DbSet<BasicGachaDataInfo> BasicGachaDataInfos { get; set; }
        public virtual DbSet<BasicGiftMessageInfo> BasicGiftMessageInfos { get; set; }
        public virtual DbSet<BasicItemDataInfo> BasicItemDataInfos { get; set; }
        public virtual DbSet<BasicItemExchangeInfo> BasicItemExchangeInfos { get; set; }
        public virtual DbSet<BasicItemExchangeTopInfo> BasicItemExchangeTopInfos { get; set; }
        public virtual DbSet<BasicLiveDataInfo> BasicLiveDataInfos { get; set; }
        public virtual DbSet<BasicLoginBonusDataInfo> BasicLoginBonusDataInfos { get; set; }
        public virtual DbSet<BasicMainStoryDataInfo> BasicMainStoryDataInfos { get; set; }
        public virtual DbSet<BasicMissionDataInfo> BasicMissionDataInfos { get; set; }
        public virtual DbSet<BasicMobDataInfo> BasicMobDataInfos { get; set; }
        public virtual DbSet<BasicPieceDataInfo> BasicPieceDataInfos { get; set; }
        public virtual DbSet<BasicRaceInfo> BasicRaceInfos { get; set; }
        public virtual DbSet<BasicRaceInstanceInfo> BasicRaceInstanceInfos { get; set; }
        public virtual DbSet<BasicRaceTrackInfo> BasicRaceTrackInfos { get; set; }
        public virtual DbSet<BasicSingleModeCharaGradeInfo> BasicSingleModeCharaGradeInfos { get; set; }
        public virtual DbSet<BasicSkillDataInfo> BasicSkillDataInfos { get; set; }
        public virtual DbSet<BasicStoryEventDataInfo> BasicStoryEventDataInfos { get; set; }
        public virtual DbSet<BasicStoryEventMissionInfo> BasicStoryEventMissionInfos { get; set; }
        public virtual DbSet<BasicStoryEventStoryDataInfo> BasicStoryEventStoryDataInfos { get; set; }
        public virtual DbSet<BasicSupportCardDataInfo> BasicSupportCardDataInfos { get; set; }
        public virtual DbSet<BasicSupportCardUniqueEffectInfo> BasicSupportCardUniqueEffectInfos { get; set; }
        public virtual DbSet<BasicTeamStadiumScoreBonusInfo> BasicTeamStadiumScoreBonusInfos { get; set; }
        public virtual DbSet<CondensedSkillDataInfo> CondensedSkillDataInfos { get; set; }
        public virtual DbSet<NiceErrorMessage> NiceErrorMessages { get; set; }
        public virtual DbSet<NiceCharaBioInfo> NiceCharaBioInfos { get; set; }
        public virtual DbSet<NiceCardDataInfo> NiceCardDataInfos { get; set; }
        public virtual DbSet<NiceItemNamesCommentsInfo> NiceItemNamesCommentsInfos { get; set; }
        public virtual DbSet<NiceObjectivesInfo> NiceObjectivesInfos { get; set; }
        public virtual DbSet<NiceRaceInfo> NiceRaceInfos { get; set; }
        public virtual DbSet<NiceSkillDataInfo> NiceSkillDataInfos { get; set; }
        public virtual DbSet<NiceSuccessionRelationMemberType> NiceSuccessionRelationMemberTypes { get; set; }
        public virtual DbSet<NiceTutorialMessage> NiceTutorialMessages { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                     .SetBasePath(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory()))
                     .Build();
                string connectionString = Environment.GetEnvironmentVariable("MARIA_CONNECTION_STRING");

                MariaDbServerVersion serverVersion = new MariaDbServerVersion(ServerVersion.AutoDetect(connectionString));
                optionsBuilder.UseMySql(connectionString, serverVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            #region Stored Procedures
            modelBuilder.Entity<SpSuccessionGrandparentRecommendation>()
                .HasNoKey();

            modelBuilder.Entity<SpSuccessionParentRecommendation>()
                .HasNoKey();

            modelBuilder.Entity<SpSuccessionPointSum>()
                .HasNoKey();
            #endregion

            #region Tables
            modelBuilder.Entity<AnnounceCharacter>(entity =>
            {
                entity.ToTable("announce_character");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CanEndSecond)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("can_end_second");

                entity.Property(e => e.MovieId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("movie_id");
            });

            modelBuilder.Entity<AnnounceData>(entity =>
            {
                entity.ToTable("announce_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AnnounceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("announce_id");

                entity.Property(e => e.AnnounceType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("announce_type");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<AnnounceEvent>(entity =>
            {
                entity.ToTable("announce_event");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name");

                entity.Property(e => e.CueSheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_sheet_name");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.VoiceTextAsset)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("voice_text_asset");
            });

            modelBuilder.Entity<AnnounceSupportCard>(entity =>
            {
                entity.ToTable("announce_support_card");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CutsPattern)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cuts_pattern");

                entity.Property(e => e.SupportCardIdA)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id_a");

                entity.Property(e => e.SupportCardIdB)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id_b");

                entity.Property(e => e.SupportCardIdC)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id_c");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<AudioCuesheet>(entity =>
            {
                entity.ToTable("audio_cuesheet");

                entity.HasIndex(e => e.Attribute, "audio_cuesheet_0_attribute");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Attribute)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("attribute");

                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_sheet")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<AudioIgnoredCueOnHighspeed>(entity =>
            {
                entity.ToTable("audio_ignored_cue_on_highspeed");

                entity.HasIndex(e => new { e.CueName, e.CueSheet }, "audio_ignored_cue_on_highspeed_0_cue_name_1_cue_sheet");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("cue_sheet")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<AudioStoryEffect>(entity =>
            {
                entity.ToTable("audio_story_effect");

                entity.HasIndex(e => e.EffectName, "audio_story_effect_audio_story_effect_0_effect_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name");

                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_sheet");

                entity.Property(e => e.EffectName)
                    .IsRequired()
                    .HasMaxLength(600)
                    .HasColumnName("effect_name");

                entity.Property(e => e.LoopSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("loop_set");
            });

            modelBuilder.Entity<AvailableSkillSet>(entity =>
            {
                entity.ToTable("available_skill_set");

                entity.HasIndex(e => e.AvailableSkillSetId, "available_skill_set_0_available_skill_set_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AvailableSkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("available_skill_set_id");

                entity.Property(e => e.NeedRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_rank");

                entity.Property(e => e.SkillId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id");
            });

            modelBuilder.Entity<BackgroundData>(entity =>
            {
                entity.ToTable("background_data");

                entity.HasIndex(e => new { e.BgId, e.BgSub }, "background_data_0_bg_id_1_bg_sub")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_id");

                entity.Property(e => e.BgSub)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_sub");

                entity.Property(e => e.BusParamSetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bus_param_set_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Height)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("height");

                entity.Property(e => e.PosX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_x");

                entity.Property(e => e.PosY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_y");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Width)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<BackgroundOffsetData>(entity =>
            {
                entity.ToTable("background_offset_data");

                entity.HasIndex(e => new { e.BgId, e.BgSub }, "background_offset_data_0_bg_id_1_bg_sub");

                entity.HasIndex(e => new { e.BgId, e.BgSub, e.OffsetId }, "bg_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_id");

                entity.Property(e => e.BgSub)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_sub");

                entity.Property(e => e.Height)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("height");

                entity.Property(e => e.OffsetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset_id");

                entity.Property(e => e.PosX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_x");

                entity.Property(e => e.PosY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_y");

                entity.Property(e => e.Width)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<BannerData>(entity =>
            {
                entity.ToTable("banner_data");

                entity.HasIndex(e => e.GroupId, "banner_data_0_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BannerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("banner_id");

                entity.Property(e => e.ConditionValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Transition)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transition");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CampaignCharaStorySchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("campaign_chara_story_schedule");

                entity.HasIndex(e => e.CampaignId, "campaign_chara_story_schedule_0_campaign_id");

                entity.HasIndex(e => e.CharaId, "campaign_chara_story_schedule_0_chara_id");

                entity.Property(e => e.CampaignId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("campaign_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<CampaignData>(entity =>
            {
                entity.HasKey(e => e.CampaignId)
                    .HasName("PRIMARY");

                entity.ToTable("campaign_data");

                entity.HasIndex(e => e.ImageChange, "campaign_data_0_image_change");

                entity.HasIndex(e => e.TargetType, "campaign_data_0_target_type");

                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("campaign_id");

                entity.Property(e => e.EffectType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_type_1");

                entity.Property(e => e.EffectValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_value_1");

                entity.Property(e => e.EndTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_time");

                entity.Property(e => e.ImageChange)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("image_change");

                entity.Property(e => e.ImageIconId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("image_icon_id");

                entity.Property(e => e.StartTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_time");

                entity.Property(e => e.TargetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_id");

                entity.Property(e => e.TargetType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type");

                entity.Property(e => e.TransitionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transition_type");

                entity.Property(e => e.UserShow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_show");
            });

            modelBuilder.Entity<CampaignSingleRaceAddData>(entity =>
            {
                entity.ToTable("campaign_single_race_add_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RaceAdditionalId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_additional_id");

                entity.Property(e => e.RaceAdditionalRewardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_additional_reward_id");

                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_program_id");

                entity.Property(e => e.RewardLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_limit");
            });

            modelBuilder.Entity<CampaignSingleRaceAddReward>(entity =>
            {
                entity.ToTable("campaign_single_race_add_reward");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.RaceAdditionalRewardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_additional_reward_id");

                entity.Property(e => e.RewardRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_rate");

                entity.Property(e => e.RewardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_type");

                entity.Property(e => e.RewardValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_value");
            });

            modelBuilder.Entity<CardData>(entity =>
            {
                entity.ToTable("card_data");

                entity.HasIndex(e => e.CharaId, "card_data_0_chara_id");

                entity.HasIndex(e => e.GetPieceId, "card_data_0_get_piece_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AvailableSkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("available_skill_set_id");

                entity.Property(e => e.BgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DefaultRarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_rarity");

                entity.Property(e => e.GetPieceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("get_piece_id");

                entity.Property(e => e.LimitedChara)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limited_chara");

                entity.Property(e => e.RunningStyle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("running_style");

                entity.Property(e => e.TalentGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_group_id");

                entity.Property(e => e.TalentGuts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_guts");

                entity.Property(e => e.TalentPow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_pow");

                entity.Property(e => e.TalentSpeed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_speed");

                entity.Property(e => e.TalentStamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_stamina");

                entity.Property(e => e.TalentWiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_wiz");
            });

            modelBuilder.Entity<CardRarityData>(entity =>
            {
                entity.ToTable("card_rarity_data");

                entity.HasIndex(e => e.CardId, "card_rarity_data_0_card_id");

                entity.HasIndex(e => new { e.CardId, e.Rarity }, "card_rarity_data_0_card_id_1_rarity")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");

                entity.Property(e => e.GetDressId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("get_dress_id_1");

                entity.Property(e => e.GetDressId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("get_dress_id_2");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.LiveDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("live_dress_id");

                entity.Property(e => e.MaxGuts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_guts");

                entity.Property(e => e.MaxPow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_pow");

                entity.Property(e => e.MaxSpeed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_speed");

                entity.Property(e => e.MaxStamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_stamina");

                entity.Property(e => e.MaxWiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_wiz");

                entity.Property(e => e.MiniDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mini_dress_id");

                entity.Property(e => e.OutgameDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("outgame_dress_id");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<CardTalentUpgrade>(entity =>
            {
                entity.ToTable("card_talent_upgrade");

                entity.HasIndex(e => new { e.TalentGroupId, e.TalentLevel }, "card_talent_upgrade_0_talent_group_id_1_talent_level");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_1");

                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_2");

                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_3");

                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_4");

                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_5");

                entity.Property(e => e.ItemCategory6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_6");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_6");

                entity.Property(e => e.ItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_5");

                entity.Property(e => e.ItemNum6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_6");

                entity.Property(e => e.TalentGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_group_id");

                entity.Property(e => e.TalentLevel)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_level");
            });

            modelBuilder.Entity<ChallengeMatchBossNpc>(entity =>
            {
                entity.ToTable("challenge_match_boss_npc");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardRarityDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_rarity_data_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.NicknameId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("nickname_id");

                entity.Property(e => e.Post)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("post");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<ChallengeMatchData>(entity =>
            {
                entity.HasKey(e => e.ChallengeMatchId)
                    .HasName("PRIMARY");

                entity.ToTable("challenge_match_data");

                entity.Property(e => e.ChallengeMatchId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("challenge_match_id");

                entity.Property(e => e.AnnounceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("announce_id");

                entity.Property(e => e.BonusFactorId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_factor_id");

                entity.Property(e => e.BonusSkillId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_skill_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ending_date");

                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_exchange_top_id");

                entity.Property(e => e.NoticeDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ChallengeMatchRace>(entity =>
            {
                entity.ToTable("challenge_match_race");

                entity.HasIndex(e => e.ChallengeMatchId, "challenge_match_race_0_challenge_match_id");

                entity.HasIndex(e => e.RaceInstanceId, "challenge_match_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ChallengeMatchBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("challenge_match_bg_id");

                entity.Property(e => e.ChallengeMatchBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("challenge_match_bg_sub_id");

                entity.Property(e => e.ChallengeMatchId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("challenge_match_id");

                entity.Property(e => e.ChallengeMatchRaceBossNpcId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("challenge_match_race_boss_npc_id");

                entity.Property(e => e.CostRp)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_rp");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("difficulty");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.DropRewardOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("drop_reward_odds_id");

                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_1");

                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_2");

                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_3");

                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_1");

                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_2");

                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_3");

                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_1");

                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_2");

                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_3");

                entity.Property(e => e.Ground)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ground");

                entity.Property(e => e.PickUpItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_1");

                entity.Property(e => e.PickUpItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_2");

                entity.Property(e => e.PickUpItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_3");

                entity.Property(e => e.PickUpItemCategory4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_4");

                entity.Property(e => e.PickUpItemCategory5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_5");

                entity.Property(e => e.PickUpItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_1");

                entity.Property(e => e.PickUpItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_2");

                entity.Property(e => e.PickUpItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_3");

                entity.Property(e => e.PickUpItemId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_4");

                entity.Property(e => e.PickUpItemId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_5");

                entity.Property(e => e.PickUpItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_1");

                entity.Property(e => e.PickUpItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_2");

                entity.Property(e => e.PickUpItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_3");

                entity.Property(e => e.PickUpItemNum4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_4");

                entity.Property(e => e.PickUpItemNum5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_5");

                entity.Property(e => e.RaceAppearanceRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_appearance_rate");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_type");

                entity.Property(e => e.Season)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("season");

                entity.Property(e => e.VictoryRewardOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("victory_reward_odds_id");

                entity.Property(e => e.Weather)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<ChallengeMatchRaceNpc>(entity =>
            {
                entity.ToTable("challenge_match_race_npc");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.MobId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mob_id");

                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("npc_group_id");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<ChallengeMatchRawPoint>(entity =>
            {
                entity.ToTable("challenge_match_raw_point");

                entity.HasIndex(e => e.ConditionType, "challenge_match_raw_point_0_condition_type");

                entity.HasIndex(e => e.RacePointNameId, "challenge_match_raw_point_0_race_point_name_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.Point)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("point");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.RacePointNameId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_point_name_id");

                entity.Property(e => e.SortOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort_order");
            });

            modelBuilder.Entity<ChallengeMatchRetryBonus>(entity =>
            {
                entity.ToTable("challenge_match_retry_bonus");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_rate");

                entity.Property(e => e.ResimulateNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resimulate_num");

                entity.Property(e => e.RetryMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("retry_max");

                entity.Property(e => e.RetryMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("retry_min");
            });

            modelBuilder.Entity<ChampionsBgm>(entity =>
            {
                entity.ToTable("champions_bgm");

                entity.HasIndex(e => new { e.RoundId, e.SceneType, e.RaceNumber }, "champions_bgm_0_round_id_1_scene_type_2_race_number");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FirstBgmPattern)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_bgm_pattern");

                entity.Property(e => e.RaceNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_number");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");

                entity.Property(e => e.SceneType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scene_type");

                entity.Property(e => e.SecondBgmPattern)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("second_bgm_pattern");
            });

            modelBuilder.Entity<ChampionsEntryReward>(entity =>
            {
                entity.HasKey(e => new { e.ChampionsId, e.ItemId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("champions_entry_reward");

                entity.HasIndex(e => e.ChampionsId, "champions_entry_reward_0_champions_id");

                entity.Property(e => e.ChampionsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_id");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<ChampionsEvaluationRate>(entity =>
            {
                entity.ToTable("champions_evaluation_rate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_rank");

                entity.Property(e => e.ProperType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_type");

                entity.Property(e => e.Rate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<ChampionsNewsCharaComment>(entity =>
            {
                entity.ToTable("champions_news_chara_comment");

                entity.HasIndex(e => e.RoundId, "champions_news_chara_comment_0_round_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BigFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("big_flag");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");
            });

            modelBuilder.Entity<ChampionsNewsCharaDetail>(entity =>
            {
                entity.ToTable("champions_news_chara_detail");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CharaTextGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_text_group");

                entity.Property(e => e.NicknameId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("nickname_id");

                entity.Property(e => e.ParameterMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("parameter_min");

                entity.Property(e => e.ParameterType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("parameter_type");

                entity.Property(e => e.ProperRunningStyleMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_min");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource_id");

                entity.Property(e => e.RunningStyle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("running_style");

                entity.Property(e => e.SingleWin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_win");

                entity.Property(e => e.TextNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("text_number");
            });

            modelBuilder.Entity<ChampionsNewsCharaWininfo>(entity =>
            {
                entity.ToTable("champions_news_chara_wininfo");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaTextGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_text_group");

                entity.Property(e => e.RaceCountType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_count_type");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");

                entity.Property(e => e.WinMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_max");

                entity.Property(e => e.WinMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_min");
            });

            modelBuilder.Entity<ChampionsNewsRace>(entity =>
            {
                entity.ToTable("champions_news_race");

                entity.HasIndex(e => e.RoundId, "champions_news_race_0_round_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource_id");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");

                entity.Property(e => e.TextNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("text_number");

                entity.Property(e => e.WinPercentType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_percent_type");
            });

            modelBuilder.Entity<ChampionsNewsTitle>(entity =>
            {
                entity.ToTable("champions_news_title");

                entity.HasIndex(e => e.RoundId, "champions_news_title_0_round_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource_id");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");

                entity.Property(e => e.SubTitle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("title");

                entity.Property(e => e.WinPercentType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_percent_type");
            });

            modelBuilder.Entity<ChampionsNewsTrainerDetail>(entity =>
            {
                entity.ToTable("champions_news_trainer_detail");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource_id");

                entity.Property(e => e.TextNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("text_number");

                entity.Property(e => e.TrainerTextGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trainer_text_group");
            });

            modelBuilder.Entity<ChampionsNewsTrainerWininfo>(entity =>
            {
                entity.ToTable("champions_news_trainer_wininfo");

                entity.HasIndex(e => e.RoundId, "champions_news_trainer_wininfo_0_round_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RaceCountType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_count_type");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");

                entity.Property(e => e.TrainerTextGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trainer_text_group");

                entity.Property(e => e.WinMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_max");

                entity.Property(e => e.WinMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_min");
            });

            modelBuilder.Entity<ChampionsRaceCondition>(entity =>
            {
                entity.HasKey(e => new { e.ChampionsId, e.RoundId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("champions_race_condition");

                entity.Property(e => e.ChampionsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_id");

                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");

                entity.Property(e => e.RaceConditionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_condition_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<ChampionsRewardRate>(entity =>
            {
                entity.ToTable("champions_reward_rate");

                entity.HasIndex(e => new { e.ChampionsId, e.RoundId }, "champions_reward_rate_0_champions_id_1_round_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BoxGrade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("box_grade");

                entity.Property(e => e.ChampionsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_id");

                entity.Property(e => e.LeagueType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("league_type");

                entity.Property(e => e.Ranking)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ranking");

                entity.Property(e => e.Rate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rate");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_set_id");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");

                entity.Property(e => e.WinCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_count");
            });

            modelBuilder.Entity<ChampionsRoundDetail>(entity =>
            {
                entity.ToTable("champions_round_detail");

                entity.HasIndex(e => new { e.ChampionsId, e.LeagueType }, "champions_round_detail_0_champions_id_1_league_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BreakthroughNumber1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("breakthrough_number_1");

                entity.Property(e => e.BreakthroughNumber2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("breakthrough_number_2");

                entity.Property(e => e.ChampionsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_id");

                entity.Property(e => e.EntryNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("entry_number");

                entity.Property(e => e.FreeEntryNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("free_entry_number");

                entity.Property(e => e.LeagueType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("league_type");

                entity.Property(e => e.Round)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round");

                entity.Property(e => e.RoundId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_id");

                entity.Property(e => e.RoundNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_number");

                entity.Property(e => e.Tier)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tier");
            });

            modelBuilder.Entity<ChampionsRoundSchedule>(entity =>
            {
                entity.ToTable("champions_round_schedule");

                entity.HasIndex(e => e.ChampionsId, "champions_round_schedule_0_champions_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ChampionsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.IntervalEndTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("interval_end_time");

                entity.Property(e => e.IntervalStartTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("interval_start_time");

                entity.Property(e => e.Round)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round");

                entity.Property(e => e.RoundDetail)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("round_detail");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ChampionsSchedule>(entity =>
            {
                entity.ToTable("champions_schedule");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ChampionsBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_bg_id");

                entity.Property(e => e.ChampionsBgPositionX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_bg_position_x");

                entity.Property(e => e.ChampionsBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_bg_sub_id");

                entity.Property(e => e.ChampionsFinishBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_finish_bg_id");

                entity.Property(e => e.ChampionsFinishBgPositionX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_finish_bg_position_x");

                entity.Property(e => e.ChampionsFinishBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_finish_bg_sub_id");

                entity.Property(e => e.ChampionsLeagueSelectBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("champions_league_select_bg_sub_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.InfoDetail)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("info_detail");

                entity.Property(e => e.InfoDetail1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("info_detail_1");

                entity.Property(e => e.InfoDetail2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("info_detail_2");

                entity.Property(e => e.NoticeDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_date");

                entity.Property(e => e.ResourceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ChampionsStandMotion>(entity =>
            {
                entity.HasKey(e => new { e.CharaId, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("champions_stand_motion");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");

                entity.Property(e => e.MotionSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_set");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");
            });

            modelBuilder.Entity<CharaCategoryMotion>(entity =>
            {
                entity.HasKey(e => e.CharaId)
                    .HasName("PRIMARY");

                entity.ToTable("chara_category_motion");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("chara_id");

                entity.Property(e => e.StandbyMotion1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_1");

                entity.Property(e => e.StandbyMotion2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_2");

                entity.Property(e => e.StandbyMotion3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_3");

                entity.Property(e => e.StandbyMotion4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_4");

                entity.Property(e => e.StandbyMotion5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_5");

                entity.Property(e => e.StandbyMotion6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("standby_motion_6");
            });

            modelBuilder.Entity<CharaData>(entity =>
            {
                entity.ToTable("chara_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AttachmentModelId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("attachment_model_id");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("birth_month");

                entity.Property(e => e.BirthYear)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("birth_year");

                entity.Property(e => e.Bust)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bust");

                entity.Property(e => e.CharaCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_category");

                entity.Property(e => e.EarRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ear_random_time_max");

                entity.Property(e => e.EarRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ear_random_time_min");

                entity.Property(e => e.Height)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("height");

                entity.Property(e => e.ImageColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_main")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ImageColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_sub")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MiniMayuShaderType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mini_mayu_shader_type");

                entity.Property(e => e.PersonalDress)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("personal_dress");

                entity.Property(e => e.RaceRunningType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_running_type");

                entity.Property(e => e.Scale)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scale");

                entity.Property(e => e.Sex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sex");

                entity.Property(e => e.Shape)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("shape");

                entity.Property(e => e.Skin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skin");

                entity.Property(e => e.Socks)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("socks");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEarRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_ear_random_time_max");

                entity.Property(e => e.StoryEarRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_ear_random_time_min");

                entity.Property(e => e.StoryTailRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_tail_random_time_max");

                entity.Property(e => e.StoryTailRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_tail_random_time_min");

                entity.Property(e => e.TailModelId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_model_id");

                entity.Property(e => e.TailRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_random_time_max");

                entity.Property(e => e.TailRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_random_time_min");

                entity.Property(e => e.UiBorderColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_border_color")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_main")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_sub")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNameplateColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNameplateColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNumColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNumColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiSpeechColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiSpeechColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiTrainingColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiTrainingColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiTurnColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_turn_color")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiWipeColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiWipeColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiWipeColor3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_3")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<CharaMotionAct>(entity =>
            {
                entity.ToTable("chara_motion_act");

                entity.HasIndex(e => e.CharaId, "chara_motion_act_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.CommandName }, "chara_motion_act_0_chara_id_1_command_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasMaxLength(900)
                    .HasColumnName("command_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TargetMotion)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_motion");
            });

            modelBuilder.Entity<CharaMotionSet>(entity =>
            {
                entity.ToTable("chara_motion_set");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BodyMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("body_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BodyMotionPlayType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_motion_play_type");

                entity.Property(e => e.BodyMotionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_motion_type");

                entity.Property(e => e.Cheek)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cheek");

                entity.Property(e => e.EarMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ear_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeDefault)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("eye_default");

                entity.Property(e => e.FaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("face_type")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailMotionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_motion_type");
            });

            modelBuilder.Entity<CharaStoryData>(entity =>
            {
                entity.ToTable("chara_story_data");

                entity.HasIndex(e => e.CharaId, "chara_story_data_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.EpisodeIndex }, "chara_story_data_0_chara_id_1_episode_index");

                entity.HasIndex(e => e.StoryId, "chara_story_data_0_story_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_category_1");

                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_id_1");

                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_num_1");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.EpisodeIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("episode_index");

                entity.Property(e => e.ExpType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exp_type");

                entity.Property(e => e.LockType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_type_1");

                entity.Property(e => e.LockValue11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_1_1");

                entity.Property(e => e.LockValue12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_1_2");

                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<CharaType>(entity =>
            {
                entity.ToTable("chara_type");

                entity.HasIndex(e => new { e.TargetScene, e.TargetCut }, "chara_type_0_target_scene_1_target_cut");

                entity.Property(e => e.Id)
                    .HasMaxLength(450)
                    .HasColumnName("id")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.TargetCut)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_cut");

                entity.Property(e => e.TargetScene)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_scene");

                entity.Property(e => e.TargetType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type");

                entity.Property(e => e.Value)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CharacterPropAnimation>(entity =>
            {
                entity.ToTable("character_prop_animation");

                entity.HasIndex(e => new { e.PropId, e.SceneType }, "character_prop_animation_0_prop_id_1_scene_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.LayerIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("layer_index");

                entity.Property(e => e.PropAnimId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_anim_id");

                entity.Property(e => e.PropId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_id");

                entity.Property(e => e.SceneType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scene_type");

                entity.Property(e => e.UseStateName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("use_state_name")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<CharacterSystemLottery>(entity =>
            {
                entity.ToTable("character_system_lottery");

                entity.HasIndex(e => e.CharaId, "character_system_lottery_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.Trigger }, "character_system_lottery_0_chara_id_1_trigger");

                entity.HasIndex(e => new { e.Trigger, e.Param1 }, "character_system_lottery_0_trigger_1_param1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CardRarityId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_rarity_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Param1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("param1");

                entity.Property(e => e.Per)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("per");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.SysTextId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sys_text_id");

                entity.Property(e => e.Trigger)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger");
            });

            modelBuilder.Entity<CharacterSystemText>(entity =>
            {
                entity.HasKey(e => new { e.CharacterId, e.VoiceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_system_text");

                entity.HasIndex(e => e.CharacterId, "character_system_text_0_character_id");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");

                entity.Property(e => e.VoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_id");

                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CueId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cue_id");

                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_sheet")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Gender)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gender");

                entity.Property(e => e.LipSyncData)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("lip_sync_data")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MotionSecondSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_second_set");

                entity.Property(e => e.MotionSecondStart)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_second_start");

                entity.Property(e => e.MotionSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_set");

                entity.Property(e => e.Scene)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scene");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UseGallery)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_gallery");
            });

            modelBuilder.Entity<CircleRankData>(entity =>
            {
                entity.ToTable("circle_rank_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NeedRankingMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_ranking_max");

                entity.Property(e => e.NeedRankingMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_ranking_min");

                entity.Property(e => e.RewardItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_category_1");

                entity.Property(e => e.RewardItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_category_2");

                entity.Property(e => e.RewardItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_id_1");

                entity.Property(e => e.RewardItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_id_2");

                entity.Property(e => e.RewardNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_num_2");
            });

            modelBuilder.Entity<CircleStampData>(entity =>
            {
                entity.ToTable("circle_stamp_data");

                entity.HasIndex(e => e.DispOrder, "circle_stamp_data_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CraneGameArmSwing>(entity =>
            {
                entity.HasKey(e => e.ResultType)
                    .HasName("PRIMARY");

                entity.ToTable("crane_game_arm_swing");

                entity.Property(e => e.ResultType)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("result_type");

                entity.Property(e => e.Odds1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_1");

                entity.Property(e => e.Odds2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_2");

                entity.Property(e => e.Odds3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_3");
            });

            modelBuilder.Entity<CraneGameCatchResult>(entity =>
            {
                entity.HasKey(e => new { e.OddsId, e.GetNum })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("crane_game_catch_result");

                entity.Property(e => e.OddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds_id");

                entity.Property(e => e.GetNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("get_num");

                entity.Property(e => e.LotteryWeight11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_1_1");

                entity.Property(e => e.LotteryWeight12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_1_2");

                entity.Property(e => e.LotteryWeight21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_2_1");

                entity.Property(e => e.LotteryWeight22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_2_2");

                entity.Property(e => e.LotteryWeight31)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_3_1");

                entity.Property(e => e.LotteryWeight32)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_3_2");

                entity.Property(e => e.LotteryWeightExtra1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_extra_1");

                entity.Property(e => e.LotteryWeightExtra2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lottery_weight_extra_2");
            });

            modelBuilder.Entity<CraneGameDefineParam>(entity =>
            {
                entity.ToTable("crane_game_define_param");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Distance1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("distance1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Distance2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("distance2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MoveSpeed1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("move_speed_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MoveSpeed2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("move_speed_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MoveSpeed3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("move_speed_3")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<CraneGameExtraOddsCondition>(entity =>
            {
                entity.HasKey(e => e.Credit)
                    .HasName("PRIMARY");

                entity.ToTable("crane_game_extra_odds_condition");

                entity.Property(e => e.Credit)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("credit");

                entity.Property(e => e.GetNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("get_num");
            });

            modelBuilder.Entity<CraneGameHiddenOdd>(entity =>
            {
                entity.ToTable("crane_game_hidden_odds");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AnimationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("animation_id");

                entity.Property(e => e.Big)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("big");

                entity.Property(e => e.BigIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("big_index");

                entity.Property(e => e.CraneAnimationId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("crane_animation_id");

                entity.Property(e => e.JointType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("joint_type");

                entity.Property(e => e.LiftType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lift_type");

                entity.Property(e => e.Num)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("num");

                entity.Property(e => e.Odds1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_1");

                entity.Property(e => e.Odds2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_2");

                entity.Property(e => e.Odds3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_3");

                entity.Property(e => e.OddsExtra)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_extra");

                entity.Property(e => e.PushType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("push_type");

                entity.Property(e => e.RareEffectOdds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rare_effect_odds");

                entity.Property(e => e.TypeId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_id");
            });

            modelBuilder.Entity<CraneGamePrizeFace>(entity =>
            {
                entity.ToTable("crane_game_prize_face");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("face_type")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<CraneGamePrizePattern>(entity =>
            {
                entity.ToTable("crane_game_prize_pattern");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PropPatternId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_pattern_id");
            });

            modelBuilder.Entity<CraneGameProp>(entity =>
            {
                entity.HasKey(e => e.Type)
                    .HasName("PRIMARY");

                entity.ToTable("crane_game_prop");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("type");

                entity.Property(e => e.Num)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("num");
            });

            modelBuilder.Entity<DailyPack>(entity =>
            {
                entity.HasKey(e => new { e.ShopDataId, e.PlatformId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("daily_pack");

                entity.HasIndex(e => e.GroupId, "daily_pack_0_group_id");

                entity.Property(e => e.ShopDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("shop_data_id");

                entity.Property(e => e.PlatformId)
                    .HasColumnType("int(11)")
                    .HasColumnName("platform_id");

                entity.Property(e => e.DailyFreeNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("daily_free_num");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.RepurchaseDay)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("repurchase_day");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Term)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("term");
            });

            modelBuilder.Entity<DailyRace>(entity =>
            {
                entity.ToTable("daily_race");

                entity.HasIndex(e => e.RaceInstanceId, "daily_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CostNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_num");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("difficulty");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_1");

                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_2");

                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_3");

                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_1");

                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_2");

                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_3");

                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_1");

                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_2");

                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_3");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.NormalRewardsOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("normal_rewards_odds_id");

                entity.Property(e => e.PickUpItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_1");

                entity.Property(e => e.PickUpItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_2");

                entity.Property(e => e.PickUpItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_3");

                entity.Property(e => e.PickUpItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_1");

                entity.Property(e => e.PickUpItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_2");

                entity.Property(e => e.PickUpItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_3");

                entity.Property(e => e.PickUpItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_1");

                entity.Property(e => e.PickUpItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_2");

                entity.Property(e => e.PickUpItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_3");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RareRewardOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rare_reward_odds_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.UniqueCharaNpcMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unique_chara_npc_max");

                entity.Property(e => e.UniqueCharaNpcMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unique_chara_npc_min");
            });

            modelBuilder.Entity<DailyRaceBilling>(entity =>
            {
                entity.ToTable("daily_race_billing");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Frequency)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("frequency");

                entity.Property(e => e.PayCost)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pay_cost");
            });

            modelBuilder.Entity<DailyRaceNpc>(entity =>
            {
                entity.ToTable("daily_race_npc");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.MobId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mob_id");

                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("npc_group_id");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<Directory>(entity =>
            {
                entity.ToTable("directory");

                entity.HasIndex(e => e.RankLevel, "directory_0_rank_level")
                    .IsUnique();

                entity.HasIndex(e => e.RequiredPoint, "directory_0_required_point");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_1");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_1");

                entity.Property(e => e.ItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_1");

                entity.Property(e => e.RankLevel)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank_level");

                entity.Property(e => e.RequiredPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("required_point");
            });

            modelBuilder.Entity<DressData>(entity =>
            {
                entity.ToTable("dress_data");

                entity.HasIndex(e => e.BodyType, "dress_data_0_body_type");

                entity.HasIndex(e => e.CharaId, "dress_data_0_chara_id");

                entity.HasIndex(e => e.ConditionType, "dress_data_0_condition_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BodySetting)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_setting");

                entity.Property(e => e.BodyType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_type");

                entity.Property(e => e.BodyTypeSub)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_type_sub");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.ColorNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("color_num");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.DressColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_main")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DressColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_sub")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EndTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_time");

                entity.Property(e => e.HaveMini)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("have_mini");

                entity.Property(e => e.HeadSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("head_sub_id");

                entity.Property(e => e.IsDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_dirt");

                entity.Property(e => e.IsWet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_wet");

                entity.Property(e => e.StartTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_time");

                entity.Property(e => e.TailModelId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_model_id");

                entity.Property(e => e.TailModelSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_model_sub_id");

                entity.Property(e => e.UseGender)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_gender");

                entity.Property(e => e.UseHome)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_home");

                entity.Property(e => e.UseLive)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_live");

                entity.Property(e => e.UseLiveTheater)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_live_theater");

                entity.Property(e => e.UseRace)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_race");

                entity.Property(e => e.UseSeason)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_season");
            });

            modelBuilder.Entity<EventMotionData>(entity =>
            {
                entity.ToTable("event_motion_data");

                entity.HasIndex(e => e.Type, "event_motion_data_0_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseStateName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("base_state_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Category)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("category");

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("command_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EndBlendTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_blend_time");

                entity.Property(e => e.PoseBlend)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pose_blend");

                entity.Property(e => e.StartBlendTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_blend_time");

                entity.Property(e => e.StateGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("state_group");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<EventMotionPlusData>(entity =>
            {
                entity.ToTable("event_motion_plus_data");

                entity.HasIndex(e => e.BaseStateName, "event_motion_plus_data_0_base_state_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 768 });

                entity.HasIndex(e => e.LayerIndex, "event_motion_plus_data_0_layer_index");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseStateName)
                    .IsRequired()
                    .HasMaxLength(900)
                    .HasColumnName("base_state_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("command_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EndBlendTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_blend_time");

                entity.Property(e => e.LayerIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("layer_index");

                entity.Property(e => e.StartBlendTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_blend_time");

                entity.Property(e => e.TailMotionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_motion_type");
            });

            modelBuilder.Entity<FaceTypeData>(entity =>
            {
                entity.HasKey(e => e.Label)
                    .HasName("PRIMARY");

                entity.ToTable("face_type_data");

                entity.Property(e => e.Label)
                    .HasMaxLength(450)
                    .HasColumnName("label")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeL)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_l")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeR)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_r")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyebrowL)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eyebrow_l")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyebrowR)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eyebrow_r")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.InverceFaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("inverce_face_type")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Mouth)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mouth")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MouthShapeType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mouth_shape_type");

                entity.Property(e => e.SetFaceGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("set_face_group");
            });

            modelBuilder.Entity<FacialMouthChange>(entity =>
            {
                entity.ToTable("facial_mouth_change");

                entity.HasIndex(e => e.CharaId, "facial_mouth_change_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.BeforeFacialname }, "facial_mouth_change_0_chara_id_1_before_facialname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AfterFacialname)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("after_facialname")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BeforeFacialname)
                    .IsRequired()
                    .HasMaxLength(900)
                    .HasColumnName("before_facialname")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");
            });

            modelBuilder.Entity<GachaAvailable>(entity =>
            {
                entity.HasKey(e => new { e.GachaId, e.CardId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gacha_available");

                entity.HasIndex(e => e.GachaId, "gacha_available_0_gacha_id");

                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_type");

                entity.Property(e => e.IsPickup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_pickup");

                entity.Property(e => e.IsPrizeSelectable)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_prize_selectable");

                entity.Property(e => e.Odds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.RecommendOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("recommend_order");
            });

            modelBuilder.Entity<GachaData>(entity =>
            {
                entity.ToTable("gacha_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalPieceNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_num_1");

                entity.Property(e => e.AdditionalPieceNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_num_2");

                entity.Property(e => e.AdditionalPieceNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_num_3");

                entity.Property(e => e.AdditionalPieceNum4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_num_4");

                entity.Property(e => e.AdditionalPieceNum5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_num_5");

                entity.Property(e => e.AdditionalPieceNum6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_num_6");

                entity.Property(e => e.AdditionalPieceTargetCardId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_id_1");

                entity.Property(e => e.AdditionalPieceTargetCardId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_id_2");

                entity.Property(e => e.AdditionalPieceTargetCardId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_id_3");

                entity.Property(e => e.AdditionalPieceTargetCardId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_id_4");

                entity.Property(e => e.AdditionalPieceTargetCardId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_id_5");

                entity.Property(e => e.AdditionalPieceTargetCardId6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_id_6");

                entity.Property(e => e.AdditionalPieceTargetCardType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_type_1");

                entity.Property(e => e.AdditionalPieceTargetCardType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_type_2");

                entity.Property(e => e.AdditionalPieceTargetCardType3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_type_3");

                entity.Property(e => e.AdditionalPieceTargetCardType4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_type_4");

                entity.Property(e => e.AdditionalPieceTargetCardType5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_type_5");

                entity.Property(e => e.AdditionalPieceTargetCardType6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_card_type_6");

                entity.Property(e => e.AdditionalPieceTargetRarity1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_rarity_1");

                entity.Property(e => e.AdditionalPieceTargetRarity2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_rarity_2");

                entity.Property(e => e.AdditionalPieceTargetRarity3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_rarity_3");

                entity.Property(e => e.AdditionalPieceTargetRarity4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_rarity_4");

                entity.Property(e => e.AdditionalPieceTargetRarity5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_rarity_5");

                entity.Property(e => e.AdditionalPieceTargetRarity6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_target_rarity_6");

                entity.Property(e => e.BonusItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_item_category_1");

                entity.Property(e => e.BonusItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_item_category_2");

                entity.Property(e => e.BonusItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_item_id_1");

                entity.Property(e => e.BonusItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_item_id_2");

                entity.Property(e => e.BonusItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_item_num_1");

                entity.Property(e => e.BonusItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_item_num_2");

                entity.Property(e => e.BonusTargetDrawNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_target_draw_num");

                entity.Property(e => e.CardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_type");

                entity.Property(e => e.CostSingle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_single");

                entity.Property(e => e.CostType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_type");

                entity.Property(e => e.DailyPayCost)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("daily_pay_cost");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.DrawGuaranteeNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("draw_guarantee_num");

                entity.Property(e => e.DrawGuaranteeRarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("draw_guarantee_rarity");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.OnlyOnceFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("only_once_flag");

                entity.Property(e => e.PrizeOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prize_odds_id");

                entity.Property(e => e.RarityOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity_odds_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<GachaExchange>(entity =>
            {
                entity.HasKey(e => new { e.GachaId, e.CardId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gacha_exchange");

                entity.HasIndex(e => e.GachaId, "gacha_exchange_0_gacha_id");

                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_type");

                entity.Property(e => e.PayItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pay_item_num");
            });

            modelBuilder.Entity<GachaFreeCampaign>(entity =>
            {
                entity.ToTable("gacha_free_campaign");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.GachaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gacha_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.TargetDrawType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_draw_type");
            });

            modelBuilder.Entity<GachaPiece>(entity =>
            {
                entity.ToTable("gacha_piece");

                entity.HasIndex(e => e.Rarity, "gacha_piece_0_rarity");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.PieceNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("piece_num");

                entity.Property(e => e.PieceType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("piece_type");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");
            });

            modelBuilder.Entity<GachaPrizeOdd>(entity =>
            {
                entity.HasKey(e => new { e.PrizeOddsId, e.Place })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gacha_prize_odds");

                entity.HasIndex(e => e.PrizeOddsId, "gacha_prize_odds_0_prize_odds_id");

                entity.Property(e => e.PrizeOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_odds_id");

                entity.Property(e => e.Place)
                    .HasColumnType("int(11)")
                    .HasColumnName("place");

                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_1");

                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_2");

                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_3");

                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_4");

                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_5");

                entity.Property(e => e.ItemCategory6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_6");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_6");

                entity.Property(e => e.ItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_5");

                entity.Property(e => e.ItemNum6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_6");

                entity.Property(e => e.Odds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds");

                entity.Property(e => e.PieceNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("piece_num");
            });

            modelBuilder.Entity<GachaStockCampaign>(entity =>
            {
                entity.ToTable("gacha_stock_campaign");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<GachaStockDetail>(entity =>
            {
                entity.ToTable("gacha_stock_detail");

                entity.HasIndex(e => e.GachaStockId, "gacha_stock_detail_0_gacha_stock_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.GachaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gacha_id");

                entity.Property(e => e.GachaStockId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gacha_stock_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<GachaTopBg>(entity =>
            {
                entity.ToTable("gacha_top_bg");

                entity.HasIndex(e => e.GachaId, "gacha_top_bg_0_gacha_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GachaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gacha_id");
            });

            modelBuilder.Entity<GiftMessage>(entity =>
            {
                entity.ToTable("gift_message");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Type1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_1");

                entity.Property(e => e.Type2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_2");

                entity.Property(e => e.Type3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_3");

                entity.Property(e => e.Type4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_4");
            });

            modelBuilder.Entity<HighlightInterpolate>(entity =>
            {
                entity.ToTable("highlight_interpolate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.InTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("in_time");

                entity.Property(e => e.OutTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("out_time");
            });

            modelBuilder.Entity<HomeCharacterType>(entity =>
            {
                entity.HasKey(e => new { e.PosId, e.OriginalPersonality })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("home_character_type");

                entity.Property(e => e.PosId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_id");

                entity.Property(e => e.OriginalPersonality)
                    .HasColumnType("int(11)")
                    .HasColumnName("original_personality");

                entity.Property(e => e.ChangePersonality)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("change_personality");
            });

            modelBuilder.Entity<HomeEnvSetting>(entity =>
            {
                entity.ToTable("home_env_setting");

                entity.HasIndex(e => new { e.HomeSetId, e.HomeEventType, e.Season, e.Weather, e.Timezone }, "home_env_setting_0")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HomeEventType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("home_event_type");

                entity.Property(e => e.HomeSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("home_set_id");

                entity.Property(e => e.Resource)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource");

                entity.Property(e => e.ResourceEventCheck)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource_event_check");

                entity.Property(e => e.Season)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("season");

                entity.Property(e => e.Timezone)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("timezone");

                entity.Property(e => e.Weather)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<HomeEventSchedule>(entity =>
            {
                entity.ToTable("home_event_schedule");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.EventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<HomePosterData>(entity =>
            {
                entity.ToTable("home_poster_data");

                entity.HasIndex(e => e.Priority, "home_poster_data_0_priority");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DetailValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("detail_value");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.Height)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("height");

                entity.Property(e => e.PosiHorizontal)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("posi_horizontal");

                entity.Property(e => e.PosiVertical)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("posi_vertical");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("url")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UrlValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("url_value");

                entity.Property(e => e.Width)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<HomePropSetting>(entity =>
            {
                entity.HasKey(e => new { e.PosId, e.Personality })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("home_prop_setting");

                entity.Property(e => e.PosId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_id");

                entity.Property(e => e.Personality)
                    .HasColumnType("int(11)")
                    .HasColumnName("personality");

                entity.Property(e => e.AttachNode)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("attach_node");

                entity.Property(e => e.PropId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_id");
            });

            modelBuilder.Entity<HomeStoryTrigger>(entity =>
            {
                entity.ToTable("home_story_trigger");

                entity.HasIndex(e => new { e.HomeEventType, e.StoryId }, "home_story_trigger_0_home_event_type_1_story_id");

                entity.HasIndex(e => e.PosId, "home_story_trigger_0_pos_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_3");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.HomeEventType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("home_event_type");

                entity.Property(e => e.Num)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("num");

                entity.Property(e => e.PosId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_id");

                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<HomeWalkGroup>(entity =>
            {
                entity.ToTable("home_walk_group");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_3");
            });

            modelBuilder.Entity<HomeStoryHipOffset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("homestory_hip_offset");

                entity.HasIndex(e => new { e.StoryId, e.CharaId }, "homestory_hip_offset_0_story_id_1_chara_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.HomeEventType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("home_event_type");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Num)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("num");

                entity.Property(e => e.Offset)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset");

                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<HonorData>(entity =>
            {
                entity.ToTable("honor_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("category");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Rank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.StepGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("step_group_id");

                entity.Property(e => e.StepOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("step_order");
            });

            modelBuilder.Entity<ItemData>(entity =>
            {
                entity.ToTable("item_data");

                entity.HasIndex(e => e.GroupId, "item_data_0_group_id");

                entity.HasIndex(e => e.ItemCategory, "item_data_0_item_category");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_value_1");

                entity.Property(e => e.AddValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_value_2");

                entity.Property(e => e.AddValue3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_value_3");

                entity.Property(e => e.EffectTarget1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_target_1");

                entity.Property(e => e.EffectTarget2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_target_2");

                entity.Property(e => e.EffectType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_type_1");

                entity.Property(e => e.EffectType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_type_2");

                entity.Property(e => e.EffectValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_value_1");

                entity.Property(e => e.EffectValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_value_2");

                entity.Property(e => e.EnableRequest)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enable_request");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_place_id");

                entity.Property(e => e.LimitNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_num");

                entity.Property(e => e.Rare)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rare");

                entity.Property(e => e.RequestReward)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("request_reward");

                entity.Property(e => e.Sort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<ItemExchange>(entity =>
            {
                entity.ToTable("item_exchange");

                entity.HasIndex(e => e.ItemExchangeTopId, "item_exchange_0_item_exchange_top_id");

                entity.HasIndex(e => e.PayItemId, "item_exchange_0_pay_item_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalPieceNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("additional_piece_num");

                entity.Property(e => e.ChangeItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("change_item_category");

                entity.Property(e => e.ChangeItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("change_item_id");

                entity.Property(e => e.ChangeItemLimitNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("change_item_limit_num");

                entity.Property(e => e.ChangeItemLimitType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("change_item_limit_type");

                entity.Property(e => e.ChangeItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("change_item_num");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_exchange_top_id");

                entity.Property(e => e.PayItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pay_item_category");

                entity.Property(e => e.PayItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pay_item_id");

                entity.Property(e => e.PayItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pay_item_num");

                entity.Property(e => e.PriceChangeGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("price_change_group_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ItemExchangeTop>(entity =>
            {
                entity.ToTable("item_exchange_top");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemExchangeDispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_exchange_disp_order");
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.ToTable("item_group");

                entity.HasIndex(e => e.GroupId, "item_group_0_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<ItemPack>(entity =>
            {
                entity.ToTable("item_pack");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.ItemPackId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_pack_id");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<ItemPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_place");

                entity.HasIndex(e => e.Id, "item_place_0_id");

                entity.HasIndex(e => new { e.Id, e.TransitionType, e.TransitionValue }, "item_place_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.TransitionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transition_type");

                entity.Property(e => e.TransitionValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transition_value");
            });

            modelBuilder.Entity<JukeboxCharaTagData>(entity =>
            {
                entity.ToTable("jukebox_chara_tag_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.Tag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<JukeboxComment>(entity =>
            {
                entity.ToTable("jukebox_comment");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CommentId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("comment_id");

                entity.Property(e => e.CommentType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("comment_type");

                entity.Property(e => e.VariationType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("variation_type");

                entity.Property(e => e.VariationValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("variation_value");
            });

            modelBuilder.Entity<JukeboxMotionData>(entity =>
            {
                entity.ToTable("jukebox_motion_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MotionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_id");

                entity.Property(e => e.SongType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("song_type");
            });

            modelBuilder.Entity<JukeboxMusicData>(entity =>
            {
                entity.HasKey(e => e.MusicId)
                    .HasName("PRIMARY");

                entity.ToTable("jukebox_music_data");

                entity.HasIndex(e => e.Sort, "sort")
                    .IsUnique();

                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("music_id");

                entity.Property(e => e.BgmCueNameGamesize)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_gamesize");

                entity.Property(e => e.BgmCueNameShort)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_short");

                entity.Property(e => e.BgmCuesheetNameGamesize)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_gamesize");

                entity.Property(e => e.BgmCuesheetNameShort)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_short");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.IsHidden)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_hidden");

                entity.Property(e => e.LampAnimation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lamp_animation");

                entity.Property(e => e.LampColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lamp_color");

                entity.Property(e => e.NameTextureLength)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("name_texture_length");

                entity.Property(e => e.RequestType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("request_type");

                entity.Property(e => e.ShortLength)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("short_length");

                entity.Property(e => e.SongType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("song_type");

                entity.Property(e => e.Sort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.VersionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("version_type");
            });

            modelBuilder.Entity<JukeboxReactionData>(entity =>
            {
                entity.ToTable("jukebox_reaction_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.ReactionCharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reaction_chara_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<JukeboxRequestData>(entity =>
            {
                entity.ToTable("jukebox_request_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.MusicId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("music_id");

                entity.Property(e => e.RequestType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("request_type");

                entity.Property(e => e.RequestValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("request_value");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<LegendRace>(entity =>
            {
                entity.ToTable("legend_race");

                entity.HasIndex(e => e.GroupId, "legend_race_0_group_id");

                entity.HasIndex(e => e.RaceInstanceId, "legend_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CostNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_num");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("difficulty");

                entity.Property(e => e.DropRewardOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("drop_reward_odds_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_1");

                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_2");

                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_category_3");

                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_1");

                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_2");

                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_id_3");

                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_1");

                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_2");

                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_clear_item_num_3");

                entity.Property(e => e.Ground)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ground");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.ImageId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("image_id");

                entity.Property(e => e.LegendBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("legend_bg_id");

                entity.Property(e => e.LegendBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("legend_bg_sub_id");

                entity.Property(e => e.LegendRaceBossNpcId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("legend_race_boss_npc_id");

                entity.Property(e => e.NoticeDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_date");

                entity.Property(e => e.PickUpItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_1");

                entity.Property(e => e.PickUpItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_2");

                entity.Property(e => e.PickUpItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_category_3");

                entity.Property(e => e.PickUpItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_1");

                entity.Property(e => e.PickUpItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_2");

                entity.Property(e => e.PickUpItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_id_3");

                entity.Property(e => e.PickUpItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_1");

                entity.Property(e => e.PickUpItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_2");

                entity.Property(e => e.PickUpItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pick_up_item_num_3");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.Season)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("season");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.VictoryRewardOddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("victory_reward_odds_id");

                entity.Property(e => e.Weather)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<LegendRaceBilling>(entity =>
            {
                entity.ToTable("legend_race_billing");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Frequency)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("frequency");

                entity.Property(e => e.PayCost)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pay_cost");
            });

            modelBuilder.Entity<LegendRaceBossNpc>(entity =>
            {
                entity.ToTable("legend_race_boss_npc");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardRarityDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_rarity_data_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.NicknameId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("nickname_id");

                entity.Property(e => e.Post)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("post");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<LegendRaceNpc>(entity =>
            {
                entity.ToTable("legend_race_npc");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.MobId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mob_id");

                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("npc_group_id");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<LimitedExchange>(entity =>
            {
                entity.ToTable("limited_exchange");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DailyRaceCeiling)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("daily_race_ceiling");

                entity.Property(e => e.DailyRaceOdds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("daily_race_odds");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_exchange_top_id");

                entity.Property(e => e.ItemLineupValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_lineup_value");

                entity.Property(e => e.LegendRaceCeiling)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("legend_race_ceiling");

                entity.Property(e => e.LegendRaceOdds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("legend_race_odds");

                entity.Property(e => e.OddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_id");

                entity.Property(e => e.OpenValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("open_value");

                entity.Property(e => e.SingleModeCeiling)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_mode_ceiling");

                entity.Property(e => e.SingleModeOdds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_mode_odds");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.TeamStadiumCeiling)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_stadium_ceiling");

                entity.Property(e => e.TeamStadiumOdds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_stadium_odds");
            });

            modelBuilder.Entity<LimitedExchangeReward>(entity =>
            {
                entity.ToTable("limited_exchange_reward");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.ItemExchangeId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_exchange_id");

                entity.Property(e => e.Odds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds");

                entity.Property(e => e.RibbonValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ribbon_value");
            });

            modelBuilder.Entity<LimitedExchangeRewardOdd>(entity =>
            {
                entity.ToTable("limited_exchange_reward_odds");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Odds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds");

                entity.Property(e => e.OddsId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds_id");
            });

            modelBuilder.Entity<LiveData>(entity =>
            {
                entity.HasKey(e => e.MusicId)
                    .HasName("PRIMARY");

                entity.ToTable("live_data");

                entity.HasIndex(e => e.Sort, "live_data_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("music_id");

                entity.Property(e => e.BackdancerDress)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("backdancer_dress");

                entity.Property(e => e.BackdancerDressColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("backdancer_dress_color");

                entity.Property(e => e.BackdancerOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("backdancer_order");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.DefaultMainDress)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_main_dress");

                entity.Property(e => e.DefaultMainDressColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_main_dress_color");

                entity.Property(e => e.DefaultMobDress)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_mob_dress");

                entity.Property(e => e.DefaultMobDressColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_mob_dress_color");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.LiveMemberNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("live_member_number");

                entity.Property(e => e.MusicType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("music_type");

                entity.Property(e => e.SongCharaType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("song_chara_type");

                entity.Property(e => e.Sort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.TitleColorBottom)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("title_color_bottom")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TitleColorTop)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("title_color_top")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<LivePermissionData>(entity =>
            {
                entity.HasKey(e => new { e.MusicId, e.CharaId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("live_permission_data");

                entity.HasIndex(e => e.MusicId, "live_permission_data_0_music_id");

                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
            });

            modelBuilder.Entity<LoginBonusData>(entity =>
            {
                entity.ToTable("login_bonus_data");

                entity.HasIndex(e => e.Type, "login_bonus_data_0_type");

                entity.HasIndex(e => e.DispOrder, "login_bonus_data_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CountNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("count_num");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<LoginBonusDetail>(entity =>
            {
                entity.ToTable("login_bonus_detail");

                entity.HasIndex(e => e.LoginBonusId, "login_bonus_detail_0_login_bonus_id");

                entity.HasIndex(e => new { e.LoginBonusId, e.Count }, "login_bonus_detail_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("count");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.LoginBonusId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("login_bonus_id");
            });

            modelBuilder.Entity<LoveRank>(entity =>
            {
                entity.ToTable("love_rank");

                entity.HasIndex(e => e.Rank, "love_rank_0_rank")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Rank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank");

                entity.Property(e => e.TotalPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_point");
            });

            modelBuilder.Entity<MainStoryData>(entity =>
            {
                entity.ToTable("main_story_data");

                entity.HasIndex(e => e.PartId, "main_story_data_0_part_id");

                entity.HasIndex(e => e.StoryId1, "main_story_data_0_story_id_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_category_1");

                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_id_1");

                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_num_1");

                entity.Property(e => e.EpisodeIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("episode_index");

                entity.Property(e => e.LockType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_type_1");

                entity.Property(e => e.LockType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_type_2");

                entity.Property(e => e.LockType3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_type_3");

                entity.Property(e => e.LockValue11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_1_1");

                entity.Property(e => e.LockValue12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_1_2");

                entity.Property(e => e.LockValue21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_2_1");

                entity.Property(e => e.LockValue22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_2_2");

                entity.Property(e => e.LockValue31)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_3_1");

                entity.Property(e => e.LockValue32)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value_3_2");

                entity.Property(e => e.PartId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("part_id");

                entity.Property(e => e.StoryId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_1");

                entity.Property(e => e.StoryId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_2");

                entity.Property(e => e.StoryId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_3");

                entity.Property(e => e.StoryId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_4");

                entity.Property(e => e.StoryId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_5");

                entity.Property(e => e.StoryNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_number");

                entity.Property(e => e.StoryType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_1");

                entity.Property(e => e.StoryType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_2");

                entity.Property(e => e.StoryType3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_3");

                entity.Property(e => e.StoryType4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_4");

                entity.Property(e => e.StoryType5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_5");
            });

            modelBuilder.Entity<MainStoryPart>(entity =>
            {
                entity.ToTable("main_story_part");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MainStoryLastChapter)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("main_story_last_chapter");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.UiColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<MainStoryRaceBonus>(entity =>
            {
                entity.ToTable("main_story_race_bonus");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_type");

                entity.Property(e => e.BonusValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_value");

                entity.Property(e => e.ConditionGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_group");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<MainStoryRaceBonusCondition>(entity =>
            {
                entity.ToTable("main_story_race_bonus_condition");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<MainStoryRaceCharaData>(entity =>
            {
                entity.ToTable("main_story_race_chara_data");

                entity.HasIndex(e => e.GroupId, "main_story_race_chara_data_0_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BracketNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bracket_number");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.MobId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mob_id");

                entity.Property(e => e.Motivation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motivation");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RunningStyle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("running_style");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<MainStoryRaceData>(entity =>
            {
                entity.ToTable("main_story_race_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusChara1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_chara_1");

                entity.Property(e => e.BonusChara2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_chara_2");

                entity.Property(e => e.BonusChara3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_chara_3");

                entity.Property(e => e.ClearRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("clear_rank");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.RaceConditionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_condition_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<MiniBg>(entity =>
            {
                entity.ToTable("mini_bg");

                entity.HasIndex(e => e.SceneType, "mini_bg_0_scene_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.GridOffsetX)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("grid_offset_x")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GridOffsetY)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("grid_offset_y")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("position")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ReleaseNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("release_num");

                entity.Property(e => e.SceneType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scene_type");

                entity.Property(e => e.SizeX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("size_x");

                entity.Property(e => e.SizeY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("size_y");
            });

            modelBuilder.Entity<MiniBgCharaMotion>(entity =>
            {
                entity.ToTable("mini_bg_chara_motion");

                entity.HasIndex(e => e.BgId, "mini_bg_chara_motion_0_bg_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_id");

                entity.Property(e => e.CharaPosY)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chara_pos_y")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CharaShadow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_shadow");

                entity.Property(e => e.Direction)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("direction");

                entity.Property(e => e.EffectId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_id");

                entity.Property(e => e.EffectStartSec)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("effect_start_sec")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FixedRenderOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fixed_render_order");

                entity.Property(e => e.GridPosX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grid_pos_x");

                entity.Property(e => e.GridPosY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grid_pos_y");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.IsMob)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_mob");

                entity.Property(e => e.MainCharaNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("main_chara_num");

                entity.Property(e => e.MotionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("motion_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PosObj)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("pos_obj")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PositionAnim)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("position_anim")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PositionFile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("position_file")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.SeCueName01)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name01")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SeCueName02)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name02")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SeCueSheet01)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_sheet01")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SeCueSheet02)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_sheet02")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SeStartFrame01)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("se_start_frame01");

                entity.Property(e => e.SeStartFrame02)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("se_start_frame02");

                entity.Property(e => e.SubGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_group_id");

                entity.Property(e => e.Timeline)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("timeline")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TimelineActor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("timeline_actor")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UseGridPosJobSelect)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_grid_pos_job_select");
            });

            modelBuilder.Entity<MiniFaceTypeData>(entity =>
            {
                entity.HasKey(e => e.Label)
                    .HasName("PRIMARY");

                entity.ToTable("mini_face_type_data");

                entity.Property(e => e.Label)
                    .HasMaxLength(450)
                    .HasColumnName("label")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Cheek)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cheek");

                entity.Property(e => e.EyeL)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("eye_l");

                entity.Property(e => e.EyeR)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("eye_r");

                entity.Property(e => e.EyebrowL)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("eyebrow_l");

                entity.Property(e => e.EyebrowR)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("eyebrow_r");

                entity.Property(e => e.Mouth)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mouth");
            });

            modelBuilder.Entity<MiniMotionSet>(entity =>
            {
                entity.HasKey(e => e.Label)
                    .HasName("PRIMARY");

                entity.ToTable("mini_motion_set");

                entity.HasIndex(e => e.Id, "mini_motion_set_0_id");

                entity.Property(e => e.Label)
                    .HasMaxLength(450)
                    .HasColumnName("label")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AddLayerIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_layer_index");

                entity.Property(e => e.BodyMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("body_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BodyMotionPlayType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_motion_play_type");

                entity.Property(e => e.BodyMotionSceneType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_motion_scene_type");

                entity.Property(e => e.BodyMotionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("body_motion_type");

                entity.Property(e => e.CharaFaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chara_face_type")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CharaTypeTarget)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_target");

                entity.Property(e => e.EarMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ear_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FacialMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("facial_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.IsEnableRandomeEar)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_enable_randome_ear");

                entity.Property(e => e.IsEnableRandomeTail)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_enable_randome_tail");

                entity.Property(e => e.IsMirror)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_mirror");

                entity.Property(e => e.IsPropRequireMotionEnd)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_prop_require_motion_end");

                entity.Property(e => e.PropAttachNodeNameType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_attach_node_name_type");

                entity.Property(e => e.PropId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_id");

                entity.Property(e => e.PropMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("prop_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PropMotionSceneType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_motion_scene_type");

                entity.Property(e => e.SceneSubFolder)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("scene_sub_folder")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_motion")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailMotionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_motion_type");

                entity.Property(e => e.TransitionTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transition_time");
            });

            modelBuilder.Entity<MiniMouthType>(entity =>
            {
                entity.ToTable("mini_mouth_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ReverseMouthId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reverse_mouth_id");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<MissionData>(entity =>
            {
                entity.ToTable("mission_data");

                entity.HasIndex(e => e.MissionType, "mission_data_0_mission_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_num");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_4");

                entity.Property(e => e.DateCheckFlg)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("date_check_flg");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.MissionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mission_type");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.StepGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("step_group_id");

                entity.Property(e => e.StepOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("step_order");

                entity.Property(e => e.TransitionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transition_type");
            });

            modelBuilder.Entity<MobData>(entity =>
            {
                entity.HasKey(e => e.MobId)
                    .HasName("PRIMARY");

                entity.ToTable("mob_data");

                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("mob_id");

                entity.Property(e => e.AttachmentModelId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("attachment_model_id");

                entity.Property(e => e.CaptureType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("capture_type");

                entity.Property(e => e.CharaBustSize)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_bust_size");

                entity.Property(e => e.CharaFaceModel)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_face_model");

                entity.Property(e => e.CharaHairColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_hair_color");

                entity.Property(e => e.CharaHairModel)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_hair_model");

                entity.Property(e => e.CharaHeight)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_height");

                entity.Property(e => e.CharaSkinColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_skin_color");

                entity.Property(e => e.DefaultPersonality)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_personality");

                entity.Property(e => e.DressColorId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.HairCutoff)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("hair_cutoff");

                entity.Property(e => e.RacePersonality)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_personality");

                entity.Property(e => e.RaceRunningType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_running_type");

                entity.Property(e => e.Sex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sex");

                entity.Property(e => e.Socks)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("socks");

                entity.Property(e => e.UseLive)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_live");
            });

            modelBuilder.Entity<MobDressColorSet>(entity =>
            {
                entity.ToTable("mob_dress_color_set");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<MobHairColorSet>(entity =>
            {
                entity.ToTable("mob_hair_color_set");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EyeColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EyeColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.HairToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MayuToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_b1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_b2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_g1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_g2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_r1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TailToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_r2")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<NeedPieceNumData>(entity =>
            {
                entity.ToTable("need_piece_num_data");

                entity.HasIndex(e => e.Rarity, "need_piece_num_data_0_rarity")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.PieceNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("piece_num");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");
            });

            modelBuilder.Entity<Nickname>(entity =>
            {
                entity.ToTable("nickname");

                entity.HasIndex(e => e.UserShow, "nickname_0_user_show");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_data_id");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Rank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank");

                entity.Property(e => e.ReceiveConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("receive_condition_type");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.UserShow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_show");
            });

            modelBuilder.Entity<NoteProfile>(entity =>
            {
                entity.ToTable("note_profile");

                entity.HasIndex(e => e.CharaId, "note_profile_0_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.LockType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_type");

                entity.Property(e => e.LockValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lock_value");

                entity.Property(e => e.Sort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort");

                entity.Property(e => e.TextType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("text_type");
            });

            modelBuilder.Entity<NoteProfileTextType>(entity =>
            {
                entity.ToTable("note_profile_text_type");

                entity.HasIndex(e => e.TextType, "note_profile_text_type_0_text_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Sort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort");

                entity.Property(e => e.TextCategoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("text_category_id");

                entity.Property(e => e.TextType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("text_type");
            });

            modelBuilder.Entity<PieceData>(entity =>
            {
                entity.ToTable("piece_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_place_id");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<PriceChange>(entity =>
            {
                entity.ToTable("price_change");

                entity.HasIndex(e => e.GroupId, "price_change_0_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.MaxNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_num");

                entity.Property(e => e.MinNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("min_num");

                entity.Property(e => e.PayItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pay_item_num");
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.ToTable("race");

                entity.HasIndex(e => e.CourseSet, "race_race_0_course_set");

                entity.HasIndex(e => e.Group, "race_race_0_group");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CourseSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_set");

                entity.Property(e => e.EntryNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("entry_num");

                entity.Property(e => e.FfAnim)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ff_anim");

                entity.Property(e => e.FfCamera)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ff_camera");

                entity.Property(e => e.FfCameraSub)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ff_camera_sub");

                entity.Property(e => e.FfCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ff_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FfCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ff_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FfSub)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ff_sub");

                entity.Property(e => e.GoalFlower)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("goal_flower");

                entity.Property(e => e.GoalGate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("goal_gate");

                entity.Property(e => e.Grade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade");

                entity.Property(e => e.Group)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group");

                entity.Property(e => e.ThumbnailId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("thumbnail_id");
            });

            modelBuilder.Entity<RaceBgm>(entity =>
            {
                entity.ToTable("race_bgm");

                entity.HasIndex(e => e.RaceType, "race_bgm_0_race_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EntrytableBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("entrytable_bgm_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EntrytableBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("entrytable_bgm_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FirstBgmPattern)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("first_bgm_pattern");

                entity.Property(e => e.Grade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade");

                entity.Property(e => e.PaddockBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("paddock_bgm_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PaddockBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("paddock_bgm_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_type");

                entity.Property(e => e.ResultCutinBgmCueName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cue_name_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultCutinBgmCueName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cue_name_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultCutinBgmCueName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cue_name_3")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultCutinBgmCuesheetName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cuesheet_name_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultCutinBgmCuesheetName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cuesheet_name_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultCutinBgmCuesheetName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cuesheet_name_3")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultListBgmCueName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cue_name_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultListBgmCueName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cue_name_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultListBgmCueName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cue_name_3")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultListBgmCuesheetName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cuesheet_name_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultListBgmCuesheetName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cuesheet_name_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ResultListBgmCuesheetName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cuesheet_name_3")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SecondBgmPattern)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("second_bgm_pattern");

                entity.Property(e => e.SingleModeProgramId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_mode_program_id");

                entity.Property(e => e.SingleModeRouteRaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_mode_route_race_id");
            });

            modelBuilder.Entity<RaceBgmCutinExtensionTime>(entity =>
            {
                entity.ToTable("race_bgm_cutin_extension_time");

                entity.HasIndex(e => e.CutinCategory, "race_bgm_cutin_extension_time_0_cutin_category");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CutinCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutin_category");

                entity.Property(e => e.ExtensionSec)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("extension_sec");

                entity.Property(e => e.ExtensionSecLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("extension_sec_long");
            });

            modelBuilder.Entity<RaceBgmPattern>(entity =>
            {
                entity.ToTable("race_bgm_pattern");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName10)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_10")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName11)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_11")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName12)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_12")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName13)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_13")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName14)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_14")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName15)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_15")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName16)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_16")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName17)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_17")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName18)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_18")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName19)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_19")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName20)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_20")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName21)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_21")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName22)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_22")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName23)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_23")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName24)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_24")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName25)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_25")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName26)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_26")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName27)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_27")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName28)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_28")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName29)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_29")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_3")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName30)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_30")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName4)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName5)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_5")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName6)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_6")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName7)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_7")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName8)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_8")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCueName9)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_9")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName10)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_10")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName11)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_11")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName12)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_12")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName13)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_13")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName14)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_14")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName15)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_15")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName16)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_16")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName17)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_17")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName18)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_18")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName19)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_19")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName20)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_20")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName21)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_21")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName22)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_22")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName23)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_23")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName24)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_24")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName25)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_25")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName26)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_26")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName27)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_27")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName28)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_28")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName29)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_29")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_3")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName30)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_30")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName4)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName5)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_5")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName6)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_6")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName7)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_7")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName8)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_8")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName9)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_9")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmTime1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_1");

                entity.Property(e => e.BgmTime10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_10");

                entity.Property(e => e.BgmTime11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_11");

                entity.Property(e => e.BgmTime12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_12");

                entity.Property(e => e.BgmTime13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_13");

                entity.Property(e => e.BgmTime14)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_14");

                entity.Property(e => e.BgmTime15)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_15");

                entity.Property(e => e.BgmTime16)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_16");

                entity.Property(e => e.BgmTime17)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_17");

                entity.Property(e => e.BgmTime18)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_18");

                entity.Property(e => e.BgmTime19)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_19");

                entity.Property(e => e.BgmTime2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_2");

                entity.Property(e => e.BgmTime20)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_20");

                entity.Property(e => e.BgmTime21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_21");

                entity.Property(e => e.BgmTime22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_22");

                entity.Property(e => e.BgmTime23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_23");

                entity.Property(e => e.BgmTime24)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_24");

                entity.Property(e => e.BgmTime25)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_25");

                entity.Property(e => e.BgmTime26)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_26");

                entity.Property(e => e.BgmTime27)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_27");

                entity.Property(e => e.BgmTime28)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_28");

                entity.Property(e => e.BgmTime29)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_29");

                entity.Property(e => e.BgmTime3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_3");

                entity.Property(e => e.BgmTime30)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_30");

                entity.Property(e => e.BgmTime4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_4");

                entity.Property(e => e.BgmTime5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_5");

                entity.Property(e => e.BgmTime6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_6");

                entity.Property(e => e.BgmTime7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_7");

                entity.Property(e => e.BgmTime8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_8");

                entity.Property(e => e.BgmTime9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bgm_time_9");
            });

            modelBuilder.Entity<RaceBibColor>(entity =>
            {
                entity.HasKey(e => new { e.Grade, e.RaceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("race_bib_color");

                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");

                entity.Property(e => e.RaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_id");

                entity.Property(e => e.BibColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bib_color");

                entity.Property(e => e.FontColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("font_color");
            });

            modelBuilder.Entity<RaceCondition>(entity =>
            {
                entity.ToTable("race_condition");

                entity.HasIndex(e => new { e.Ground, e.Weather }, "race_condition_0_ground_1_weather");

                entity.HasIndex(e => new { e.Season, e.Ground }, "race_condition_0_season_1_ground");

                entity.HasIndex(e => new { e.Season, e.Weather }, "race_condition_0_season_1_weather");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ground)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ground");

                entity.Property(e => e.Rate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rate");

                entity.Property(e => e.Season)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("season");

                entity.Property(e => e.Weather)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<RaceCourseSet>(entity =>
            {
                entity.ToTable("race_course_set");

                entity.HasIndex(e => e.RaceTrackId, "race_course_set_0_race_track_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CourseSetStatusId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_set_status_id");

                entity.Property(e => e.Distance)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("distance");

                entity.Property(e => e.FenceSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_set");

                entity.Property(e => e.FinishTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_time_max");

                entity.Property(e => e.FinishTimeMaxRandomRange)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_time_max_random_range");

                entity.Property(e => e.FinishTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_time_min");

                entity.Property(e => e.FinishTimeMinRandomRange)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_time_min_random_range");

                entity.Property(e => e.FloatLaneMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_lane_max");

                entity.Property(e => e.Ground)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ground");

                entity.Property(e => e.Inout)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("inout");

                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_track_id");

                entity.Property(e => e.Turn)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<RaceCourseSetStatus>(entity =>
            {
                entity.HasKey(e => e.CourseSetStatusId)
                    .HasName("PRIMARY");

                entity.ToTable("race_course_set_status");

                entity.Property(e => e.CourseSetStatusId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("course_set_status_id");

                entity.Property(e => e.TargetStatus1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_status_1");

                entity.Property(e => e.TargetStatus2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_status_2");
            });

            modelBuilder.Entity<RaceEnvDefine>(entity =>
            {
                entity.ToTable("race_env_define");

                entity.HasIndex(e => e.RaceTrackId, "race_env_define_0_race_track_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_track_id");

                entity.Property(e => e.Resource)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("resource");

                entity.Property(e => e.Season)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("season");

                entity.Property(e => e.Timezone)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("timezone");

                entity.Property(e => e.Weather)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<RaceFenceSet>(entity =>
            {
                entity.ToTable("race_fence_set");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Fence1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_1");

                entity.Property(e => e.Fence2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_2");

                entity.Property(e => e.Fence3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_3");

                entity.Property(e => e.Fence4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_4");

                entity.Property(e => e.Fence5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_5");

                entity.Property(e => e.Fence6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_6");

                entity.Property(e => e.Fence7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_7");

                entity.Property(e => e.Fence8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fence_8");
            });

            modelBuilder.Entity<RaceInstance>(entity =>
            {
                entity.ToTable("race_instance");

                entity.HasIndex(e => e.RaceId, "race_instance_0_race_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("date");

                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("npc_group_id");

                entity.Property(e => e.RaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_id");

                entity.Property(e => e.RaceNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_number");

                entity.Property(e => e.Time)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<RaceJikkyoBase>(entity =>
            {
                entity.ToTable("race_jikkyo_base");

                entity.HasIndex(e => e.Mode, "race_jikkyo_base_0_mode");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CameraHorse1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("camera_horse1");

                entity.Property(e => e.CameraHorse2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("camera_horse2");

                entity.Property(e => e.CameraId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("camera_id");

                entity.Property(e => e.CommentGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("comment_group");

                entity.Property(e => e.DisableReentrySituation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disable_reentry_situation");

                entity.Property(e => e.DisableReuse)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disable_reuse");

                entity.Property(e => e.Discard)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("discard");

                entity.Property(e => e.Immediate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("immediate");

                entity.Property(e => e.MessageGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("message_group");

                entity.Property(e => e.Mode)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mode");

                entity.Property(e => e.Per)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("per");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.Situation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("situation");

                entity.Property(e => e.SituationEnd)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("situation_end");

                entity.Property(e => e.SubMode)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_mode");

                entity.Property(e => e.SubModeJump)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_mode_jump");

                entity.Property(e => e.SubSituation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_situation");

                entity.Property(e => e.Tension)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tension");

                entity.Property(e => e.Trigger0)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger0");

                entity.Property(e => e.Trigger1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger1");

                entity.Property(e => e.Trigger2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger2");

                entity.Property(e => e.Trigger3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger3");

                entity.Property(e => e.Trigger4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger4");

                entity.Property(e => e.Trigger5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger5");

                entity.Property(e => e.Trigger6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger6");

                entity.Property(e => e.Trigger7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger7");

                entity.Property(e => e.Trigger8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger8");

                entity.Property(e => e.Trigger9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trigger9");
            });

            modelBuilder.Entity<RaceJikkyoComment>(entity =>
            {
                entity.ToTable("race_jikkyo_comment");

                entity.HasIndex(e => e.GroupId, "race_jikkyo_comment_0_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("message")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MessageGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("message_group");

                entity.Property(e => e.Per)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("per");

                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("voice")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<RaceJikkyoCue>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CuesheetType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("race_jikkyo_cue");

                entity.HasIndex(e => e.CuesheetType, "race_jikkyo_cue_0_cuesheet_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CuesheetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("cuesheet_type");

                entity.Property(e => e.CuesheetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cuesheet_id");
            });

            modelBuilder.Entity<RaceJikkyoMessage>(entity =>
            {
                entity.ToTable("race_jikkyo_message");

                entity.HasIndex(e => e.CommentGroup, "race_jikkyo_message_0_comment_group");

                entity.HasIndex(e => e.GroupId, "race_jikkyo_message_0_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommentGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("comment_group");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("message")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Per)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("per");

                entity.Property(e => e.Reuse)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reuse");

                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("voice")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<RaceJikkyoRace>(entity =>
            {
                entity.ToTable("race_jikkyo_race");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cue_id");
            });

            modelBuilder.Entity<RaceJikkyoTrigger>(entity =>
            {
                entity.ToTable("race_jikkyo_trigger");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Command)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command");

                entity.Property(e => e.Horse1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("horse1");

                entity.Property(e => e.Horse2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("horse2");

                entity.Property(e => e.Inequality)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("inequality");

                entity.Property(e => e.Param1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("param1");

                entity.Property(e => e.Param2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("param2");
            });

            modelBuilder.Entity<RaceMotivationRate>(entity =>
            {
                entity.ToTable("race_motivation_rate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MotivationRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motivation_rate");
            });

            modelBuilder.Entity<RaceOverrunPattern>(entity =>
            {
                entity.ToTable("race_overrun_pattern");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FinishOrder0Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_order_0_type");

                entity.Property(e => e.FinishOrder1Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_order_1_type");

                entity.Property(e => e.FinishOrder2Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_order_2_type");

                entity.Property(e => e.FinishOrder3Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_order_3_type");

                entity.Property(e => e.FinishOrder4Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_order_4_type");

                entity.Property(e => e.FinishOrderLoseType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("finish_order_lose_type");
            });

            modelBuilder.Entity<RacePlayerCamera>(entity =>
            {
                entity.ToTable("race_player_camera");

                entity.HasIndex(e => e.Category, "race_player_camera_0_category");

                entity.HasIndex(e => e.PrefabName, "race_player_camera_0_prefab_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 768 });

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("category");

                entity.Property(e => e.PrefabName)
                    .IsRequired()
                    .HasMaxLength(900)
                    .HasColumnName("prefab_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");
            });

            modelBuilder.Entity<RacePopularityProperValue>(entity =>
            {
                entity.ToTable("race_popularity_proper_value");

                entity.HasIndex(e => e.ProperType, "race_popularity_proper_value_0_proper_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperGrade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_grade");

                entity.Property(e => e.ProperType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_type");

                entity.Property(e => e.Value)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<RaceProperDistanceRate>(entity =>
            {
                entity.ToTable("race_proper_distance_rate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperRatePower)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_rate_power");

                entity.Property(e => e.ProperRateSpeed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_rate_speed");
            });

            modelBuilder.Entity<RaceProperGroundRate>(entity =>
            {
                entity.ToTable("race_proper_ground_rate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_rate");
            });

            modelBuilder.Entity<RaceProperRunningstyleRate>(entity =>
            {
                entity.ToTable("race_proper_runningstyle_rate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ProperRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_rate");
            });

            modelBuilder.Entity<RaceSingleModeTeamStatus>(entity =>
            {
                entity.ToTable("race_single_mode_team_status");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddStatus)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_status");

                entity.Property(e => e.TeamRankThreshold)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_rank_threshold");
            });

            modelBuilder.Entity<RaceTrack>(entity =>
            {
                entity.ToTable("race_track");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EnableHalfGate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("enable_half_gate");

                entity.Property(e => e.FootsmokeColorType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("footsmoke_color_type");

                entity.Property(e => e.HorseNumGateVariation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("horse_num_gate_variation");

                entity.Property(e => e.InitialLaneType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("initial_lane_type");

                entity.Property(e => e.TurfVisionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turf_vision_type");
            });

            modelBuilder.Entity<RaceTrophy>(entity =>
            {
                entity.ToTable("race_trophy");

                entity.HasIndex(e => e.RaceInstanceId, "race_trophy_0_race_instance_id")
                    .IsUnique();

                entity.HasIndex(e => e.TrophyId, "race_trophy_0_trophy_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.DisplayEndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("display_end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_type");

                entity.Property(e => e.OriginalFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("original_flag");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.Size)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("size");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TrophyId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trophy_id");
            });

            modelBuilder.Entity<RaceTrophyReward>(entity =>
            {
                entity.HasKey(e => e.TrophyId)
                    .HasName("PRIMARY");

                entity.ToTable("race_trophy_reward");

                entity.Property(e => e.TrophyId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("trophy_id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<RandomEarTailMotion>(entity =>
            {
                entity.ToTable("random_ear_tail_motion");

                entity.HasIndex(e => e.PartsType, "random_ear_tail_motion_0_parts_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EarType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ear_type");

                entity.Property(e => e.MotionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("motion_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PartsType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("parts_type");

                entity.Property(e => e.UseStory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_story");
            });

            modelBuilder.Entity<SeasonData>(entity =>
            {
                entity.ToTable("season_data");

                entity.HasIndex(e => e.Type, "season_data_0_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.Season)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("season");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ShortEpisode>(entity =>
            {
                entity.ToTable("short_episode");

                entity.HasIndex(e => e.Scene, "short_episode_0_scene");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.Scene)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scene");

                entity.Property(e => e.Sort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort");

                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<SingleModeAnalyzeMessage>(entity =>
            {
                entity.ToTable("single_mode_analyze_message");

                entity.HasIndex(e => e.Popularity, "single_mode_analyze_message_0_popularity");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharacterType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("character_type");

                entity.Property(e => e.MotionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_type");

                entity.Property(e => e.Popularity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.ProperDistance)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance");

                entity.Property(e => e.ProperGround)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground");

                entity.Property(e => e.Rate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rate");

                entity.Property(e => e.Year)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("year");
            });

            modelBuilder.Entity<SingleModeAnalyzeTicket>(entity =>
            {
                entity.ToTable("single_mode_analyze_ticket");

                entity.HasIndex(e => e.Grade, "single_mode_analyze_ticket_0_grade");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CostTicket)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_ticket");

                entity.Property(e => e.Grade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade");
            });

            modelBuilder.Entity<SingleModeAoOffset>(entity =>
            {
                entity.ToTable("single_mode_ao_offset");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Offset1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset_1");

                entity.Property(e => e.Offset2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset_2");

                entity.Property(e => e.Offset3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset_3");

                entity.Property(e => e.Offset4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset_4");

                entity.Property(e => e.Offset5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset_5");
            });

            modelBuilder.Entity<SingleModeAoTrainingPlate>(entity =>
            {
                entity.ToTable("single_mode_ao_training_plate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ValueMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_max");

                entity.Property(e => e.ValueMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_min");
            });

            modelBuilder.Entity<SingleModeAoharuCuttType>(entity =>
            {
                entity.ToTable("single_mode_aoharu_cutt_type");

                entity.HasIndex(e => e.CharaType, "single_mode_aoharu_cutt_type_0_chara_type");

                entity.HasIndex(e => new { e.CharaType, e.CuttType }, "single_mode_aoharu_cutt_type_0_chara_type_1_cutt_type");

                entity.HasIndex(e => e.CuttType, "single_mode_aoharu_cutt_type_0_cutt_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type");

                entity.Property(e => e.CuttId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_id");

                entity.Property(e => e.CuttType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_type");
            });

            modelBuilder.Entity<SingleModeAoharuResultCutt>(entity =>
            {
                entity.ToTable("single_mode_aoharu_result_cutt");

                entity.HasIndex(e => e.CharaId, "single_mode_aoharu_result_cutt_0_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CuttId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_id");
            });

            modelBuilder.Entity<SingleModeAoharuSchedule>(entity =>
            {
                entity.ToTable("single_mode_aoharu_schedule");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NoticeTurn1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_turn_1");

                entity.Property(e => e.NoticeTurn2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_turn_2");

                entity.Property(e => e.NoticeTurn3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_turn_3");

                entity.Property(e => e.NoticeTurn4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_turn_4");

                entity.Property(e => e.NoticeTurn5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_turn_5");

                entity.Property(e => e.TurnNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn_num");
            });

            modelBuilder.Entity<SingleModeCharaEffect>(entity =>
            {
                entity.ToTable("single_mode_chara_effect");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EffectCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_category");

                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_group_id");

                entity.Property(e => e.EffectType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_type");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");
            });

            modelBuilder.Entity<SingleModeCharaGrade>(entity =>
            {
                entity.ToTable("single_mode_chara_grade");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NeedFanCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_fan_count");

                entity.Property(e => e.RunNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("run_num");

                entity.Property(e => e.WinNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_num");
            });

            modelBuilder.Entity<SingleModeCharaProgram>(entity =>
            {
                entity.ToTable("single_mode_chara_program");

                entity.HasIndex(e => e.CharaId, "single_mode_chara_program_0_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.ProgramGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("program_group");
            });

            modelBuilder.Entity<SingleModeConclusionSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("single_mode_conclusion_set");

                entity.HasIndex(e => e.StoryId, "single_mode_conclusion_set_0_story_id");

                entity.Property(e => e.ConclusionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("conclusion_id");

                entity.Property(e => e.RootId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("root_id");

                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<SingleModeDifficultyBox>(entity =>
            {
                entity.HasKey(e => new { e.RewardSetId, e.BoxStep })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("single_mode_difficulty_box");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");

                entity.Property(e => e.BoxStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_step");

                entity.Property(e => e.BoxId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("box_id");

                entity.Property(e => e.BoxOpenCondition)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("box_open_condition");

                entity.Property(e => e.BoxType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("box_type");

                entity.Property(e => e.CueNameIcon)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name_icon");

                entity.Property(e => e.CueNamePopout)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name_popout");

                entity.Property(e => e.CuesheetNameIcon)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cuesheet_name_icon");

                entity.Property(e => e.CuesheetNamePopout)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cuesheet_name_popout");
            });

            modelBuilder.Entity<SingleModeDifficultyBoxGauge>(entity =>
            {
                entity.ToTable("single_mode_difficulty_box_gauge");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DifficultyId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("difficulty_id");

                entity.Property(e => e.GaugeRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gauge_rate");

                entity.Property(e => e.ResultMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("result_max");

                entity.Property(e => e.ResultMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("result_min");
            });

            modelBuilder.Entity<SingleModeDifficultyBoxReward>(entity =>
            {
                entity.ToTable("single_mode_difficulty_box_reward");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BoxId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("box_id");

                entity.Property(e => e.BoxNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("box_num");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.Rate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<SingleModeDifficultyData>(entity =>
            {
                entity.HasKey(e => new { e.DifficultyId, e.Difficulty })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("single_mode_difficulty_data");

                entity.Property(e => e.DifficultyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty_id");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");

                entity.Property(e => e.DifficultyRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("difficulty_rate");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.MaxNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_num");
            });

            modelBuilder.Entity<SingleModeDifficultyMode>(entity =>
            {
                entity.HasKey(e => e.DifficultyId)
                    .HasName("PRIMARY");

                entity.ToTable("single_mode_difficulty_mode");

                entity.Property(e => e.DifficultyId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("difficulty_id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.GaugeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gauge_max");

                entity.Property(e => e.GaugeMotion)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gauge_motion");

                entity.Property(e => e.GaugeMotion2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gauge_motion2");

                entity.Property(e => e.GaugeMotion3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gauge_motion3");

                entity.Property(e => e.GaugeUp)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("gauge_up");

                entity.Property(e => e.GuideId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guide_id");

                entity.Property(e => e.InMotion)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("in_motion");

                entity.Property(e => e.PlayMotion)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("play_motion");

                entity.Property(e => e.PopoutMotion)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popout_motion");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_set_id");

                entity.Property(e => e.RewardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_type");

                entity.Property(e => e.StandMotion)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stand_motion");
            });

            modelBuilder.Entity<SingleModeEvaluation>(entity =>
            {
                entity.ToTable("single_mode_evaluation");

                entity.HasIndex(e => e.CharaId, "single_mode_evaluation_0_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Evaluation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("evaluation");
            });

            modelBuilder.Entity<SingleModeEventConclusion>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CharaId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("single_mode_event_conclusion");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CharaMotionSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_motion_set_id");
            });

            modelBuilder.Entity<SingleModeEventItemDetail>(entity =>
            {
                entity.ToTable("single_mode_event_item_detail");

                entity.HasIndex(e => new { e.EventCategoryId, e.ItemId }, "single_mode_event_item_detail_0_event_category_id_1_item_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EventCategoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_category_id");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.NameIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("name_index");
            });

            modelBuilder.Entity<SingleModeEventProduction>(entity =>
            {
                entity.HasKey(e => e.StoryId)
                    .HasName("PRIMARY");

                entity.ToTable("single_mode_event_production");

                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.EventCategoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_category_id");

                entity.Property(e => e.MaxItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_item_id");
            });

            modelBuilder.Entity<SingleModeFanCount>(entity =>
            {
                entity.ToTable("single_mode_fan_count");

                entity.HasIndex(e => e.FanSetId, "single_mode_fan_count_0_fan_set_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.FanCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fan_count");

                entity.Property(e => e.FanSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fan_set_id");

                entity.Property(e => e.Order)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("order");
            });

            modelBuilder.Entity<SingleModeHintGain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("single_mode_hint_gain");

                entity.HasIndex(e => e.HintId, "single_mode_hint_gain_0_hint_id");

                entity.Property(e => e.HintGainType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("hint_gain_type");

                entity.Property(e => e.HintGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("hint_group");

                entity.Property(e => e.HintId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("hint_id");

                entity.Property(e => e.HintValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("hint_value_1");

                entity.Property(e => e.HintValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("hint_value_2");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SingleModeMemberRank>(entity =>
            {
                entity.ToTable("single_mode_member_rank");

                entity.HasIndex(e => e.MemberRankId, "single_mode_member_rank_0_member_rank_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MemberRankId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("member_rank_id");

                entity.Property(e => e.ValueMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_max");

                entity.Property(e => e.ValueMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_min");
            });

            modelBuilder.Entity<SingleModeMemberRankPoint>(entity =>
            {
                entity.ToTable("single_mode_member_rank_points");

                entity.HasIndex(e => e.RankId, "single_mode_member_rank_points_0_rank_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Points)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("points");

                entity.Property(e => e.RankId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank_id");
            });

            modelBuilder.Entity<SingleModeMessage>(entity =>
            {
                entity.ToTable("single_mode_message");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharacterType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("character_type");

                entity.Property(e => e.Emergent)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("emergent");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.StatusType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_type_1");

                entity.Property(e => e.StatusType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_type_2");

                entity.Property(e => e.StatusValue11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_value_1_1");

                entity.Property(e => e.StatusValue12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_value_1_2");

                entity.Property(e => e.StatusValue21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_value_2_1");

                entity.Property(e => e.StatusValue22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_value_2_2");
            });

            modelBuilder.Entity<SingleModeNpc>(entity =>
            {
                entity.ToTable("single_mode_npc");

                entity.HasIndex(e => e.NpcGroupId, "single_mode_npc_0_npc_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.MobId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mob_id");

                entity.Property(e => e.MotivationMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motivation_max");

                entity.Property(e => e.MotivationMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motivation_min");

                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("npc_group_id");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<SingleModeOuting>(entity =>
            {
                entity.ToTable("single_mode_outing");

                entity.HasIndex(e => e.CommandGroupId, "single_mode_outing_0_command_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommandGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_group_id");

                entity.Property(e => e.Condition)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition");

                entity.Property(e => e.IsPlayCutt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("is_play_cutt");
            });

            modelBuilder.Entity<SingleModeOutingSet>(entity =>
            {
                entity.ToTable("single_mode_outing_set");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommandGroupId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_group_id_1");

                entity.Property(e => e.CommandGroupId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_group_id_2");

                entity.Property(e => e.CommandGroupId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_group_id_3");

                entity.Property(e => e.CommandGroupId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_group_id_4");

                entity.Property(e => e.CommandGroupId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_group_id_5");
            });

            modelBuilder.Entity<SingleModeProgram>(entity =>
            {
                entity.ToTable("single_mode_program");

                entity.HasIndex(e => e.Month, "single_mode_program_0_month");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseProgramId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("base_program_id");

                entity.Property(e => e.EntryDecrease)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("entry_decrease");

                entity.Property(e => e.EntryDecreaseFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("entry_decrease_flag");

                entity.Property(e => e.FanSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fan_set_id");

                entity.Property(e => e.FillyOnlyFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("filly_only_flag");

                entity.Property(e => e.GradeRateId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade_rate_id");

                entity.Property(e => e.Half)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("half");

                entity.Property(e => e.Month)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("month");

                entity.Property(e => e.NeedFanCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_fan_count");

                entity.Property(e => e.ProgramGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("program_group");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RacePermission)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_permission");

                entity.Property(e => e.RecommendClassId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("recommend_class_id");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<SingleModeRaceGroup>(entity =>
            {
                entity.ToTable("single_mode_race_group");

                entity.HasIndex(e => e.RaceGroupId, "single_mode_race_group_0_race_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RaceGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_group_id");

                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_program_id");
            });

            modelBuilder.Entity<SingleModeRaceLive>(entity =>
            {
                entity.ToTable("single_mode_race_live");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Grade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade");

                entity.Property(e => e.MusicId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("music_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<SingleModeRank>(entity =>
            {
                entity.ToTable("single_mode_rank");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MaxValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_value");

                entity.Property(e => e.MinValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("min_value");
            });

            modelBuilder.Entity<SingleModeRecommend>(entity =>
            {
                entity.ToTable("single_mode_recommend");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GradeLowerLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade_lower_limit");

                entity.Property(e => e.GradeUpperLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade_upper_limit");
            });

            modelBuilder.Entity<SingleModeRecommendSetting>(entity =>
            {
                entity.ToTable("single_mode_recommend_setting");

                entity.HasIndex(e => e.RecommendCourseId, "single_mode_recommend_setting_0_recommend_course_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.HeaderFontColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("header_font_color")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RecommendCourseId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("recommend_course_id");
            });

            modelBuilder.Entity<SingleModeRewardSet>(entity =>
            {
                entity.ToTable("single_mode_reward_set");

                entity.HasIndex(e => e.RewardSetId, "single_mode_reward_set_0_reward_set_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Bonus)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.Odds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds");

                entity.Property(e => e.OrderMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("order_max");

                entity.Property(e => e.OrderMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("order_min");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_set_id");

                entity.Property(e => e.RewardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_type");
            });

            modelBuilder.Entity<SingleModeRival>(entity =>
            {
                entity.ToTable("single_mode_rival");

                entity.HasIndex(e => e.RaceProgramId, "single_mode_rival_0_race_program_id");

                entity.HasIndex(e => new { e.CharaId, e.Turn, e.RaceProgramId, e.RivalCharaId }, "single_mode_rival_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_program_id");

                entity.Property(e => e.RivalCharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rival_chara_id");

                entity.Property(e => e.SingleModeNpcId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("single_mode_npc_id");

                entity.Property(e => e.Turn)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeRoute>(entity =>
            {
                entity.ToTable("single_mode_route");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.RaceSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_set_id");

                entity.Property(e => e.ScenarioId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeRouteRace>(entity =>
            {
                entity.ToTable("single_mode_route_race");

                entity.HasIndex(e => e.RaceSetId, "single_mode_route_race_0_race_set_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.DetermineRace)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("determine_race");

                entity.Property(e => e.DetermineRaceFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("determine_race_flag");

                entity.Property(e => e.RaceSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_set_id");

                entity.Property(e => e.RaceType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_type");

                entity.Property(e => e.SortId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort_id");

                entity.Property(e => e.TargetType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type");

                entity.Property(e => e.Turn)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeScenario>(entity =>
            {
                entity.ToTable("single_mode_scenario");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.PrologueId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prologue_id");

                entity.Property(e => e.ScenarioImageId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scenario_image_id");

                entity.Property(e => e.SortId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.TurnSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn_set_id");
            });

            modelBuilder.Entity<SingleModeScenarioRecord>(entity =>
            {
                entity.ToTable("single_mode_scenario_record");

                entity.HasIndex(e => e.ScenarioId, "single_mode_scenario_record_0_scenario_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NeedRecordMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_record_min");

                entity.Property(e => e.RewardItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_category");

                entity.Property(e => e.RewardItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_item_id");

                entity.Property(e => e.RewardNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_num");

                entity.Property(e => e.ScenarioId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeScoutChara>(entity =>
            {
                entity.ToTable("single_mode_scout_chara");

                entity.HasIndex(e => e.CharaId, "single_mode_scout_chara_0_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Guts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts");

                entity.Property(e => e.GutsLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts_limit");

                entity.Property(e => e.LiveDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("live_dress_id");

                entity.Property(e => e.Pow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow");

                entity.Property(e => e.PowLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pow_limit");

                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_long");

                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_middle");

                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_mile");

                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_distance_short");

                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_dirt");

                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_ground_turf");

                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_nige");

                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_oikomi");

                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_sashi");

                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("proper_running_style_senko");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.Speed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed");

                entity.Property(e => e.SpeedLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed_limit");

                entity.Property(e => e.Stamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina");

                entity.Property(e => e.StaminaLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina_limit");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id");

                entity.Property(e => e.TagSupportCardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tag_support_card_id");

                entity.Property(e => e.Wiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz");

                entity.Property(e => e.WizLimit)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wiz_limit");
            });

            modelBuilder.Entity<SingleModeSkillNeedPoint>(entity =>
            {
                entity.ToTable("single_mode_skill_need_point");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.NeedSkillPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_skill_point");

                entity.Property(e => e.StatusType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_type");

                entity.Property(e => e.StatusValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("status_value");
            });

            modelBuilder.Entity<SingleModeSpecialChara>(entity =>
            {
                entity.ToTable("single_mode_special_chara");

                entity.HasIndex(e => e.ScenarioId, "single_mode_special_chara_0_scenario_id");

                entity.HasIndex(e => new { e.ScenarioId, e.CharaId }, "single_mode_special_chara_0_scenario_id_1_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.ScenarioId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeStoryData>(entity =>
            {
                entity.ToTable("single_mode_story_data");

                entity.HasIndex(e => e.CardCharaId, "single_mode_story_data_0_card_chara_id");

                entity.HasIndex(e => e.CardId, "single_mode_story_data_0_card_id");

                entity.HasIndex(e => e.ShortStoryId, "single_mode_story_data_0_short_story_id");

                entity.HasIndex(e => e.StoryId, "single_mode_story_data_0_story_id");

                entity.HasIndex(e => e.SupportCardId, "single_mode_story_data_0_support_card_id");

                entity.HasIndex(e => e.SupportCharaId, "single_mode_story_data_0_support_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardCharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_chara_id");

                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");

                entity.Property(e => e.EndingType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ending_type");

                entity.Property(e => e.EventTitleCharaIcon)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_title_chara_icon");

                entity.Property(e => e.EventTitleDressIcon)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_title_dress_icon");

                entity.Property(e => e.EventTitleStyle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("event_title_style");

                entity.Property(e => e.MiniGameResult)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mini_game_result");

                entity.Property(e => e.RaceEventFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_event_flag");

                entity.Property(e => e.SeChange)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("se_change");

                entity.Property(e => e.ShortStoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("short_story_id");

                entity.Property(e => e.ShowClear)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("show_clear");

                entity.Property(e => e.ShowProgress1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("show_progress_1");

                entity.Property(e => e.ShowProgress2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("show_progress_2");

                entity.Property(e => e.ShowSuccession)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("show_succession");

                entity.Property(e => e.StoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id");

                entity.Property(e => e.SupportCharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_chara_id");
            });

            modelBuilder.Entity<SingleModeStoryGuide>(entity =>
            {
                entity.HasKey(e => e.StoryId)
                    .HasName("PRIMARY");

                entity.ToTable("single_mode_story_guide");

                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("story_id");

                entity.Property(e => e.GuideId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guide_id");
            });

            modelBuilder.Entity<SingleModeTagCardPo>(entity =>
            {
                entity.ToTable("single_mode_tag_card_pos");

                entity.HasIndex(e => e.SupportCardId, "single_mode_tag_card_pos_0_support_card_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Pattern)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pattern");

                entity.Property(e => e.PosIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_index");

                entity.Property(e => e.PosX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_x");

                entity.Property(e => e.PosY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_y");

                entity.Property(e => e.RotZ)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rot_z");

                entity.Property(e => e.ScaleX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scale_x");

                entity.Property(e => e.ScaleY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scale_y");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SingleModeTeamName>(entity =>
            {
                entity.ToTable("single_mode_team_name");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");
            });

            modelBuilder.Entity<SingleModeTopBg>(entity =>
            {
                entity.ToTable("single_mode_top_bg");

                entity.HasIndex(e => e.Month, "single_mode_top_bg_0_month");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_id");

                entity.Property(e => e.BgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_sub_id");

                entity.Property(e => e.Month)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("month");
            });

            modelBuilder.Entity<SingleModeTopBgChara>(entity =>
            {
                entity.ToTable("single_mode_top_bg_chara");

                entity.HasIndex(e => new { e.BgId, e.ScenarioId }, "single_mode_top_bg_chara_0_bg_id_1_scenario_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bg_id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.MotionSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_set_id");

                entity.Property(e => e.PosX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_x");

                entity.Property(e => e.PosZ)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pos_z");

                entity.Property(e => e.RotationY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rotation_y");

                entity.Property(e => e.ScenarioId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeTraining>(entity =>
            {
                entity.ToTable("single_mode_training");

                entity.HasIndex(e => e.CommandId, "single_mode_training_0_command_id");

                entity.HasIndex(e => new { e.CommandId, e.CommandLevel }, "single_mode_training_0_command_id_1_command_level")
                    .IsUnique();

                entity.HasIndex(e => e.CommandType, "single_mode_training_0_command_type");

                entity.HasIndex(e => e.CutinFileId, "single_mode_training_0_cutin_file_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseCommandId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("base_command_id");

                entity.Property(e => e.CommandId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandLevel)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_level");

                entity.Property(e => e.CommandType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_type");

                entity.Property(e => e.CutinFileId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutin_file_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.DressType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_type");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FailureRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("failure_rate");

                entity.Property(e => e.MaxCharaNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_chara_num");

                entity.Property(e => e.MenuBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("menu_bg_id");

                entity.Property(e => e.MenuBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("menu_bg_sub_id");

                entity.Property(e => e.MotionSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_set");

                entity.Property(e => e.SaboriType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sabori_type");
            });

            modelBuilder.Entity<SingleModeTrainingEffect>(entity =>
            {
                entity.ToTable("single_mode_training_effect");

                entity.HasIndex(e => new { e.CommandId, e.ResultState }, "single_mode_training_effect_0_command_id_1_result_state");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CommandId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_id");

                entity.Property(e => e.EffectValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_value");

                entity.Property(e => e.ResultState)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("result_state");

                entity.Property(e => e.ScenarioId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scenario_id");

                entity.Property(e => e.SubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_id");

                entity.Property(e => e.TargetType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type");
            });

            modelBuilder.Entity<SingleModeTrainingSe>(entity =>
            {
                entity.ToTable("single_mode_training_se");

                entity.HasIndex(e => e.SheetId, "single_mode_training_se_0_sheet_id")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 768 });

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_index");

                entity.Property(e => e.SeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasMaxLength(900)
                    .HasColumnName("sheet_id")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SkipSeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skip_se_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SkipSeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skip_se_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.VoiceTriggerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("voice_trigger_id");
            });

            modelBuilder.Entity<SingleModeTurn>(entity =>
            {
                entity.ToTable("single_mode_turn");

                entity.HasIndex(e => e.TurnSetId, "single_mode_turn_0_turn_set_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Half)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("half");

                entity.Property(e => e.HealthRoomType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("health_room_type");

                entity.Property(e => e.Month)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("month");

                entity.Property(e => e.OutingSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("outing_set_id");

                entity.Property(e => e.Period)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("period");

                entity.Property(e => e.RaceEntryType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_entry_type");

                entity.Property(e => e.RestType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rest_type");

                entity.Property(e => e.StoryBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_bg_id");

                entity.Property(e => e.StoryBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_bg_sub_id");

                entity.Property(e => e.StoryClothId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_cloth_id");

                entity.Property(e => e.TopBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("top_bg_id");

                entity.Property(e => e.TopClothId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("top_cloth_id");

                entity.Property(e => e.TrainingSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("training_set_id");

                entity.Property(e => e.Turn)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn");

                entity.Property(e => e.TurnSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn_set_id");

                entity.Property(e => e.UniqueCommand)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unique_command");

                entity.Property(e => e.Year)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("year");
            });

            modelBuilder.Entity<SingleModeUniqueChara>(entity =>
            {
                entity.ToTable("single_mode_unique_chara");

                entity.HasIndex(e => new { e.PartnerId, e.ScenarioId }, "single_mode_unique_chara_0_partner_id_1_scenario_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("partner_id");

                entity.Property(e => e.Period)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("period");

                entity.Property(e => e.ScenarioId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scenario_id");

                entity.Property(e => e.TrainingPlacement)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("training_placement");
            });

            modelBuilder.Entity<SingleModeWinsSaddle>(entity =>
            {
                entity.ToTable("single_mode_wins_saddle");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Condition)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.RaceInstanceId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_1");

                entity.Property(e => e.RaceInstanceId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_2");

                entity.Property(e => e.RaceInstanceId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_3");

                entity.Property(e => e.RaceInstanceId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_4");

                entity.Property(e => e.RaceInstanceId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_5");

                entity.Property(e => e.RaceInstanceId6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_6");

                entity.Property(e => e.RaceInstanceId7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_7");

                entity.Property(e => e.RaceInstanceId8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id_8");

                entity.Property(e => e.WinSaddleType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_saddle_type");
            });

            modelBuilder.Entity<SkillData>(entity =>
            {
                entity.ToTable("skill_data");

                entity.HasIndex(e => e.GroupId, "skill_data_0_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AbilityType11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_1");

                entity.Property(e => e.AbilityType12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_2");

                entity.Property(e => e.AbilityType13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_3");

                entity.Property(e => e.AbilityType21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_1");

                entity.Property(e => e.AbilityType22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_2");

                entity.Property(e => e.AbilityType23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_3");

                entity.Property(e => e.AbilityValueLevelUsage11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_level_usage_1_1");

                entity.Property(e => e.AbilityValueLevelUsage12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_level_usage_1_2");

                entity.Property(e => e.AbilityValueLevelUsage13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_level_usage_1_3");

                entity.Property(e => e.AbilityValueLevelUsage21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_level_usage_2_1");

                entity.Property(e => e.AbilityValueLevelUsage22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_level_usage_2_2");

                entity.Property(e => e.AbilityValueLevelUsage23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_level_usage_2_3");

                entity.Property(e => e.AbilityValueUsage11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_usage_1_1");

                entity.Property(e => e.AbilityValueUsage12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_usage_1_2");

                entity.Property(e => e.AbilityValueUsage13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_usage_1_3");

                entity.Property(e => e.AbilityValueUsage21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_usage_2_1");

                entity.Property(e => e.AbilityValueUsage22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_usage_2_2");

                entity.Property(e => e.AbilityValueUsage23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_value_usage_2_3");

                entity.Property(e => e.ActivateLot)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("activate_lot");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DisableSinglemode)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disable_singlemode");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.ExpType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exp_type");

                entity.Property(e => e.FilterSwitch)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("filter_switch");

                entity.Property(e => e.FloatAbilityTime1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_time_1");

                entity.Property(e => e.FloatAbilityTime2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_time_2");

                entity.Property(e => e.FloatAbilityValue11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_1");

                entity.Property(e => e.FloatAbilityValue12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_2");

                entity.Property(e => e.FloatAbilityValue13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_3");

                entity.Property(e => e.FloatAbilityValue21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_1");

                entity.Property(e => e.FloatAbilityValue22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_2");

                entity.Property(e => e.FloatAbilityValue23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_3");

                entity.Property(e => e.FloatCooldownTime1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_cooldown_time_1");

                entity.Property(e => e.FloatCooldownTime2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_cooldown_time_2");

                entity.Property(e => e.GradeValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade_value");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.GroupRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_rate");

                entity.Property(e => e.IconId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("icon_id");

                entity.Property(e => e.PlateType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("plate_type");

                entity.Property(e => e.PopularityAddParam1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_param_1");

                entity.Property(e => e.PopularityAddParam2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_param_2");

                entity.Property(e => e.PopularityAddValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_value_1");

                entity.Property(e => e.PopularityAddValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_value_2");

                entity.Property(e => e.PotentialPerDefault)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("potential_per_default");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_category");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tag_id")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TargetType11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type_1_1");

                entity.Property(e => e.TargetType12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type_1_2");

                entity.Property(e => e.TargetType13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type_1_3");

                entity.Property(e => e.TargetType21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type_2_1");

                entity.Property(e => e.TargetType22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type_2_2");

                entity.Property(e => e.TargetType23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type_2_3");

                entity.Property(e => e.TargetValue11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_value_1_1");

                entity.Property(e => e.TargetValue12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_value_1_2");

                entity.Property(e => e.TargetValue13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_value_1_3");

                entity.Property(e => e.TargetValue21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_value_2_1");

                entity.Property(e => e.TargetValue22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_value_2_2");

                entity.Property(e => e.TargetValue23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_value_2_3");

                entity.Property(e => e.UniqueSkillId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unique_skill_id_1");

                entity.Property(e => e.UniqueSkillId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unique_skill_id_2");
            });

            modelBuilder.Entity<SkillExp>(entity =>
            {
                entity.ToTable("skill_exp");

                entity.HasIndex(e => e.Type, "skill_exp_0_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Level)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("level");

                entity.Property(e => e.Scale)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scale");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SkillLevelValue>(entity =>
            {
                entity.ToTable("skill_level_value");

                entity.HasIndex(e => e.AbilityType, "skill_level_value_0_ability_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AbilityType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type");

                entity.Property(e => e.FloatAbilityValueCoef)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_coef");

                entity.Property(e => e.Level)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("level");
            });

            modelBuilder.Entity<SkillRarity>(entity =>
            {
                entity.ToTable("skill_rarity");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Value)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<SkillSet>(entity =>
            {
                entity.ToTable("skill_set");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.SkillId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id1");

                entity.Property(e => e.SkillId10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id10");

                entity.Property(e => e.SkillId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id2");

                entity.Property(e => e.SkillId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id3");

                entity.Property(e => e.SkillId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id4");

                entity.Property(e => e.SkillId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id5");

                entity.Property(e => e.SkillId6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id6");

                entity.Property(e => e.SkillId7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id7");

                entity.Property(e => e.SkillId8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id8");

                entity.Property(e => e.SkillId9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_id9");

                entity.Property(e => e.SkillLevel1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level1");

                entity.Property(e => e.SkillLevel10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level10");

                entity.Property(e => e.SkillLevel2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level2");

                entity.Property(e => e.SkillLevel3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level3");

                entity.Property(e => e.SkillLevel4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level4");

                entity.Property(e => e.SkillLevel5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level5");

                entity.Property(e => e.SkillLevel6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level6");

                entity.Property(e => e.SkillLevel7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level7");

                entity.Property(e => e.SkillLevel8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level8");

                entity.Property(e => e.SkillLevel9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_level9");
            });

            modelBuilder.Entity<StoryEventBingoReward>(entity =>
            {
                entity.ToTable("story_event_bingo_reward");

                entity.HasIndex(e => e.RewardSetId, "story_event_bingo_reward_0_reward_set_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.LineNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("line_num");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<StoryEventBonusCard>(entity =>
            {
                entity.ToTable("story_event_bonus_card");

                entity.HasIndex(e => e.StoryEventId, "story_event_bonus_card_0_story_event_id");

                entity.HasIndex(e => new { e.StoryEventId, e.CharaId, e.CardId }, "story_event_bonus_card_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.Rarity1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity_1");

                entity.Property(e => e.Rarity2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity_2");

                entity.Property(e => e.Rarity3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity_3");

                entity.Property(e => e.Rarity4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity_4");

                entity.Property(e => e.Rarity5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity_5");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventBonusSupportCard>(entity =>
            {
                entity.ToTable("story_event_bonus_support_card");

                entity.HasIndex(e => e.StoryEventId, "story_event_bonus_support_card_0_story_event_id");

                entity.HasIndex(e => new { e.StoryEventId, e.CharaId, e.Rarity, e.SupportCardId }, "story_event_bonus_support_card_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.Limit0)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_0");

                entity.Property(e => e.Limit1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_1");

                entity.Property(e => e.Limit2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_2");

                entity.Property(e => e.Limit3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_3");

                entity.Property(e => e.Limit4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_4");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<StoryEventData>(entity =>
            {
                entity.HasKey(e => e.StoryEventId)
                    .HasName("PRIMARY");

                entity.ToTable("story_event_data");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("story_event_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ending_date");

                entity.Property(e => e.MiddleDate01)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("middle_date_01");

                entity.Property(e => e.MiddleDate02)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("middle_date_02");

                entity.Property(e => e.NoticeDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<StoryEventMission>(entity =>
            {
                entity.ToTable("story_event_mission");

                entity.HasIndex(e => e.StoryEventId, "story_event_mission_0_story_event_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_num");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_4");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.MissionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mission_type");

                entity.Property(e => e.StepGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("step_group_id");

                entity.Property(e => e.StepOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("step_order");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.TransitionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transition_type");
            });

            modelBuilder.Entity<StoryEventMissionTopChara>(entity =>
            {
                entity.ToTable("story_event_mission_top_chara");

                entity.HasIndex(e => e.StoryEventId, "story_event_mission_top_chara_0_story_event_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("character_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.EndingFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ending_flag");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MenuBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("menu_bg_id");

                entity.Property(e => e.MenuBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("menu_bg_sub_id");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventNicknameBonus>(entity =>
            {
                entity.ToTable("story_event_nickname_bonus");

                entity.HasIndex(e => e.StoryEventId, "story_event_nickname_bonus_0_story_event_id");

                entity.HasIndex(e => new { e.StoryEventId, e.NicknameRank }, "story_event_nickname_bonus_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_point");

                entity.Property(e => e.NicknameRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("nickname_rank");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventPointReward>(entity =>
            {
                entity.ToTable("story_event_point_reward");

                entity.HasIndex(e => e.StoryEventId, "story_event_point_reward_0_story_event_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.Point)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("point");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventRouletteBingo>(entity =>
            {
                entity.ToTable("story_event_roulette_bingo");

                entity.HasIndex(e => e.StoryEventId, "story_event_roulette_bingo_0_story_event_id");

                entity.HasIndex(e => new { e.RouletteId, e.StoryEventId, e.SheetNum }, "story_event_roulette_bingo_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CanLoop)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("can_loop");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("character_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.ResetLine)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reset_line");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_set_id");

                entity.Property(e => e.RouletteId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("roulette_id");

                entity.Property(e => e.RouletteMaxNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("roulette_max_num");

                entity.Property(e => e.SheetNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sheet_num");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.UseItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_item_category");

                entity.Property(e => e.UseItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_item_id");

                entity.Property(e => e.UseItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_item_num");
            });

            modelBuilder.Entity<StoryEventStoryData>(entity =>
            {
                entity.ToTable("story_event_story_data");

                entity.HasIndex(e => e.StoryEventId, "story_event_story_data_0_story_event_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_category_1");

                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_id_1");

                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_num_1");

                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("episode_index_id");

                entity.Property(e => e.NeedPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_point");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_condition_type");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.StoryId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_1");

                entity.Property(e => e.StoryId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_2");

                entity.Property(e => e.StoryId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_3");

                entity.Property(e => e.StoryId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_4");

                entity.Property(e => e.StoryId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_5");

                entity.Property(e => e.StoryType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_1");

                entity.Property(e => e.StoryType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_2");

                entity.Property(e => e.StoryType3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_3");

                entity.Property(e => e.StoryType4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_4");

                entity.Property(e => e.StoryType5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_5");
            });

            modelBuilder.Entity<StoryEventTopChara>(entity =>
            {
                entity.ToTable("story_event_top_chara");

                entity.HasIndex(e => e.StoryEventId, "story_event_top_chara_0_story_event_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("character_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.EndingFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ending_flag");

                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MaxEpisodeIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_episode_index");

                entity.Property(e => e.MenuBgId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("menu_bg_id");

                entity.Property(e => e.MenuBgSubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("menu_bg_sub_id");

                entity.Property(e => e.MinEpisodeIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("min_episode_index");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventWinBonus>(entity =>
            {
                entity.ToTable("story_event_win_bonus");

                entity.HasIndex(e => e.StoryEventId, "story_event_win_bonus_0_story_event_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_point");

                entity.Property(e => e.MaxWinCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_win_count");

                entity.Property(e => e.MinWinCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("min_win_count");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryExtraData>(entity =>
            {
                entity.HasKey(e => e.StoryExtraId)
                    .HasName("PRIMARY");

                entity.ToTable("story_extra_data");

                entity.Property(e => e.StoryExtraId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("story_extra_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<StoryExtraStoryData>(entity =>
            {
                entity.ToTable("story_extra_story_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_category_1");

                entity.Property(e => e.AddRewardCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_category_2");

                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_id_1");

                entity.Property(e => e.AddRewardId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_id_2");

                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_num_1");

                entity.Property(e => e.AddRewardNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_reward_num_2");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("episode_index_id");

                entity.Property(e => e.NoticeEndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("notice_end_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryExtraId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_extra_id");

                entity.Property(e => e.StoryId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_1");

                entity.Property(e => e.StoryId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_2");

                entity.Property(e => e.StoryId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_3");

                entity.Property(e => e.StoryId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_4");

                entity.Property(e => e.StoryId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_id_5");

                entity.Property(e => e.StoryType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_1");

                entity.Property(e => e.StoryType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_2");

                entity.Property(e => e.StoryType3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_3");

                entity.Property(e => e.StoryType4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_4");

                entity.Property(e => e.StoryType5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_type_5");
            });

            modelBuilder.Entity<StoryHipOffset>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.CharaId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("story_hip_offset");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("category_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Offset)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("offset");
            });

            modelBuilder.Entity<StoryLivePosition>(entity =>
            {
                entity.ToTable("story_live_position");

                entity.HasIndex(e => e.MusicId, "story_live_position_0_music_id");

                entity.HasIndex(e => e.SetId, "story_live_position_0_set_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CharaType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type");

                entity.Property(e => e.DressColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.MusicId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("music_id");

                entity.Property(e => e.PositionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("position_id");

                entity.Property(e => e.SecondDressColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("second_dress_color");

                entity.Property(e => e.SecondDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("second_dress_id");

                entity.Property(e => e.SetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("set_id");

                entity.Property(e => e.VocalCharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("vocal_chara_id");
            });

            modelBuilder.Entity<StoryLiveSet>(entity =>
            {
                entity.ToTable("story_live_set");

                entity.HasIndex(e => e.MusicId, "story_live_set_0_music_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_10");

                entity.Property(e => e.CharaId11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_11");

                entity.Property(e => e.CharaId12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_12");

                entity.Property(e => e.CharaId13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_13");

                entity.Property(e => e.CharaId14)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_14");

                entity.Property(e => e.CharaId15)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_15");

                entity.Property(e => e.CharaId16)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_16");

                entity.Property(e => e.CharaId17)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_17");

                entity.Property(e => e.CharaId18)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_18");

                entity.Property(e => e.CharaId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_3");

                entity.Property(e => e.CharaId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_4");

                entity.Property(e => e.CharaId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_5");

                entity.Property(e => e.CharaId6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_6");

                entity.Property(e => e.CharaId7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_7");

                entity.Property(e => e.CharaId8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_8");

                entity.Property(e => e.CharaId9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id_9");

                entity.Property(e => e.CharaType1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_1");

                entity.Property(e => e.CharaType10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_10");

                entity.Property(e => e.CharaType11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_11");

                entity.Property(e => e.CharaType12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_12");

                entity.Property(e => e.CharaType13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_13");

                entity.Property(e => e.CharaType14)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_14");

                entity.Property(e => e.CharaType15)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_15");

                entity.Property(e => e.CharaType16)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_16");

                entity.Property(e => e.CharaType17)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_17");

                entity.Property(e => e.CharaType18)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_18");

                entity.Property(e => e.CharaType2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_2");

                entity.Property(e => e.CharaType3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_3");

                entity.Property(e => e.CharaType4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_4");

                entity.Property(e => e.CharaType5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_5");

                entity.Property(e => e.CharaType6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_6");

                entity.Property(e => e.CharaType7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_7");

                entity.Property(e => e.CharaType8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_8");

                entity.Property(e => e.CharaType9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_type_9");

                entity.Property(e => e.DressColor1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_1");

                entity.Property(e => e.DressColor10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_10");

                entity.Property(e => e.DressColor11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_11");

                entity.Property(e => e.DressColor12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_12");

                entity.Property(e => e.DressColor13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_13");

                entity.Property(e => e.DressColor14)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_14");

                entity.Property(e => e.DressColor15)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_15");

                entity.Property(e => e.DressColor16)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_16");

                entity.Property(e => e.DressColor17)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_17");

                entity.Property(e => e.DressColor18)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_18");

                entity.Property(e => e.DressColor2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_2");

                entity.Property(e => e.DressColor3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_3");

                entity.Property(e => e.DressColor4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_4");

                entity.Property(e => e.DressColor5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_5");

                entity.Property(e => e.DressColor6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_6");

                entity.Property(e => e.DressColor7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_7");

                entity.Property(e => e.DressColor8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_8");

                entity.Property(e => e.DressColor9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_9");

                entity.Property(e => e.DressId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_1");

                entity.Property(e => e.DressId10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_10");

                entity.Property(e => e.DressId11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_11");

                entity.Property(e => e.DressId12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_12");

                entity.Property(e => e.DressId13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_13");

                entity.Property(e => e.DressId14)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_14");

                entity.Property(e => e.DressId15)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_15");

                entity.Property(e => e.DressId16)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_16");

                entity.Property(e => e.DressId17)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_17");

                entity.Property(e => e.DressId18)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_18");

                entity.Property(e => e.DressId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_2");

                entity.Property(e => e.DressId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_3");

                entity.Property(e => e.DressId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_4");

                entity.Property(e => e.DressId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_5");

                entity.Property(e => e.DressId6)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_6");

                entity.Property(e => e.DressId7)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_7");

                entity.Property(e => e.DressId8)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_8");

                entity.Property(e => e.DressId9)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id_9");

                entity.Property(e => e.MusicId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("music_id");

                entity.Property(e => e.VocalCharaId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("vocal_chara_id_1");

                entity.Property(e => e.VocalCharaId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("vocal_chara_id_2");

                entity.Property(e => e.VocalCharaId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("vocal_chara_id_3");

                entity.Property(e => e.VocalCharaId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("vocal_chara_id_4");

                entity.Property(e => e.VocalCharaId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("vocal_chara_id_5");
            });

            modelBuilder.Entity<StoryStill>(entity =>
            {
                entity.ToTable("story_still");

                entity.HasIndex(e => e.StillId, "story_still_0_still_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.OrderId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("order_id");

                entity.Property(e => e.PageId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("page_id");

                entity.Property(e => e.StillId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("still_id");
            });

            modelBuilder.Entity<SuccessionFactor>(entity =>
            {
                entity.HasKey(e => e.FactorId)
                    .HasName("PRIMARY");

                entity.ToTable("succession_factor");

                entity.HasIndex(e => new { e.FactorGroupId, e.Rarity }, "succession_factor_0_factor_group_id_1_rarity")
                    .IsUnique();

                entity.Property(e => e.FactorId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("factor_id");

                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_group_id");

                entity.Property(e => e.FactorGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("factor_group_id");

                entity.Property(e => e.FactorType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("factor_type");

                entity.Property(e => e.Grade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");
            });

            modelBuilder.Entity<SuccessionFactorEffect>(entity =>
            {
                entity.ToTable("succession_factor_effect");

                entity.HasIndex(e => e.FactorGroupId, "succession_factor_effect_0_factor_group_id");

                entity.HasIndex(e => new { e.FactorGroupId, e.EffectId }, "succession_factor_effect_0_factor_group_id_1_effect_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EffectId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_id");

                entity.Property(e => e.FactorGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("factor_group_id");

                entity.Property(e => e.TargetType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type");

                entity.Property(e => e.Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_1");

                entity.Property(e => e.Value2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_2");
            });

            modelBuilder.Entity<SuccessionInitialFactor>(entity =>
            {
                entity.ToTable("succession_initial_factor");

                entity.HasIndex(e => e.FactorType, "succession_initial_factor_0_factor_type");

                entity.HasIndex(e => new { e.FactorType, e.Value1 }, "succession_initial_factor_0_factor_type_1_value_1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AddPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("add_point");

                entity.Property(e => e.FactorType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("factor_type");

                entity.Property(e => e.Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_1");

                entity.Property(e => e.Value2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_2");
            });

            modelBuilder.Entity<SuccessionRelation>(entity =>
            {
                entity.HasKey(e => e.RelationType)
                    .HasName("PRIMARY");

                entity.ToTable("succession_relation");

                entity.Property(e => e.RelationType)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("relation_type");

                entity.Property(e => e.RelationPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("relation_point");
            });

            modelBuilder.Entity<SuccessionRelationMember>(entity =>
            {
                entity.ToTable("succession_relation_member");

                entity.HasIndex(e => e.CharaId, "succession_relation_member_0_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.RelationType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("relation_type");
            });

            modelBuilder.Entity<SuccessionRelationRank>(entity =>
            {
                entity.HasKey(e => e.RelationRank)
                    .HasName("PRIMARY");

                entity.ToTable("succession_relation_rank");

                entity.Property(e => e.RelationRank)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("relation_rank");

                entity.Property(e => e.RankValueMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank_value_max");

                entity.Property(e => e.RankValueMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rank_value_min");
            });

            modelBuilder.Entity<SuccessionRental>(entity =>
            {
                entity.ToTable("succession_rental");

                entity.HasIndex(e => new { e.RentalRank, e.RentalNum }, "succession_rental_0_rental_rank_1_rental_num");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RentalNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rental_num");

                entity.Property(e => e.RentalRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rental_rank");

                entity.Property(e => e.UseValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_value1");

                entity.Property(e => e.UseValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("use_value2");
            });

            modelBuilder.Entity<SupportCardData>(entity =>
            {
                entity.ToTable("support_card_data");

                entity.HasIndex(e => e.CharaId, "support_card_data_0_chara_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CommandId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_id");

                entity.Property(e => e.CommandType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_type");

                entity.Property(e => e.DetailPosX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("detail_pos_x");

                entity.Property(e => e.DetailPosY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("detail_pos_y");

                entity.Property(e => e.DetailRotZ)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("detail_rot_z");

                entity.Property(e => e.DetailScale)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("detail_scale");

                entity.Property(e => e.EffectTableId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("effect_table_id");

                entity.Property(e => e.ExchangeItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exchange_item_id");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_set_id");

                entity.Property(e => e.SupportCardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_type");

                entity.Property(e => e.UniqueEffectId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unique_effect_id");
            });

            modelBuilder.Entity<SupportCardEffectTable>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("support_card_effect_table");

                entity.HasIndex(e => e.Id, "support_card_effect_table_0_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");

                entity.Property(e => e.Init)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("init");

                entity.Property(e => e.LimitLv10)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv10");

                entity.Property(e => e.LimitLv15)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv15");

                entity.Property(e => e.LimitLv20)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv20");

                entity.Property(e => e.LimitLv25)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv25");

                entity.Property(e => e.LimitLv30)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv30");

                entity.Property(e => e.LimitLv35)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv35");

                entity.Property(e => e.LimitLv40)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv40");

                entity.Property(e => e.LimitLv45)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv45");

                entity.Property(e => e.LimitLv5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv5");

                entity.Property(e => e.LimitLv50)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_lv50");
            });

            modelBuilder.Entity<SupportCardLevel>(entity =>
            {
                entity.ToTable("support_card_level");

                entity.HasIndex(e => e.Rarity, "support_card_level_0_rarity");

                entity.HasIndex(e => new { e.Rarity, e.Level }, "support_card_level_sqlite_autoindex_1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Level)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("level");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.TotalExp)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_exp");
            });

            modelBuilder.Entity<SupportCardLimit>(entity =>
            {
                entity.HasKey(e => e.Rarity)
                    .HasName("PRIMARY");

                entity.ToTable("support_card_limit");

                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("rarity");

                entity.Property(e => e.Limit0)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_0");

                entity.Property(e => e.Limit1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_1");

                entity.Property(e => e.Limit2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_2");

                entity.Property(e => e.Limit3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_3");

                entity.Property(e => e.Limit4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limit_4");
            });

            modelBuilder.Entity<SupportCardLimitBreak>(entity =>
            {
                entity.ToTable("support_card_limit_break");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");
            });

            modelBuilder.Entity<SupportCardTeamScoreBonus>(entity =>
            {
                entity.ToTable("support_card_team_score_bonus");

                entity.HasIndex(e => e.Level, "support_card_team_score_bonus_0_level");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Level)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("level");

                entity.Property(e => e.ScoreRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("score_rate");
            });

            modelBuilder.Entity<SupportCardUniqueEffect>(entity =>
            {
                entity.ToTable("support_card_unique_effect");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Lv)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lv");

                entity.Property(e => e.Type0)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_0");

                entity.Property(e => e.Type1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_1");

                entity.Property(e => e.Value0)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_0");

                entity.Property(e => e.Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_1");
            });

            modelBuilder.Entity<TeamStadium>(entity =>
            {
                entity.ToTable("team_stadium");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CalcEndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("calc_end_date");

                entity.Property(e => e.CalcEndTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("calc_end_time")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CalcStartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("calc_start_date");

                entity.Property(e => e.CalcStartTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("calc_start_time")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.IntervalEndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("interval_end_date");

                entity.Property(e => e.IntervalEndTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("interval_end_time")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.IntervalStartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("interval_start_date");

                entity.Property(e => e.IntervalStartTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("interval_start_time")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RaceEndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_end_date");

                entity.Property(e => e.RaceEndTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_end_time")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RaceStartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_start_date");

                entity.Property(e => e.RaceStartTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_start_time")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<TeamStadiumBgm>(entity =>
            {
                entity.ToTable("team_stadium_bgm");

                entity.HasIndex(e => e.SceneType, "team_stadium_bgm_0_scene_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cuesheet_name")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.SceneType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scene_type");
            });

            modelBuilder.Entity<TeamStadiumClass>(entity =>
            {
                entity.ToTable("team_stadium_class");

                entity.HasIndex(e => e.TeamStadiumId, "team_stadium_class_0_team_stadium_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClassDownRange)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("class_down_range");

                entity.Property(e => e.ClassUpRange)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("class_up_range");

                entity.Property(e => e.TeamClass)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_class");

                entity.Property(e => e.TeamStadiumId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_stadium_id");

                entity.Property(e => e.UnitMaxNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("unit_max_num");
            });

            modelBuilder.Entity<TeamStadiumClassReward>(entity =>
            {
                entity.ToTable("team_stadium_class_reward");

                entity.HasIndex(e => new { e.TeamStadiumId, e.ClassRewardType }, "team_stadium_class_reward_0_team_stadium_id_1_class_reward_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ClassRewardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("class_reward_type");

                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_1");

                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_2");

                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_3");

                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_4");

                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_5");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_5");

                entity.Property(e => e.ItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_5");

                entity.Property(e => e.TeamClass)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_class");

                entity.Property(e => e.TeamStadiumId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_stadium_id");
            });

            modelBuilder.Entity<TeamStadiumEvaluationRate>(entity =>
            {
                entity.HasKey(e => new { e.ProperType, e.ProperRank })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("team_stadium_evaluation_rate");

                entity.Property(e => e.ProperType)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_type");

                entity.Property(e => e.ProperRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_rank");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Rate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<TeamStadiumRaceResultMotion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("team_stadium_race_result_motion");

                entity.HasIndex(e => e.CharacterId, "team_stadium_race_result_motion_0_character_id");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("character_id");

                entity.Property(e => e.Draw1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("draw_1");

                entity.Property(e => e.Draw2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("draw_2");

                entity.Property(e => e.Draw3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("draw_3");

                entity.Property(e => e.Draw4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("draw_4");

                entity.Property(e => e.Draw5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("draw_5");

                entity.Property(e => e.Lose1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lose_1");

                entity.Property(e => e.Lose2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lose_2");

                entity.Property(e => e.Lose3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lose_3");

                entity.Property(e => e.Lose4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lose_4");

                entity.Property(e => e.Lose5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lose_5");

                entity.Property(e => e.PositionY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("position_y");

                entity.Property(e => e.Win1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_1");

                entity.Property(e => e.Win2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_2");

                entity.Property(e => e.Win2PositionY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_2_position_y");

                entity.Property(e => e.Win3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_3");

                entity.Property(e => e.Win3PositionY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_3_position_y");

                entity.Property(e => e.Win4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_4");

                entity.Property(e => e.Win4PositionY)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_4_position_y");

                entity.Property(e => e.Win5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_5");
            });

            modelBuilder.Entity<TeamStadiumRank>(entity =>
            {
                entity.ToTable("team_stadium_rank");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.TeamMaxValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_max_value");

                entity.Property(e => e.TeamMinValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_min_value");

                entity.Property(e => e.TeamRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_rank");

                entity.Property(e => e.TeamRankGroup)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("team_rank_group");
            });

            modelBuilder.Entity<TeamStadiumRawScore>(entity =>
            {
                entity.ToTable("team_stadium_raw_score");

                entity.HasIndex(e => e.RaceScoreNameId, "team_stadium_raw_score_0_race_score_name_id");

                entity.HasIndex(e => e.ConditionType, "team_stadium_raw_score_team_stadium_raw_score_0_condition_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.RaceScoreNameId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_score_name_id");

                entity.Property(e => e.Score)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("score");

                entity.Property(e => e.SortOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort_order");
            });

            modelBuilder.Entity<TeamStadiumScoreBonus>(entity =>
            {
                entity.ToTable("team_stadium_score_bonus");

                entity.HasIndex(e => e.ConditionType, "team_stadium_score_bonus_0_condition_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.ScoreRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("score_rate");
            });

            modelBuilder.Entity<TeamStadiumStandMotion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("team_stadium_stand_motion");

                entity.HasIndex(e => new { e.CharacterId, e.Type }, "team_stadium_stand_motion_0_character_id_1_type");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("character_id");

                entity.Property(e => e.MotionSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("motion_set");

                entity.Property(e => e.Position)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("position");

                entity.Property(e => e.PositionX)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("position_x");

                entity.Property(e => e.RaceDressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_dress_id");

                entity.Property(e => e.Rotation)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rotation");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TeamStadiumSupportText>(entity =>
            {
                entity.ToTable("team_stadium_support_text");

                entity.HasIndex(e => e.Type, "team_stadium_support_text_0_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MaxBonus)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_bonus");

                entity.Property(e => e.MinBonus)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("min_bonus");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TextData>(entity =>
            {
                entity.HasKey(e => new { e.Category, e.Index })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("text_data");

                entity.Property(e => e.Category)
                    .HasColumnType("int(11)")
                    .HasColumnName("category");

                entity.Property(e => e.Index)
                    .HasColumnType("int(11)")
                    .HasColumnName("index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<TextDataEnglish>(entity =>
            {
                entity.ToTable("text_data_english");

                entity.HasIndex(e => e.Text, "text_data_english_text")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 768 });

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Translation)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("translation");
            });

            modelBuilder.Entity<TimezoneData>(entity =>
            {
                entity.HasKey(e => e.Timezone)
                    .HasName("PRIMARY");

                entity.ToTable("timezone_data");

                entity.Property(e => e.Timezone)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("timezone");

                entity.Property(e => e.EndHour)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_hour")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.StartHour)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_hour")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("topics");

                entity.HasIndex(e => e.Type, "topics_0_type");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Index)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("index");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TrainedCharaTradeItem>(entity =>
            {
                entity.ToTable("trained_chara_trade_item");

                entity.HasIndex(e => e.TrainedCharaRank, "trained_chara_trade_item_0_trained_chara_rank")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.TradeItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trade_item_category");

                entity.Property(e => e.TradeItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trade_item_id");

                entity.Property(e => e.TradeItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trade_item_num");

                entity.Property(e => e.TrainedCharaRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trained_chara_rank");
            });

            modelBuilder.Entity<TrainingChallengeExam>(entity =>
            {
                entity.ToTable("training_challenge_exam");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ExellentScore)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exellent_score");

                entity.Property(e => e.ExellentScoreRewardCoin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exellent_score_reward_coin");

                entity.Property(e => e.FeatureType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("feature_type");

                entity.Property(e => e.GoodScore)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("good_score");

                entity.Property(e => e.GoodScoreRewardCoin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("good_score_reward_coin");

                entity.Property(e => e.GreatScore)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("great_score");

                entity.Property(e => e.GreatScoreRewardCoin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("great_score_reward_coin");

                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_1");

                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_2");

                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_3");

                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_4");

                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category_5");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id_5");

                entity.Property(e => e.ItemNum1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num_5");

                entity.Property(e => e.ScoreGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("score_group_id");
            });

            modelBuilder.Entity<TrainingChallengeMaster>(entity =>
            {
                entity.ToTable("training_challenge_master");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndResultDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_result_date");

                entity.Property(e => e.ExExamId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ex_exam_id");

                entity.Property(e => e.ExamId1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exam_id_1");

                entity.Property(e => e.ExamId2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exam_id_2");

                entity.Property(e => e.ExamId3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exam_id_3");

                entity.Property(e => e.ExamId4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exam_id_4");

                entity.Property(e => e.ExamId5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("exam_id_5");

                entity.Property(e => e.FreeExamId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("free_exam_id");

                entity.Property(e => e.ShopId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("shop_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.StartResultDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_result_date");

                entity.Property(e => e.TargetMainScenario)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_main_scenario");
            });

            modelBuilder.Entity<TrainingChallengeScore>(entity =>
            {
                entity.ToTable("training_challenge_score");

                entity.HasIndex(e => e.ScoreGroupId, "training_challenge_score_0_score_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BonusScore)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bonus_score");

                entity.Property(e => e.Data)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("data");

                entity.Property(e => e.DispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("disp_order");

                entity.Property(e => e.RewardCoin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_coin");

                entity.Property(e => e.ScoreGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("score_group_id");

                entity.Property(e => e.ScoreType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("score_type");
            });

            modelBuilder.Entity<TrainingChallengeTotalScore>(entity =>
            {
                entity.ToTable("training_challenge_total_score");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.RewardCoin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_coin");

                entity.Property(e => e.TotalScore)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_score");
            });

            modelBuilder.Entity<TrainingCuttCharaData>(entity =>
            {
                entity.ToTable("training_cutt_chara_data");

                entity.HasIndex(e => new { e.CommandId, e.SubId }, "training_cutt_chara_data_0_command_id_1_sub_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CharaNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_num");

                entity.Property(e => e.CommandId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_id");

                entity.Property(e => e.PropTarget)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("prop_target");

                entity.Property(e => e.SubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_id");

                entity.Property(e => e.TargetListIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_list_index");

                entity.Property(e => e.TargetTimeline)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_timeline");
            });

            modelBuilder.Entity<TrainingCuttData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("training_cutt_data");

                entity.HasIndex(e => new { e.CommandId, e.SubId }, "training_cutt_data_0_command_id_1_sub_id");

                entity.Property(e => e.CharaNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_num");

                entity.Property(e => e.CommandId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("command_id");

                entity.Property(e => e.CuttIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cutt_index");

                entity.Property(e => e.SubId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sub_id");

                entity.Property(e => e.SuccessFlg)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("success_flg");

                entity.Property(e => e.TargetCharaIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_chara_index");

                entity.Property(e => e.TargetValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_value");
            });

            modelBuilder.Entity<TransferEventData>(entity =>
            {
                entity.HasKey(e => e.TransferEventId)
                    .HasName("PRIMARY");

                entity.ToTable("transfer_event_data");

                entity.Property(e => e.TransferEventId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("transfer_event_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.PreStartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("pre_start_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<TransferEventDetail>(entity =>
            {
                entity.HasKey(e => e.TransferDetailId)
                    .HasName("PRIMARY");

                entity.ToTable("transfer_event_detail");

                entity.Property(e => e.TransferDetailId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("transfer_detail_id");

                entity.Property(e => e.Condition1Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition1_type");

                entity.Property(e => e.Condition1Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition1_value1");

                entity.Property(e => e.Condition1Value2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition1_value2");

                entity.Property(e => e.Condition2Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition2_type");

                entity.Property(e => e.Condition2Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition2_value1");

                entity.Property(e => e.Condition2Value2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition2_value2");

                entity.Property(e => e.Condition3Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition3_type");

                entity.Property(e => e.Condition3Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition3_value1");

                entity.Property(e => e.Condition3Value2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition3_value2");

                entity.Property(e => e.Condition4Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition4_type");

                entity.Property(e => e.Condition4Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition4_value1");

                entity.Property(e => e.Condition4Value2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition4_value2");

                entity.Property(e => e.Condition5Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition5_type");

                entity.Property(e => e.Condition5Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition5_value1");

                entity.Property(e => e.Condition5Value2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition5_value2");

                entity.Property(e => e.CoolTime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cool_time");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("difficulty");

                entity.Property(e => e.EndDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("end_date");

                entity.Property(e => e.LimitedType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limited_type");

                entity.Property(e => e.StartDate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("start_date");

                entity.Property(e => e.TrainerType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("trainer_type");

                entity.Property(e => e.TransferEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transfer_event_id");
            });

            modelBuilder.Entity<TransferEventReward>(entity =>
            {
                entity.HasKey(e => e.TransferRewardId)
                    .HasName("PRIMARY");

                entity.ToTable("transfer_event_reward");

                entity.Property(e => e.TransferRewardId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("transfer_reward_id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.Odds)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("odds");

                entity.Property(e => e.RewardRank)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("reward_rank");

                entity.Property(e => e.TransferDetailId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("transfer_detail_id");
            });

            modelBuilder.Entity<TutorialGuideData>(entity =>
            {
                entity.ToTable("tutorial_guide_data");

                entity.HasIndex(e => e.GroupId, "tutorial_guide_data_0_group_id");

                entity.HasIndex(e => new { e.GroupId, e.PageIndex }, "tutorial_guide_data_0_group_id_1_page_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.ImageIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("image_index");

                entity.Property(e => e.PageIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("page_index");
            });
            #endregion

            #region Views
            modelBuilder.Entity<BasicCardDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_card_data_info");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("card_name");

                entity.Property(e => e.CardNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("card_name_english");

                entity.Property(e => e.CardTitle)
                    .HasColumnType("text")
                    .HasColumnName("card_title");

                entity.Property(e => e.CardTitleEnglish)
                    .HasColumnType("text")
                    .HasColumnName("card_title_english");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DefaultRarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_rarity");

                entity.Property(e => e.LimitedChara)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limited_chara");

                entity.Property(e => e.TalentGuts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_guts");

                entity.Property(e => e.TalentPow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_pow");

                entity.Property(e => e.TalentSpeed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_speed");

                entity.Property(e => e.TalentStamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_stamina");

                entity.Property(e => e.TalentWiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_wiz");
            });

            modelBuilder.Entity<BasicCharaDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_chara_data_info");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CharaCv)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chara_cv");

                entity.Property(e => e.CharaCvEnglish)
                    .HasColumnType("text")
                    .HasColumnName("chara_cv_english");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CharaName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chara_name");

                entity.Property(e => e.CharaNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("chara_name_english");

                entity.Property(e => e.CharaStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("chara_start_date");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<BasicDressDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_dress_data_info");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DressColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_main")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DressColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_sub")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.TextEnglish)
                    .HasColumnType("text")
                    .HasColumnName("text_english");
            });

            modelBuilder.Entity<BasicGachaDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_gacha_data_info");

                entity.Property(e => e.CardType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_type");

                entity.Property(e => e.CostSingle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_single");

                entity.Property(e => e.CostType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("cost_type");

                entity.Property(e => e.DailyPayCost)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("daily_pay_cost");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.FreeCampaignEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("free_campaign_end_date");

                entity.Property(e => e.FreeCampaignStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("free_campaign_start_date");

                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");

                entity.Property(e => e.GachaText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("gacha_text");

                entity.Property(e => e.GachaTextEnglish)
                    .HasColumnType("text")
                    .HasColumnName("gacha_text_english");

                entity.Property(e => e.OnlyOnceFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("only_once_flag");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<BasicGiftMessageInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_gift_message_info");

                entity.Property(e => e.GiftMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("gift_message");

                entity.Property(e => e.GiftMessageEnglish)
                    .HasColumnType("text")
                    .HasColumnName("gift_message_english");

                entity.Property(e => e.GiftMessageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gift_message_id");
            });

            modelBuilder.Entity<BasicItemDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_item_data_info");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("item_name_english");

                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_place_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<BasicItemExchangeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_item_exchange_info");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.ItemExchangeCondition)
                    .HasColumnType("text")
                    .HasColumnName("item_exchange_condition");

                entity.Property(e => e.ItemExchangeConditionEnglish)
                    .HasColumnType("text")
                    .HasColumnName("item_exchange_condition_english");

                entity.Property(e => e.ItemExchangeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_id");

                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_exchange_top_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<BasicItemExchangeTopInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_item_exchange_top_info");

                entity.Property(e => e.ItemExchangeDescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_exchange_description");

                entity.Property(e => e.ItemExchangeDescriptionEnglish)
                    .HasColumnType("text")
                    .HasColumnName("item_exchange_description_english");

                entity.Property(e => e.ItemExchangeDispOrder)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_exchange_disp_order");

                entity.Property(e => e.ItemExchangeName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_exchange_name");

                entity.Property(e => e.ItemExchangeNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("item_exchange_name_english");

                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_top_id");
            });

            modelBuilder.Entity<BasicLiveDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_live_data_info");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");

                entity.Property(e => e.SongName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("song_name");

                entity.Property(e => e.SongNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("song_name_english");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<BasicLoginBonusDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_login_bonus_data_info");

                entity.Property(e => e.CountNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("count_num");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.LoginBonusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("login_bonus_id");

                entity.Property(e => e.LoginBonusName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("login_bonus_name");

                entity.Property(e => e.LoginBonusNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("login_bonus_name_english");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.Type)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<BasicMainStoryDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_main_story_data_info");

                entity.Property(e => e.EpisodeIndex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("episode_index");

                entity.Property(e => e.MainStoryEpisodeTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("main_story_episode_title");

                entity.Property(e => e.MainStoryEpisodeTitleEnglish)
                    .HasColumnType("text")
                    .HasColumnName("main_story_episode_title_english");

                entity.Property(e => e.MainStoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_story_id");

                entity.Property(e => e.PartId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("part_id");

                entity.Property(e => e.StoryNumber)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_number");
            });

            modelBuilder.Entity<BasicMissionDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_mission_data_info");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.MissionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mission_id");

                entity.Property(e => e.MissionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mission_name");

                entity.Property(e => e.MissionNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("mission_name_english");

                entity.Property(e => e.MissionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mission_type");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<BasicMobDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_mob_data_info");

                entity.Property(e => e.CharaFaceModel)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_face_model");

                entity.Property(e => e.CharaHairColor)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_hair_color");

                entity.Property(e => e.CharaHairModel)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_hair_model");

                entity.Property(e => e.DressColorId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_color_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");

                entity.Property(e => e.MobName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mob_name");

                entity.Property(e => e.MobNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("mob_name_english");
            });

            modelBuilder.Entity<BasicPieceDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_piece_data_info");

                entity.Property(e => e.CharacterPieceName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("character_piece_name");

                entity.Property(e => e.CharacterPieceNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("character_piece_name_english");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_place_id");

                entity.Property(e => e.PieceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("piece_id");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<BasicRaceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_race_info");

                entity.Property(e => e.RaceCourseSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_course_set");

                entity.Property(e => e.RaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_id");

                entity.Property(e => e.RaceName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_name");

                entity.Property(e => e.RaceNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("race_name_english");
            });

            modelBuilder.Entity<BasicRaceInstanceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_race_instance_info");

                entity.Property(e => e.RaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceInstanceName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_instance_name");

                entity.Property(e => e.RaceInstanceNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("race_instance_name_english");
            });

            modelBuilder.Entity<BasicRaceTrackInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_race_track_info");

                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");

                entity.Property(e => e.RaceTrackName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_track_name");

                entity.Property(e => e.RaceTrackNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("race_track_name_english");
            });

            modelBuilder.Entity<BasicSingleModeCharaGradeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_single_mode_chara_grade_info");

                entity.Property(e => e.NeedFanCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_fan_count");

                entity.Property(e => e.RunNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("run_num");

                entity.Property(e => e.SingleModeCharaGradeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("single_mode_chara_grade_id");

                entity.Property(e => e.SingleModeCharaGradeName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("single_mode_chara_grade_name");

                entity.Property(e => e.SingleModeCharaGradeNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("single_mode_chara_grade_name_english");

                entity.Property(e => e.WinNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("win_num");
            });

            modelBuilder.Entity<BasicSkillDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_skill_data_info");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_category");

                entity.Property(e => e.SkillDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_desc");

                entity.Property(e => e.SkillDescEnglish)
                    .HasColumnType("text")
                    .HasColumnName("skill_desc_english");

                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_name");

                entity.Property(e => e.SkillNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("skill_name_english");
            });

            modelBuilder.Entity<BasicStoryEventDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_story_event_data_info");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ending_date");

                entity.Property(e => e.MiddleDate01)
                    .HasColumnType("datetime")
                    .HasColumnName("middle_date_01");

                entity.Property(e => e.MiddleDate02)
                    .HasColumnType("datetime")
                    .HasColumnName("middle_date_02");

                entity.Property(e => e.NoticeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("notice_date");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.StoryEventTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("story_event_title");

                entity.Property(e => e.StoryEventTitleEnglish)
                    .HasColumnType("text")
                    .HasColumnName("story_event_title_english");
            });

            modelBuilder.Entity<BasicStoryEventMissionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_story_event_mission_info");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_num");

                entity.Property(e => e.MissionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mission_type");

                entity.Property(e => e.StepGroupId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("step_group_id");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.StoryEventMissionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_mission_id");

                entity.Property(e => e.StoryEventMissionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("story_event_mission_name");

                entity.Property(e => e.StoryEventMissionNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("story_event_mission_name_english");
            });

            modelBuilder.Entity<BasicStoryEventStoryDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_story_event_story_data_info");

                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("episode_index_id");

                entity.Property(e => e.NeedPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_point");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEventEpisodeTitleEnglish)
                    .HasColumnType("text")
                    .HasColumnName("story_event_episode_title_english");

                entity.Property(e => e.StoryEventEpisodeTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("story_event_episode_title");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.StoryEventStoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_story_id");
            });

            modelBuilder.Entity<BasicSupportCardDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_support_card_data_info");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");

                entity.Property(e => e.SupportCardName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("support_card_name");

                entity.Property(e => e.SupportCardNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("support_card_name_english");

                entity.Property(e => e.SupportCardTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("support_card_title");

                entity.Property(e => e.SupportCardTitleEnglish)
                    .HasColumnType("text")
                    .HasColumnName("support_card_title_english");
            });

            modelBuilder.Entity<BasicSupportCardUniqueEffectInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_support_card_unique_effect_info");

                entity.Property(e => e.Lv)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lv");

                entity.Property(e => e.ScoreBonusName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("score_bonus_name");

                entity.Property(e => e.ScoreBonusNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("score_bonus_name_english");

                entity.Property(e => e.SupportCardUniqueEffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_unique_effect_id");

                entity.Property(e => e.Type0)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_0");

                entity.Property(e => e.Type1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("type_1");

                entity.Property(e => e.Value0)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_0");

                entity.Property(e => e.Value1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("value_1");
            });

            modelBuilder.Entity<BasicTeamStadiumScoreBonusInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_team_stadium_score_bonus_info");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.Priority)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("priority");

                entity.Property(e => e.ScoreBonusName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("score_bonus_name");

                entity.Property(e => e.ScoreBonusNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("score_bonus_name_english");

                entity.Property(e => e.ScoreRate)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("score_rate");

                entity.Property(e => e.TeamStadiumScoreBonusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_stadium_score_bonus_id");
            });

            modelBuilder.Entity<BasicTextDataEnglish>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_text_data_english");

                entity.Property(e => e.Category)
                    .HasColumnType("int(11)")
                    .HasColumnName("category");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Index)
                    .HasColumnType("int(11)")
                    .HasColumnName("index");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Translation)
                    .HasColumnType("text")
                    .HasColumnName("translation");
            });

            modelBuilder.Entity<CondensedSkillDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_condensed_skill_data_info");

                entity.Property(e => e.AbilityType11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_1");

                entity.Property(e => e.AbilityType12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_2");

                entity.Property(e => e.AbilityType13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_3");

                entity.Property(e => e.AbilityType21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_1");

                entity.Property(e => e.AbilityType22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_2");

                entity.Property(e => e.AbilityType23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_3");

                entity.Property(e => e.CardIds)
                    .HasColumnType("mediumtext")
                    .HasColumnName("card_ids");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FloatAbilityTime1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_time_1");

                entity.Property(e => e.FloatAbilityTime2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_time_2");

                entity.Property(e => e.FloatAbilityValue11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_1");

                entity.Property(e => e.FloatAbilityValue12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_2");

                entity.Property(e => e.FloatAbilityValue13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_3");

                entity.Property(e => e.FloatAbilityValue21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_1");

                entity.Property(e => e.FloatAbilityValue22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_2");

                entity.Property(e => e.FloatAbilityValue23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_3");

                entity.Property(e => e.GradeValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade_value");

                entity.Property(e => e.IconId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("icon_id");

                entity.Property(e => e.NeedSkillPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_skill_point");

                entity.Property(e => e.PopularityAddParam1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_param_1");

                entity.Property(e => e.PopularityAddParam2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_param_2");

                entity.Property(e => e.PopularityAddValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_value_1");

                entity.Property(e => e.PopularityAddValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_value_2");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_category");

                entity.Property(e => e.SkillDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_desc");

                entity.Property(e => e.SkillDescEnglish)
                    .HasColumnType("text")
                    .HasColumnName("skill_desc_english");

                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_name");

                entity.Property(e => e.SkillNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("skill_name_english");

                entity.Property(e => e.SupportCardIds)
                    .HasColumnType("mediumtext")
                    .HasColumnName("support_card_ids");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tag_id")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<NiceErrorMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_error_messages");

                entity.Property(e => e.ErrorId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("error_id");

                entity.Property(e => e.ErrorIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("error_index");

                entity.Property(e => e.ErrorText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("error_text");

                entity.Property(e => e.ErrorTextEnglish)
                    .HasColumnType("text")
                    .HasColumnName("error_text_english");
            });

            modelBuilder.Entity<NiceCardDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_card_data_info");

                entity.Property(e => e.AptitudeBetweener)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_betweener");

                entity.Property(e => e.AptitudeChaser)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_chaser");

                entity.Property(e => e.AptitudeDirt)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_dirt");

                entity.Property(e => e.AptitudeLeader)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_leader");

                entity.Property(e => e.AptitudeLong)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_long");

                entity.Property(e => e.AptitudeMiddle)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_middle");

                entity.Property(e => e.AptitudeMile)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_mile");

                entity.Property(e => e.AptitudeRunner)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_runner");

                entity.Property(e => e.AptitudeShort)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_short");

                entity.Property(e => e.AptitudeTurf)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("aptitude_turf");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DefaultRarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("default_rarity");

                entity.Property(e => e.Guts1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts1");

                entity.Property(e => e.Guts2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts2");

                entity.Property(e => e.Guts3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts3");

                entity.Property(e => e.Guts4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts4");

                entity.Property(e => e.Guts5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("guts5");

                entity.Property(e => e.LimitedChara)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("limited_chara");

                entity.Property(e => e.Power1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("power1");

                entity.Property(e => e.Power2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("power2");

                entity.Property(e => e.Power3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("power3");

                entity.Property(e => e.Power4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("power4");

                entity.Property(e => e.Power5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("power5");

                entity.Property(e => e.Speed1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed1");

                entity.Property(e => e.Speed2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed2");

                entity.Property(e => e.Speed3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed3");

                entity.Property(e => e.Speed4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed4");

                entity.Property(e => e.Speed5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("speed5");

                entity.Property(e => e.Stamina1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina1");

                entity.Property(e => e.Stamina2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina2");

                entity.Property(e => e.Stamina3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina3");

                entity.Property(e => e.Stamina4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina4");

                entity.Property(e => e.Stamina5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("stamina5");

                entity.Property(e => e.TalentGuts)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_guts");

                entity.Property(e => e.TalentPow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_pow");

                entity.Property(e => e.TalentSpeed)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_speed");

                entity.Property(e => e.TalentStamina)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_stamina");

                entity.Property(e => e.TalentWiz)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("talent_wiz");

                entity.Property(e => e.Wisdom1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wisdom1");

                entity.Property(e => e.Wisdom2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wisdom2");

                entity.Property(e => e.Wisdom3)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wisdom3");

                entity.Property(e => e.Wisdom4)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wisdom4");

                entity.Property(e => e.Wisdom5)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("wisdom5");
            });

            modelBuilder.Entity<NiceCharaBioInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_chara_bio_info");

                entity.Property(e => e.AttachmentModelId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("attachment_model_id");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("birth_month");

                entity.Property(e => e.BirthYear)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("birth_year");

                entity.Property(e => e.Bust)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("bust");

                entity.Property(e => e.CharaCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_category");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.EarRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ear_random_time_max");

                entity.Property(e => e.EarRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ear_random_time_min");

                entity.Property(e => e.Height)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("height");

                entity.Property(e => e.ImageColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_main")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ImageColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_sub")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MiniMayuShaderType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mini_mayu_shader_type");

                entity.Property(e => e.PersonalDress)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("personal_dress");

                entity.Property(e => e.RaceRunningType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_running_type");

                entity.Property(e => e.Scale)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("scale");

                entity.Property(e => e.Sex)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sex");

                entity.Property(e => e.Shape)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("shape");

                entity.Property(e => e.Skin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skin");

                entity.Property(e => e.Socks)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("socks");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEarRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_ear_random_time_max");

                entity.Property(e => e.StoryEarRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_ear_random_time_min");

                entity.Property(e => e.StoryTailRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_tail_random_time_max");

                entity.Property(e => e.StoryTailRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("story_tail_random_time_min");

                entity.Property(e => e.TailModelId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_model_id");

                entity.Property(e => e.TailRandomTimeMax)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_random_time_max");

                entity.Property(e => e.TailRandomTimeMin)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tail_random_time_min");

                entity.Property(e => e.UiBorderColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_border_color")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_main")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_sub")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNameplateColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNameplateColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNumColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiNumColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiSpeechColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiSpeechColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiTrainingColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiTrainingColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiTurnColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_turn_color")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiWipeColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiWipeColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UiWipeColor3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_3")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UraObjectives)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ura_objectives");
            });

            modelBuilder.Entity<NiceItemNamesCommentsInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_item_names_comments_info");

                entity.Property(e => e.ItemComment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_comment");

                entity.Property(e => e.ItemComment2)
                    .HasColumnType("text")
                    .HasColumnName("item_comment_2");

                entity.Property(e => e.ItemComment2English)
                    .HasColumnType("text")
                    .HasColumnName("item_comment_2_english");

                entity.Property(e => e.ItemCommentEnglish)
                    .HasColumnType("text")
                    .HasColumnName("item_comment_english");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("item_name_english");
            });

            modelBuilder.Entity<NiceObjectivesInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_objectives_info");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.DetermineRace)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("determine_race");

                entity.Property(e => e.DetermineRaceFlag)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("determine_race_flag");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceSetId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_set_id");

                entity.Property(e => e.RaceType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_type");

                entity.Property(e => e.RouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("route_id");

                entity.Property(e => e.SortId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("sort_id");

                entity.Property(e => e.TargetType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("target_type");

                entity.Property(e => e.Turn)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<NiceRaceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_race_info");

                entity.Property(e => e.Class)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("class");

                entity.Property(e => e.Course)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course");

                entity.Property(e => e.CourseSet)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("course_set");

                entity.Property(e => e.Direction)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("direction");

                entity.Property(e => e.Distance)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("distance");

                entity.Property(e => e.EntryNum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("entry_num");

                entity.Property(e => e.FanCount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("fan_count");

                entity.Property(e => e.Grade)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade");

                entity.Property(e => e.Group)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("group");

                entity.Property(e => e.Half)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("half");

                entity.Property(e => e.Month)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("month");

                entity.Property(e => e.RaceId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("race_track_id");

                entity.Property(e => e.RequiredFans)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("required_fans");

                entity.Property(e => e.Terrain)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("terrain");
            });

            modelBuilder.Entity<NiceSkillDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_skill_data_info");

                entity.Property(e => e.AbilityType11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_1");

                entity.Property(e => e.AbilityType12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_2");

                entity.Property(e => e.AbilityType13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_1_3");

                entity.Property(e => e.AbilityType21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_1");

                entity.Property(e => e.AbilityType22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_2");

                entity.Property(e => e.AbilityType23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("ability_type_2_3");

                entity.Property(e => e.CardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("card_id");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FloatAbilityTime1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_time_1");

                entity.Property(e => e.FloatAbilityTime2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_time_2");

                entity.Property(e => e.FloatAbilityValue11)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_1");

                entity.Property(e => e.FloatAbilityValue12)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_2");

                entity.Property(e => e.FloatAbilityValue13)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_1_3");

                entity.Property(e => e.FloatAbilityValue21)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_1");

                entity.Property(e => e.FloatAbilityValue22)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_2");

                entity.Property(e => e.FloatAbilityValue23)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("float_ability_value_2_3");

                entity.Property(e => e.GradeValue)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("grade_value");

                entity.Property(e => e.IconId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("icon_id");

                entity.Property(e => e.NeedSkillPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("need_skill_point");

                entity.Property(e => e.PopularityAddParam1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_param_1");

                entity.Property(e => e.PopularityAddParam2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_param_2");

                entity.Property(e => e.PopularityAddValue1)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_value_1");

                entity.Property(e => e.PopularityAddValue2)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("popularity_add_value_2");

                entity.Property(e => e.Rarity)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillCategory)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("skill_category");

                entity.Property(e => e.SkillDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_desc");

                entity.Property(e => e.SkillDescEnglish)
                    .HasColumnType("text")
                    .HasColumnName("skill_desc_english");

                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_name");

                entity.Property(e => e.SkillNameEnglish)
                    .HasColumnType("text")
                    .HasColumnName("skill_name_english");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("support_card_id");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tag_id")
                    .UseCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<NiceSuccessionRelationMemberType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_succession_relation_member_types");

                entity.Property(e => e.CharaId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.RelationPoint)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("relation_point");

                entity.Property(e => e.RelationType)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("relation_type");

                entity.Property(e => e.SrmId)
                    .HasColumnType("int(11)")
                    .HasColumnName("srm_id");
            });

            modelBuilder.Entity<NiceTutorialMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_tutorial_messages");

                entity.Property(e => e.TutorialId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("tutorial_id");

                entity.Property(e => e.TutorialIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("tutorial_index");

                entity.Property(e => e.TutorialText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tutorial_text");

                entity.Property(e => e.TutorialTextEnglish)
                    .HasColumnType("text")
                    .HasColumnName("tutorial_text_english");
            });
            #endregion

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

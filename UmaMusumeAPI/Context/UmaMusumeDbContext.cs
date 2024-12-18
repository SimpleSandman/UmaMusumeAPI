﻿using System;

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
        public virtual DbSet<AudienceData> AudienceData { get; set; }
        public virtual DbSet<AudienceDressColorSet> AudienceDressColorSets { get; set; }
        public virtual DbSet<AudienceHairColorSet> AudienceHairColorSets { get; set; }
        public virtual DbSet<AudienceImpostor> AudienceImpostors { get; set; }
        public virtual DbSet<AudienceImpostorColorSet> AudienceImpostorColorSets { get; set; }
        public virtual DbSet<AudienceImpostorLottery> AudienceImpostorLotteries { get; set; }
        public virtual DbSet<AudioCuesheet> AudioCuesheets { get; set; }
        public virtual DbSet<AudioIgnoredCueOnHighspeed> AudioIgnoredCueOnHighspeeds { get; set; }
        public virtual DbSet<AudioStoryEffect> AudioStoryEffects { get; set; }
        public virtual DbSet<AvailableSkillSet> AvailableSkillSets { get; set; }
        public virtual DbSet<BackgroundData> BackgroundData { get; set; }
        public virtual DbSet<BackgroundOffsetData> BackgroundOffsetData { get; set; }
        public virtual DbSet<BannerData> BannerData { get; set; }
        public virtual DbSet<CampaignCharaStorySchedule> CampaignCharaStorySchedules { get; set; }
        public virtual DbSet<CampaignCuttData> CampaignCuttData { get; set; }
        public virtual DbSet<CampaignData> CampaignData { get; set; }
        public virtual DbSet<CampaignNPresentBonusData> CampaignNPresentBonusData { get; set; }
        public virtual DbSet<CampaignPresentBonusDetail> CampaignPresentBonusDetails { get; set; }
        public virtual DbSet<CampaignRentalSupportCard> CampaignRentalSupportCards { get; set; }
        public virtual DbSet<CampaignRentalSupportData> CampaignRentalSupportData { get; set; }
        public virtual DbSet<CampaignSingleRaceAddData> CampaignSingleRaceAddData { get; set; }
        public virtual DbSet<CampaignSingleRaceAddReward> CampaignSingleRaceAddRewards { get; set; }
        public virtual DbSet<CampaignSpPresentBonusData> CampaignSpPresentBonusData { get; set; }
        public virtual DbSet<CampaignStoryData> CampaignStoryData { get; set; }
        public virtual DbSet<CampaignSwapMotionData> CampaignSwapMotionData { get; set; }
        public virtual DbSet<CampaignWalkingChara> CampaignWalkingCharas { get; set; }
        public virtual DbSet<CampaignWalkingData> CampaignWalkingData { get; set; }
        public virtual DbSet<CampaignWalkingFriend> CampaignWalkingFriends { get; set; }
        public virtual DbSet<CampaignWalkingLocation> CampaignWalkingLocations { get; set; }
        public virtual DbSet<CampaignWalkingRewardSet> CampaignWalkingRewardSets { get; set; }
        public virtual DbSet<CardData> CardData { get; set; }
        public virtual DbSet<CardRarityData> CardRarityData { get; set; }
        public virtual DbSet<CardTalentHintUpgrade> CardTalentHintUpgrades { get; set; }
        public virtual DbSet<CardTalentUpgrade> CardTalentUpgrades { get; set; }
        public virtual DbSet<ChallengeMatchBossNpc> ChallengeMatchBossNpcs { get; set; }
        public virtual DbSet<ChallengeMatchData> ChallengeMatchData { get; set; }
        public virtual DbSet<ChallengeMatchRace> ChallengeMatchRaces { get; set; }
        public virtual DbSet<ChallengeMatchRawPoint> ChallengeMatchRawPoints { get; set; }
        public virtual DbSet<ChampionsBgm> ChampionsBgms { get; set; }
        public virtual DbSet<ChampionsEntryReward> ChampionsEntryRewards { get; set; }
        public virtual DbSet<ChampionsEvaluationRate> ChampionsEvaluationRates { get; set; }
        public virtual DbSet<ChampionsNewsCharaComment> ChampionsNewsCharaComments { get; set; }
        public virtual DbSet<ChampionsNewsRace> ChampionsNewsRaces { get; set; }
        public virtual DbSet<ChampionsNewsTitle> ChampionsNewsTitles { get; set; }
        public virtual DbSet<ChampionsNewsWinComment> ChampionsNewsWinComments { get; set; }
        public virtual DbSet<ChampionsNewsWinTitle> ChampionsNewsWinTitles { get; set; }
        public virtual DbSet<ChampionsRaceCondition> ChampionsRaceConditions { get; set; }
        public virtual DbSet<ChampionsRewardRate> ChampionsRewardRates { get; set; }
        public virtual DbSet<ChampionsRoundDetail> ChampionsRoundDetails { get; set; }
        public virtual DbSet<ChampionsRoundSchedule> ChampionsRoundSchedules { get; set; }
        public virtual DbSet<ChampionsSchedule> ChampionsSchedules { get; set; }
        public virtual DbSet<ChampionsStandMotion> ChampionsStandMotions { get; set; }
        public virtual DbSet<CharaCategoryMotion> CharaCategoryMotions { get; set; }
        public virtual DbSet<CharaDataGroup> CharaDataGroups { get; set; }
        public virtual DbSet<CharaData> CharaData { get; set; }
        public virtual DbSet<CharaDressColorSet> CharaDressColorSets { get; set; }
        public virtual DbSet<CharaDressColorSetDefault> CharaDressColorSetDefaults { get; set; }
        public virtual DbSet<CharaMotionAct> CharaMotionActs { get; set; }
        public virtual DbSet<CharaMotionSet> CharaMotionSets { get; set; }
        public virtual DbSet<CharaStoryData> CharaStoryData { get; set; }
        public virtual DbSet<CharaType> CharaTypes { get; set; }
        public virtual DbSet<CharacterPropAnimation> CharacterPropAnimations { get; set; }
        public virtual DbSet<CharacterSystemLottery> CharacterSystemLotteries { get; set; }
        public virtual DbSet<CharacterSystemText> CharacterSystemTexts { get; set; }
        public virtual DbSet<CircleRankData> CircleRankData { get; set; }
        public virtual DbSet<CircleStampData> CircleStampData { get; set; }
        public virtual DbSet<CollectEventMapBgData> CollectEventMapBgData { get; set; }
        public virtual DbSet<CollectEventMapMaster> CollectEventMapMasters { get; set; }
        public virtual DbSet<CollectRaidAllReward> CollectRaidAllRewards { get; set; }
        public virtual DbSet<CollectRaidDressColor> CollectRaidDressColors { get; set; }
        public virtual DbSet<CollectRaidIndividualReward> CollectRaidIndividualRewards { get; set; }
        public virtual DbSet<CollectRaidMaster> CollectRaidMasters { get; set; }
        public virtual DbSet<CollectRaidMission> CollectRaidMissions { get; set; }
        public virtual DbSet<CollectRaidMissionTopChara> CollectRaidMissionTopCharas { get; set; }
        public virtual DbSet<CollectRaidSegmentCutt> CollectRaidSegmentCutts { get; set; }
        public virtual DbSet<CollectRaidStagingMiniChara> CollectRaidStagingMiniCharas { get; set; }
        public virtual DbSet<CollectRaidStory> CollectRaidStories { get; set; }
        public virtual DbSet<CollectRaidTopData> CollectRaidTopData { get; set; }
        public virtual DbSet<CraneGameArmSwing> CraneGameArmSwings { get; set; }
        public virtual DbSet<CraneGameCatchResult> CraneGameCatchResults { get; set; }
        public virtual DbSet<CraneGameDefineParam> CraneGameDefineParams { get; set; }
        public virtual DbSet<CraneGameExtraOddsCondition> CraneGameExtraOddsConditions { get; set; }
        public virtual DbSet<CraneGameHiddenOdd> CraneGameHiddenOdds { get; set; }
        public virtual DbSet<CraneGamePrizeFace> CraneGamePrizeFaces { get; set; }
        public virtual DbSet<CraneGamePrizePattern> CraneGamePrizePatterns { get; set; }
        public virtual DbSet<CraneGameProp> CraneGameProps { get; set; }
        public virtual DbSet<DailyLegendRace> DailyLegendRaces { get; set; }
        public virtual DbSet<DailyPack> DailyPacks { get; set; }
        public virtual DbSet<DailyRace> DailyRaces { get; set; }
        public virtual DbSet<DailyRaceBilling> DailyRaceBillings { get; set; }
        public virtual DbSet<DailyRaceNpc> DailyRaceNpcs { get; set; }
        public virtual DbSet<DeckRecommendException> DeckRecommendExceptions { get; set; }
        public virtual DbSet<DeckRecommendLvCorrection> DeckRecommendLvCorrections { get; set; }
        public virtual DbSet<DeckRecommendOrganize> DeckRecommendOrganizes { get; set; }
        public virtual DbSet<Directory> Directories { get; set; }
        public virtual DbSet<DressData> DressData { get; set; }
        public virtual DbSet<EventMotionData> EventMotionData { get; set; }
        public virtual DbSet<EventMotionPlusData> EventMotionPlusData { get; set; }
        public virtual DbSet<ExchangeTicketDetail> ExchangeTicketDetails { get; set; }
        public virtual DbSet<FaceTypeData> FaceTypeData { get; set; }
        public virtual DbSet<FacialMouthChange> FacialMouthChanges { get; set; }
        public virtual DbSet<FactorResearchAnimationData> FactorResearchAnimationData { get; set; }
        public virtual DbSet<FactorResearchBox> FactorResearchBoxes { get; set; }
        public virtual DbSet<FactorResearchBoxReward> FactorResearchBoxRewards { get; set; }
        public virtual DbSet<FactorResearchData> FactorResearchData { get; set; }
        public virtual DbSet<FactorResearchFactorUpgrade> FactorResearchFactorUpgrades { get; set; }
        public virtual DbSet<FactorResearchTop> FactorResearchTops { get; set; }
        public virtual DbSet<FanRaidAllReward> FanRaidAllRewards { get; set; }
        public virtual DbSet<FanRaidBonusChara> FanRaidBonusCharas { get; set; }
        public virtual DbSet<FanRaidBonusSupportCard> FanRaidBonusSupportCards { get; set; }
        public virtual DbSet<FanRaidData> FanRaidData { get; set; }
        public virtual DbSet<FanRaidIndividualReward> FanRaidIndividualRewards { get; set; }
        public virtual DbSet<FanRaidStoryData> FanRaidStoryData { get; set; }
        public virtual DbSet<FanRaidTopChara> FanRaidTopCharas { get; set; }
        public virtual DbSet<FanRaidTopData> FanRaidTopData { get; set; }
        public virtual DbSet<GachaAvailable> GachaAvailables { get; set; }
        public virtual DbSet<GachaData> GachaData { get; set; }
        public virtual DbSet<GachaExchange> GachaExchanges { get; set; }
        public virtual DbSet<GachaFreeCampaign> GachaFreeCampaigns { get; set; }
        public virtual DbSet<GachaGroup> GachaGroups { get; set; }
        public virtual DbSet<GachaPiece> GachaPieces { get; set; }
        public virtual DbSet<GachaPrizeOdd> GachaPrizeOdds { get; set; }
        public virtual DbSet<GachaStepUp> GachaStepups { get; set; }
        public virtual DbSet<GachaTopBg> GachaTopBgs { get; set; }
        public virtual DbSet<GiftMessage> GiftMessages { get; set; }
        public virtual DbSet<HeroesData> HeroesData { get; set; }
        public virtual DbSet<HeroesFinalStageRace> HeroesFinalStageRaces { get; set; }
        public virtual DbSet<HeroesGauge> HeroesGauges { get; set; }
        public virtual DbSet<HeroesLeagueRank> HeroesLeagueRanks { get; set; }
        public virtual DbSet<HeroesLeagueRankRewardGroup> HeroesLeagueRankRewardGroups { get; set; }
        public virtual DbSet<HeroesLeagueScore> HeroesLeagueScores { get; set; }
        public virtual DbSet<HeroesLotteryMessage> HeroesLotteryMessages { get; set; }
        public virtual DbSet<HeroesRaceCondition> HeroesRaceConditions { get; set; }
        public virtual DbSet<HeroesRaceDefaultNpc> HeroesRaceDefaultNpcs { get; set; }
        public virtual DbSet<HeroesRaceDefaultUser> HeroesRaceDefaultUsers { get; set; }
        public virtual DbSet<HeroesRaceMobNpc> HeroesRaceMobNpcs { get; set; }
        public virtual DbSet<HeroesSkill> HeroesSkills { get; set; }
        public virtual DbSet<HeroesSkillItem> HeroesSkillItems { get; set; }
        public virtual DbSet<HeroesSkillMotion> HeroesSkillMotions { get; set; }
        public virtual DbSet<HeroesSpecialReward> HeroesSpecialRewards { get; set; }
        public virtual DbSet<HeroesStageSchedule> HeroesStageSchedules { get; set; }
        public virtual DbSet<HighlightInterpolate> HighlightInterpolates { get; set; }
        public virtual DbSet<HomeCharacterType> HomeCharacterTypes { get; set; }
        public virtual DbSet<HomeEat> HomeEats { get; set; }
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
        public virtual DbSet<ItemPlace> ItemPlaces { get; set; }
        public virtual DbSet<JobsGenre> JobsGenres { get; set; }
        public virtual DbSet<JobsPlace> JobsPlaces { get; set; }
        public virtual DbSet<JobsPointLimit> JobsPointLimits { get; set; }
        public virtual DbSet<JobsRandomDropReward> JobsRandomDropRewards { get; set; }
        public virtual DbSet<JobsReward> JobsRewards { get; set; }
        public virtual DbSet<JobsRewardSortDispOrder> JobsRewardSortDispOrders { get; set; }
        public virtual DbSet<JukeboxComment> JukeboxComments { get; set; }
        public virtual DbSet<JukeboxMotionData> JukeboxMotionData { get; set; }
        public virtual DbSet<JukeboxMusicData> JukeboxMusicData { get; set; }
        public virtual DbSet<JukeboxSetlistData> JukeboxSetlistData { get; set; }
        public virtual DbSet<JukeboxSetlistMusicData> JukeboxSetlistMusicData { get; set; }
        public virtual DbSet<JukeboxSetlistSingerData> JukeboxSetlistSingerData { get; set; }
        public virtual DbSet<LegendRace> LegendRaces { get; set; }
        public virtual DbSet<LegendRaceBilling> LegendRaceBillings { get; set; }
        public virtual DbSet<LegendRaceBossNpc> LegendRaceBossNpcs { get; set; }
        public virtual DbSet<LegendRaceCuttCharaData> LegendRaceCuttCharaData { get; set; }
        public virtual DbSet<LegendRaceNpc> LegendRaceNpcs { get; set; }
        public virtual DbSet<LiveData> LiveData { get; set; }
        public virtual DbSet<LiveExtraData> LiveExtraData { get; set; }
        public virtual DbSet<LivePermissionData> LivePermissionData { get; set; }
        public virtual DbSet<LoginBonusChara> LoginBonusCharas { get; set; }
        public virtual DbSet<LoginBonusData> LoginBonusData { get; set; }
        public virtual DbSet<LoginBonusDetail> LoginBonusDetails { get; set; }
        public virtual DbSet<LoveRank> LoveRanks { get; set; }
        public virtual DbSet<MainStoryData> MainStoryData { get; set; }
        public virtual DbSet<MainStoryPart> MainStoryParts { get; set; }
        public virtual DbSet<MainStoryRaceBonus> MainStoryRaceBonus { get; set; }
        public virtual DbSet<MainStoryRaceBonusCondition> MainStoryRaceBonusConditions { get; set; }
        public virtual DbSet<MainStoryRaceCharaData> MainStoryRaceCharaData { get; set; }
        public virtual DbSet<MainStoryRaceData> MainStoryRaceData { get; set; }
        public virtual DbSet<MapEventAreaData> MapEventAreaData { get; set; }
        public virtual DbSet<MapEventData> MapEventData { get; set; }
        public virtual DbSet<MapEventFlavorText> MapEventFlavorTexts { get; set; }
        public virtual DbSet<MapEventMapPoint> MapEventMapPoints { get; set; }
        public virtual DbSet<MapEventMiniMotion> MapEventMiniMotions { get; set; }
        public virtual DbSet<MapEventStoryData> MapEventStoryData { get; set; }
        public virtual DbSet<MetaA> MetaAs { get; set; }
        public virtual DbSet<MetaC> MetaCs { get; set; }
        public virtual DbSet<MetaI> MetaIs { get; set; }
        public virtual DbSet<MetaR> MetaRs { get; set; }
        public virtual DbSet<MiniBg> MiniBgs { get; set; }
        public virtual DbSet<MiniBgCharaMotion> MiniBgCharaMotions { get; set; }
        public virtual DbSet<MiniFaceTypeData> MiniFaceTypeData { get; set; }
        public virtual DbSet<MiniMob> MiniMobs { get; set; }
        public virtual DbSet<MiniMotionSet> MiniMotionSets { get; set; }
        public virtual DbSet<MiniMouthType> MiniMouthTypes { get; set; }
        public virtual DbSet<MissionData> MissionData { get; set; }
        public virtual DbSet<MissionRaceEquate> MissionRaceEquates { get; set; }
        public virtual DbSet<MissionRaceScenarioGroup> MissionRaceScenarioGroups { get; set; }
        public virtual DbSet<MobData> MobData { get; set; }
        public virtual DbSet<MobDressColorSet> MobDressColorSets { get; set; }
        public virtual DbSet<MobHairColorSet> MobHairColorSets { get; set; }
        public virtual DbSet<NameCardBg> NameCardBgs { get; set; }
        public virtual DbSet<NeedPieceNumData> NeedPieceNumData { get; set; }
        public virtual DbSet<Nickname> Nicknames { get; set; }
        public virtual DbSet<NoteProfile> NoteProfiles { get; set; }
        public virtual DbSet<NoteProfileTextType> NoteProfileTextTypes { get; set; }
        public virtual DbSet<PaidGachaButtonType> PaidGachaButtonTypes { get; set; }
        public virtual DbSet<PieceData> PieceData { get; set; }
        public virtual DbSet<PriceChange> PriceChanges { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<RaceBgm> RaceBgms { get; set; }
        public virtual DbSet<RaceBgmCutin> RaceBgmCutins { get; set; }
        public virtual DbSet<RaceBgmPattern> RaceBgmPatterns { get; set; }
        public virtual DbSet<RaceBibColor> RaceBibColors { get; set; }
        public virtual DbSet<RaceCondition> RaceConditions { get; set; }
        public virtual DbSet<RaceCourseSet> RaceCourseSets { get; set; }
        public virtual DbSet<RaceCourseSetStatus> RaceCourseSetStatuses { get; set; }
        public virtual DbSet<RaceEnvDefine> RaceEnvDefines { get; set; }
        public virtual DbSet<RaceFenceSet> RaceFenceSets { get; set; }
        public virtual DbSet<RaceInstance> RaceInstances { get; set; }
        public virtual DbSet<RaceJikkyoBase> RaceJikkyoBases { get; set; }
        public virtual DbSet<RaceJikkyoBaseVenus> RaceJikkyoBaseVenus { get; set; }
        public virtual DbSet<RaceJikkyoComment> RaceJikkyoComments { get; set; }
        public virtual DbSet<RaceJikkyoCue> RaceJikkyoCues { get; set; }
        public virtual DbSet<RaceJikkyoMessage> RaceJikkyoMessages { get; set; }
        public virtual DbSet<RaceJikkyoRace> RaceJikkyoRaces { get; set; }
        public virtual DbSet<RaceJikkyoTrigger> RaceJikkyoTriggers { get; set; }
        public virtual DbSet<RaceMotivationRate> RaceMotivationRates { get; set; }
        public virtual DbSet<RaceOverrunPattern> RaceOverrunPatterns { get; set; }
        public virtual DbSet<RacePlayerCamera> RacePlayerCameras { get; set; }
        public virtual DbSet<RaceProperDistanceRate> RaceProperDistanceRates { get; set; }
        public virtual DbSet<RaceProperGroundRate> RaceProperGroundRates { get; set; }
        public virtual DbSet<RaceProperRunningstyleRate> RaceProperRunningstyleRates { get; set; }
        public virtual DbSet<RaceSingleModeTeamStatus> RaceSingleModeTeamStatuses { get; set; }
        public virtual DbSet<RaceTrack> RaceTracks { get; set; }
        public virtual DbSet<RaceTrophy> RaceTrophies { get; set; }
        public virtual DbSet<RandomEarTailMotion> RandomEarTailMotions { get; set; }
        public virtual DbSet<RatingRaceCondition> RatingRaceConditions { get; set; }
        public virtual DbSet<RatingRaceData> RatingRaceData { get; set; }
        public virtual DbSet<RatingRaceFinaleReward> RatingRaceFinaleRewards { get; set; }
        public virtual DbSet<RatingRacePhaseSchedule> RatingRacePhaseSchedules { get; set; }
        public virtual DbSet<RatingRaceRatingRank> RatingRaceRatingRanks { get; set; }
        public virtual DbSet<RatingRaceRewardGroup> RatingRaceRewardGroups { get; set; }
        public virtual DbSet<RatingRaceWeekendReward> RatingRaceWeekendRewards { get; set; }
        public virtual DbSet<RoomMatchTrainingRank> RoomMatchTrainingRanks { get; set; }
        public virtual DbSet<SeasonData> SeasonData { get; set; }
        public virtual DbSet<SelectPickup> SelectPickups { get; set; }
        public virtual DbSet<ShortEpisode> ShortEpisodes { get; set; }
        public virtual DbSet<SingleMode09Board> SingleMode09Boards { get; set; }
        public virtual DbSet<SingleMode09Chip> SingleMode09Chips { get; set; }
        public virtual DbSet<SingleMode09ChipEffect> SingleMode09ChipEffects { get; set; }
        public virtual DbSet<SingleMode09LearningBonus> SingleMode09LearningBonus { get; set; }
        public virtual DbSet<SingleMode09LinkEffect> SingleMode09LinkEffects { get; set; }
        public virtual DbSet<SingleMode09ProgressRate> SingleMode09ProgressRates { get; set; }
        public virtual DbSet<SingleMode09Schedule> SingleMode09Schedules { get; set; }
        public virtual DbSet<SingleMode09TrainingBoost> SingleMode09TrainingBoosts { get; set; }
        public virtual DbSet<SingleModeAnalyzeCondition> SingleModeAnalyzeConditions { get; set; }
        public virtual DbSet<SingleModeAnalyzeMessage> SingleModeAnalyzeMessages { get; set; }
        public virtual DbSet<SingleModeAnalyzeTicket> SingleModeAnalyzeTickets { get; set; }
        public virtual DbSet<SingleModeAoOffset> SingleModeAoOffsets { get; set; }
        public virtual DbSet<SingleModeAoharuCuttType> SingleModeAoharuCuttTypes { get; set; }
        public virtual DbSet<SingleModeAoharuResultCutt> SingleModeAoharuResultCutts { get; set; }
        public virtual DbSet<SingleModeAoharuSchedule> SingleModeAoharuSchedules { get; set; }
        public virtual DbSet<SingleModeArcDebuff> SingleModeArcDebuffs { get; set; }
        public virtual DbSet<SingleModeArcPotential> SingleModeArcPotentials { get; set; }
        public virtual DbSet<SingleModeArcPotentialBonus> SingleModeArcPotentialBonus { get; set; }
        public virtual DbSet<SingleModeArcPotentialBuff> SingleModeArcPotentialBuffs { get; set; }
        public virtual DbSet<SingleModeArcPotentialCond> SingleModeArcPotentialConds { get; set; }
        public virtual DbSet<SingleModeArcPotentialLevel> SingleModeArcPotentialLevels { get; set; }
        public virtual DbSet<SingleModeArcRaceDebuff> SingleModeArcRaceDebuffs { get; set; }
        public virtual DbSet<SingleModeArcSchedule> SingleModeArcSchedules { get; set; }
        public virtual DbSet<SingleModeArcTaimanPeffGrp> SingleModeArcTaimanPeffGrps { get; set; }
        public virtual DbSet<SingleModeArcTrainingEff> SingleModeArcTrainingEffs { get; set; }
        public virtual DbSet<SingleModeArcWinPt> SingleModeArcWinPts { get; set; }
        public virtual DbSet<SingleModeChangeCharaRoute> SingleModeChangeCharaRoutes { get; set; }
        public virtual DbSet<SingleModeCharaEffect> SingleModeCharaEffects { get; set; }
        public virtual DbSet<SingleModeCharaEffectBuff> SingleModeCharaEffectBuffs { get; set; }
        public virtual DbSet<SingleModeCharaGrade> SingleModeCharaGrades { get; set; }
        public virtual DbSet<SingleModeCharaProgram> SingleModeCharaPrograms { get; set; }
        public virtual DbSet<SingleModeConclusionSet> SingleModeConclusionSets { get; set; }
        public virtual DbSet<SingleModeCookCoinRate> SingleModeCookCoinRates { get; set; }
        public virtual DbSet<SingleModeCookCookingCutt> SingleModeCookCookingCutts { get; set; }
        public virtual DbSet<SingleModeCookCookingRate> SingleModeCookCookingRates { get; set; }
        public virtual DbSet<SingleModeCookCookingType> SingleModeCookCookingTypes { get; set; }
        public virtual DbSet<SingleModeCookDish> SingleModeCookDishes { get; set; }
        public virtual DbSet<SingleModeCookDishCutt> SingleModeCookDishCutts { get; set; }
        public virtual DbSet<SingleModeCookDishCuttSe> SingleModeCookDishCuttSes { get; set; }
        public virtual DbSet<SingleModeCookDishEffect> SingleModeCookDishEffects { get; set; }
        public virtual DbSet<SingleModeCookDishIcon> SingleModeCookDishIcons { get; set; }
        public virtual DbSet<SingleModeCookDishMaterial> SingleModeCookDishMaterials { get; set; }
        public virtual DbSet<SingleModeCookDishName> SingleModeCookDishNames { get; set; }
        public virtual DbSet<SingleModeCookGarden> SingleModeCookGardens { get; set; }
        public virtual DbSet<SingleModeCookGardenBg> SingleModeCookGardenBgs { get; set; }
        public virtual DbSet<SingleModeCookGardenEffect> SingleModeCookGardenEffects { get; set; }
        public virtual DbSet<SingleModeCookGardenLevel> SingleModeCookGardenLevels { get; set; }
        public virtual DbSet<SingleModeCookListener> SingleModeCookListeners { get; set; }
        public virtual DbSet<SingleModeCookMaterialRate> SingleModeCookMaterialRates { get; set; }
        public virtual DbSet<SingleModeCookMessage> SingleModeCookMessages { get; set; }
        public virtual DbSet<SingleModeCookMotionGroup> SingleModeCookMotionGroups { get; set; }
        public virtual DbSet<SingleModeCookMotionStatus> SingleModeCookMotionStatuses { get; set; }
        public virtual DbSet<SingleModeCookPowerData> SingleModeCookPowerData { get; set; }
        public virtual DbSet<SingleModeCookStandMotion> SingleModeCookStandMotions { get; set; }
        public virtual DbSet<SingleModeCookSuccessEffect> SingleModeCookSuccessEffects { get; set; }
        public virtual DbSet<SingleModeCookSuccessOdd> SingleModeCookSuccessOdds { get; set; }
        public virtual DbSet<SingleModeCookSuccessType> SingleModeCookSuccessTypes { get; set; }
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
        public virtual DbSet<SingleModeFreeCoinRace> SingleModeFreeCoinRaces { get; set; }
        public virtual DbSet<SingleModeFreeShop> SingleModeFreeShops { get; set; }
        public virtual DbSet<SingleModeFreeShopBg> SingleModeFreeShopBgs { get; set; }
        public virtual DbSet<SingleModeFreeShopEffect> SingleModeFreeShopEffects { get; set; }
        public virtual DbSet<SingleModeFreeShopItem> SingleModeFreeShopItems { get; set; }
        public virtual DbSet<SingleModeFreeTrainingPlate> SingleModeFreeTrainingPlates { get; set; }
        public virtual DbSet<SingleModeFreeWinPoint> SingleModeFreeWinPoints { get; set; }
        public virtual DbSet<SingleModeHideCharaText> SingleModeHideCharaTexts { get; set; }
        public virtual DbSet<SingleModeHintGain> SingleModeHintGains { get; set; }
        public virtual DbSet<SingleModeLiveLiveData> SingleModeLiveLiveData { get; set; }
        public virtual DbSet<SingleModeLiveMasterBonus> SingleModeLiveMasterBonus { get; set; }
        public virtual DbSet<SingleModeLiveSongList> SingleModeLiveSongLists { get; set; }
        public virtual DbSet<SingleModeLiveSquare> SingleModeLiveSquares { get; set; }
        public virtual DbSet<SingleModeMemberRank> SingleModeMemberRanks { get; set; }
        public virtual DbSet<SingleModeMemberRankPoint> SingleModeMemberRankPoints { get; set; }
        public virtual DbSet<SingleModeMessage> SingleModeMessages { get; set; }
        public virtual DbSet<SingleModeNpc> SingleModeNpcs { get; set; }
        public virtual DbSet<SingleModeOuting> SingleModeOutings { get; set; }
        public virtual DbSet<SingleModeOutingSet> SingleModeOutingSets { get; set; }
        public virtual DbSet<SingleModePreviewBgm> SingleModePreviewBgms { get; set; }
        public virtual DbSet<SingleModeProgram> SingleModePrograms { get; set; }
        public virtual DbSet<SingleModeRaceGroup> SingleModeRaceGroups { get; set; }
        public virtual DbSet<SingleModeRaceLimitReward> SingleModeRaceLimitRewards { get; set; }
        public virtual DbSet<SingleModeRaceLive> SingleModeRaceLives { get; set; }
        public virtual DbSet<SingleModeRaceRestrictTurn> SingleModeRaceRestrictTurns { get; set; }
        public virtual DbSet<SingleModeRank> SingleModeRanks { get; set; }
        public virtual DbSet<SingleModeRecommend> SingleModeRecommends { get; set; }
        public virtual DbSet<SingleModeRecommendSetting> SingleModeRecommendSettings { get; set; }
        public virtual DbSet<SingleModeRestrictSupport> SingleModeRestrictSupports { get; set; }
        public virtual DbSet<SingleModeRewardSet> SingleModeRewardSets { get; set; }
        public virtual DbSet<SingleModeRival> SingleModeRivals { get; set; }
        public virtual DbSet<SingleModeRoute> SingleModeRoutes { get; set; }
        public virtual DbSet<SingleModeRouteAnnounce> SingleModeRouteAnnounces { get; set; }
        public virtual DbSet<SingleModeRouteCondition> SingleModeRouteConditions { get; set; }
        public virtual DbSet<SingleModeRouteRace> SingleModeRouteRaces { get; set; }
        public virtual DbSet<SingleModeScenario> SingleModeScenarios { get; set; }
        public virtual DbSet<SingleModeScenarioGroup> SingleModeScenarioGroups { get; set; }
        public virtual DbSet<SingleModeScenarioRecord> SingleModeScenarioRecords { get; set; }
        public virtual DbSet<SingleModeScenarioUpdate> SingleModeScenarioUpdates { get; set; }
        public virtual DbSet<SingleModeScoutChara> SingleModeScoutCharas { get; set; }
        public virtual DbSet<SingleModeSkillNeedPoint> SingleModeSkillNeedPoints { get; set; }
        public virtual DbSet<SingleModeSpecialChara> SingleModeSpecialCharas { get; set; }
        public virtual DbSet<SingleModeSportCompeEffect> SingleModeSportCompeEffects { get; set; }
        public virtual DbSet<SingleModeSportCompeSe> SingleModeSportCompeSes { get; set; }
        public virtual DbSet<SingleModeSportCompetition> SingleModeSportCompetitions { get; set; }
        public virtual DbSet<SingleModeSportItemEffect> SingleModeSportItemEffects { get; set; }
        public virtual DbSet<SingleModeSportLink> SingleModeSportLinks { get; set; }
        public virtual DbSet<SingleModeSportMob> SingleModeSportMobs { get; set; }
        public virtual DbSet<SingleModeSportSportType> SingleModeSportSportTypes { get; set; }
        public virtual DbSet<SingleModeSportStance> SingleModeSportStances { get; set; }
        public virtual DbSet<SingleModeSportStanceEffect> SingleModeSportStanceEffects { get; set; }
        public virtual DbSet<SingleModeSportTrainingCut> SingleModeSportTrainingCuts { get; set; }
        public virtual DbSet<SingleModeStoryData> SingleModeStoryData { get; set; }
        public virtual DbSet<SingleModeStoryGuide> SingleModeStoryGuides { get; set; }
        public virtual DbSet<SingleModeTagCardPos> SingleModeTagCardPos { get; set; }
        public virtual DbSet<SingleModeTeamName> SingleModeTeamNames { get; set; }
        public virtual DbSet<SingleModeTeamRaceSet> SingleModeTeamRaceSets { get; set; }
        public virtual DbSet<SingleModeTopBg> SingleModeTopBgs { get; set; }
        public virtual DbSet<SingleModeTopBgChara> SingleModeTopBgCharas { get; set; }
        public virtual DbSet<SingleModeTraining> SingleModeTrainings { get; set; }
        public virtual DbSet<SingleModeTrainingBgChara> SingleModeTrainingBgCharas { get; set; }
        public virtual DbSet<SingleModeTrainingEffect> SingleModeTrainingEffects { get; set; }
        public virtual DbSet<SingleModeTrainingPlate> SingleModeTrainingPlates { get; set; }
        public virtual DbSet<SingleModeTrainingSe> SingleModeTrainingSes { get; set; }
        public virtual DbSet<SingleModeTurn> SingleModeTurns { get; set; }
        public virtual DbSet<SingleModeUniqueChara> SingleModeUniqueCharas { get; set; }
        public virtual DbSet<SingleModeVenusCrystalGroup> SingleModeVenusCrystalGroups { get; set; }
        public virtual DbSet<SingleModeVenusSpiritEffect> SingleModeVenusSpiritEffects { get; set; }
        public virtual DbSet<SingleModeVenusSpiritGroup> SingleModeVenusSpiritGroups { get; set; }
        public virtual DbSet<SingleModeVenusSpraceData> SingleModeVenusSpraceData { get; set; }
        public virtual DbSet<SingleModeWinsSaddle> SingleModeWinsSaddles { get; set; }
        public virtual DbSet<SkillData> SkillData { get; set; }
        public virtual DbSet<SkillExp> SkillExps { get; set; }
        public virtual DbSet<SkillLevelValue> SkillLevelValues { get; set; }
        public virtual DbSet<SkillSet> SkillSets { get; set; }
        public virtual DbSet<SkillUpScenarioCondition> SkillUpScenarioConditions { get; set; }
        public virtual DbSet<SkillUpgradeCondition> SkillUpgradeConditions { get; set; }
        public virtual DbSet<SkillUpgradeDescription> SkillUpgradeDescriptions { get; set; }
        public virtual DbSet<SkillUpgradeSpeciality> SkillUpgradeSpecialities { get; set; }
        public virtual DbSet<StoryEventBingoReward> StoryEventBingoRewards { get; set; }
        public virtual DbSet<StoryEventBonusCard> StoryEventBonusCards { get; set; }
        public virtual DbSet<StoryEventBonusGroupSupportCard> StoryEventBonusGroupSupportCards { get; set; }
        public virtual DbSet<StoryEventBonusSupportCard> StoryEventBonusSupportCards { get; set; }
        public virtual DbSet<StoryEventData> StoryEventData { get; set; }
        public virtual DbSet<StoryEventMission> StoryEventMissions { get; set; }
        public virtual DbSet<StoryEventMissionTopChara> StoryEventMissionTopCharas { get; set; }
        public virtual DbSet<StoryEventNicknameBonus> StoryEventNicknameBonus { get; set; }
        public virtual DbSet<StoryEventPointReward> StoryEventPointRewards { get; set; }
        public virtual DbSet<StoryEventRouletteBingo> StoryEventRouletteBingos { get; set; }
        public virtual DbSet<StoryEventStoryData> StoryEventStoryData { get; set; }
        public virtual DbSet<StoryEventTopChara> StoryEventTopCharas { get; set; }
        public virtual DbSet<StoryExtraData> StoryExtraData { get; set; }
        public virtual DbSet<StoryExtraMovieData> StoryExtraMovieData { get; set; }
        public virtual DbSet<StoryExtraStoryData> StoryExtraStoryData { get; set; }
        public virtual DbSet<StoryHipOffset> StoryHipOffsets { get; set; }
        public virtual DbSet<StoryLivePosition> StoryLivePositions { get; set; }
        public virtual DbSet<StoryStill> StoryStills { get; set; }
        public virtual DbSet<StoryWipeDictionary> StoryWipeDictionaries { get; set; }
        public virtual DbSet<SubscriptionEffect> SubscriptionEffects { get; set; }
        public virtual DbSet<SuccessionFactor> SuccessionFactors { get; set; }
        public virtual DbSet<SuccessionFactorEffect> SuccessionFactorEffects { get; set; }
        public virtual DbSet<SuccessionInitialFactor> SuccessionInitialFactors { get; set; }
        public virtual DbSet<SuccessionRelation> SuccessionRelations { get; set; }
        public virtual DbSet<SuccessionRelationMember> SuccessionRelationMembers { get; set; }
        public virtual DbSet<SuccessionRelationRank> SuccessionRelationRanks { get; set; }
        public virtual DbSet<SuccessionRental> SuccessionRentals { get; set; }
        public virtual DbSet<SupportCardData> SupportCardData { get; set; }
        public virtual DbSet<SupportCardEffectFilter> SupportCardEffectFilters { get; set; }
        public virtual DbSet<SupportCardEffectFilterGroup> SupportCardEffectFilterGroups { get; set; }
        public virtual DbSet<SupportCardEffectTable> SupportCardEffectTables { get; set; }
        public virtual DbSet<SupportCardGroup> SupportCardGroups { get; set; }
        public virtual DbSet<SupportCardLevel> SupportCardLevels { get; set; }
        public virtual DbSet<SupportCardLimit> SupportCardLimits { get; set; }
        public virtual DbSet<SupportCardLimitBreak> SupportCardLimitBreaks { get; set; }
        public virtual DbSet<SupportCardTeamScoreBonus> SupportCardTeamScoreBonus { get; set; }
        public virtual DbSet<SupportCardUniqueEffect> SupportCardUniqueEffects { get; set; }
        public virtual DbSet<TeamBuildingCharaCount> TeamBuildingCharaCounts { get; set; }
        public virtual DbSet<TeamBuildingCharaGroup> TeamBuildingCharaGroups { get; set; }
        public virtual DbSet<TeamBuildingCollectionChara> TeamBuildingCollectionCharas { get; set; }
        public virtual DbSet<TeamBuildingCollectionSet> TeamBuildingCollectionSets { get; set; }
        public virtual DbSet<TeamBuildingConsecutiveWin> TeamBuildingConsecutiveWins { get; set; }
        public virtual DbSet<TeamBuildingData> TeamBuildingData { get; set; }
        public virtual DbSet<TeamBuildingDiscountPoint> TeamBuildingDiscountPoints { get; set; }
        public virtual DbSet<TeamBuildingRaceNpc> TeamBuildingRaceNpcs { get; set; }
        public virtual DbSet<TeamBuildingRank> TeamBuildingRanks { get; set; }
        public virtual DbSet<TeamBuildingRankRewardGroup> TeamBuildingRankRewardGroups { get; set; }
        public virtual DbSet<TeamBuildingRetryBonus> TeamBuildingRetryBonus { get; set; }
        public virtual DbSet<TeamBuildingScoutPoint> TeamBuildingScoutPoints { get; set; }
        public virtual DbSet<TeamBuildingSpRaceSchedule> TeamBuildingSpRaceSchedules { get; set; }
        public virtual DbSet<TeamBuildingTeamRaceSet> TeamBuildingTeamRaceSets { get; set; }
        public virtual DbSet<TeamBuildingWinReward> TeamBuildingWinRewards { get; set; }
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
        public virtual DbSet<TimezoneData> TimezoneData { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TrainedCharaTradeItem> TrainedCharaTradeItems { get; set; }
        public virtual DbSet<TrainingChallengeExam> TrainingChallengeExams { get; set; }
        public virtual DbSet<TrainingChallengeMaster> TrainingChallengeMasters { get; set; }
        public virtual DbSet<TrainingChallengeScore> TrainingChallengeScores { get; set; }
        public virtual DbSet<TrainingCuttCharaData> TrainingCuttCharaData { get; set; }
        public virtual DbSet<TrainingCuttData> TrainingCuttData { get; set; }
        public virtual DbSet<TrainingCuttFlash> TrainingCuttFlashes { get; set; }
        public virtual DbSet<TrainingCuttGroupData> TrainingCuttGroupData { get; set; }
        public virtual DbSet<TrainingReportInflation> TrainingReportInflations { get; set; }
        public virtual DbSet<TrainingReportNormalReward> TrainingReportNormalRewards { get; set; }
        public virtual DbSet<TrainingReportPass> TrainingReportPasses { get; set; }
        public virtual DbSet<TrainingReportRatio> TrainingReportRatios { get; set; }
        public virtual DbSet<TrainingReportSpecialReward> TrainingReportSpecialRewards { get; set; }
        public virtual DbSet<TransferEventData> TransferEventData { get; set; }
        public virtual DbSet<TransferEventDetail> TransferEventDetails { get; set; }
        public virtual DbSet<TransferEventReward> TransferEventRewards { get; set; }
        public virtual DbSet<TransferRotationData> TransferRotationData { get; set; }
        public virtual DbSet<TransferRotationDetail> TransferRotationDetails { get; set; }
        public virtual DbSet<TransferRotationReward> TransferRotationRewards { get; set; }
        public virtual DbSet<TransferRotationSchedule> TransferRotationSchedules { get; set; }
        public virtual DbSet<TutorialGuideData> TutorialGuideData { get; set; }
        public virtual DbSet<UltimateRaceContent> UltimateRaceContents { get; set; }
        public virtual DbSet<UltimateRaceContentsChange> UltimateRaceContentsChanges { get; set; }
        public virtual DbSet<UltimateRaceData> UltimateRaceData { get; set; }
        public virtual DbSet<UltimateRaceNpc> UltimateRaceNpcs { get; set; }
        public virtual DbSet<UltimateRaceSelectTop> UltimateRaceSelectTops { get; set; }

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
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("announce_character");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CanEndSecond)
                    .HasColumnType("int(11)")
                    .HasColumnName("can_end_second");
                entity.Property(e => e.MovieId)
                    .HasColumnType("int(11)")
                    .HasColumnName("movie_id");
            });

            modelBuilder.Entity<AnnounceData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("announce_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AnnounceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("announce_id");
                entity.Property(e => e.AnnounceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("announce_type");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<AnnounceEvent>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("announce_event");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.VoiceTextAsset)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_text_asset");
            });

            modelBuilder.Entity<AnnounceSupportCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("announce_support_card");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CutsPattern)
                    .HasColumnType("int(11)")
                    .HasColumnName("cuts_pattern");
                entity.Property(e => e.SupportCardIdA)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id_a");
                entity.Property(e => e.SupportCardIdB)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id_b");
                entity.Property(e => e.SupportCardIdC)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id_c");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<AudienceData>(entity =>
            {
                entity.HasKey(e => e.AudienceId).HasName("PRIMARY");

                entity.ToTable("audience_data");

                entity.Property(e => e.AudienceId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("audience_id");
                entity.Property(e => e.CharaBustSize)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_bust_size");
                entity.Property(e => e.CharaFaceModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_face_model");
                entity.Property(e => e.CharaHairColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_hair_color");
                entity.Property(e => e.CharaHairModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_hair_model");
                entity.Property(e => e.CharaHeight)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_height");
                entity.Property(e => e.CharaSkinColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_skin_color");
                entity.Property(e => e.DressColorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_color_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.PropAttachNodeNameType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_attach_node_name_type_1");
                entity.Property(e => e.PropAttachNodeNameType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_attach_node_name_type_2");
                entity.Property(e => e.PropId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id_1");
                entity.Property(e => e.PropId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id_2");
                entity.Property(e => e.Shape)
                    .HasColumnType("int(11)")
                    .HasColumnName("shape");
            });

            modelBuilder.Entity<AudienceDressColorSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("audience_dress_color_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b1");
                entity.Property(e => e.ColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b2");
                entity.Property(e => e.ColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g1");
                entity.Property(e => e.ColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g2");
                entity.Property(e => e.ColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r1");
                entity.Property(e => e.ColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r2");
                entity.Property(e => e.ToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b1");
                entity.Property(e => e.ToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b2");
                entity.Property(e => e.ToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g1");
                entity.Property(e => e.ToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g2");
                entity.Property(e => e.ToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r1");
                entity.Property(e => e.ToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r2");
            });

            modelBuilder.Entity<AudienceHairColorSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("audience_hair_color_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EyeColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_b1");
                entity.Property(e => e.EyeColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_b2");
                entity.Property(e => e.EyeColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_g1");
                entity.Property(e => e.EyeColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_g2");
                entity.Property(e => e.EyeColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_r1");
                entity.Property(e => e.EyeColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_r2");
                entity.Property(e => e.HairColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_b1");
                entity.Property(e => e.HairColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_b2");
                entity.Property(e => e.HairColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_g1");
                entity.Property(e => e.HairColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_g2");
                entity.Property(e => e.HairColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_r1");
                entity.Property(e => e.HairColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_r2");
                entity.Property(e => e.HairToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_b1");
                entity.Property(e => e.HairToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_b2");
                entity.Property(e => e.HairToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_g1");
                entity.Property(e => e.HairToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_g2");
                entity.Property(e => e.HairToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_r1");
                entity.Property(e => e.HairToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_r2");
                entity.Property(e => e.MayuColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_b1");
                entity.Property(e => e.MayuColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_b2");
                entity.Property(e => e.MayuColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_g1");
                entity.Property(e => e.MayuColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_g2");
                entity.Property(e => e.MayuColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_r1");
                entity.Property(e => e.MayuColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_r2");
                entity.Property(e => e.MayuToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_b1");
                entity.Property(e => e.MayuToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_b2");
                entity.Property(e => e.MayuToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_g1");
                entity.Property(e => e.MayuToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_g2");
                entity.Property(e => e.MayuToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_r1");
                entity.Property(e => e.MayuToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_r2");
            });

            modelBuilder.Entity<AudienceImpostor>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("audience_impostor");

                entity.HasIndex(e => new { e.Season, e.Weather }, "audience_impostor_0_season_1_weather");

                entity.Property(e => e.AudienceGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audience_group_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Pattern1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_1");
                entity.Property(e => e.Pattern10)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_10");
                entity.Property(e => e.Pattern2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_2");
                entity.Property(e => e.Pattern3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_3");
                entity.Property(e => e.Pattern4)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_4");
                entity.Property(e => e.Pattern5)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_5");
                entity.Property(e => e.Pattern6)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_6");
                entity.Property(e => e.Pattern7)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_7");
                entity.Property(e => e.Pattern8)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_8");
                entity.Property(e => e.Pattern9)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern_9");
                entity.Property(e => e.SceneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("scene_type");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<AudienceImpostorColorSet>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("audience_impostor_color_set");

                entity.HasIndex(e => e.ColorGroupId, "audience_impostor_color_set_0_color_group_id");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color");
                entity.Property(e => e.ColorGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("color_group_id");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
            });

            modelBuilder.Entity<AudienceImpostorLottery>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("audience_impostor_lottery");

                entity.HasIndex(e => new { e.GroupId, e.Pattern }, "audience_impostor_lottery_0_group_id_1_pattern");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("asset_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.Pattern)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern");
            });

            modelBuilder.Entity<AudioCuesheet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("audio_cuesheet");

                entity.HasIndex(e => e.Attribute, "audio_cuesheet_0_attribute");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Attribute)
                    .HasColumnType("int(11)")
                    .HasColumnName("attribute");
                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_sheet");
            });

            modelBuilder.Entity<AudioIgnoredCueOnHighspeed>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("audio_ignored_cue_on_highspeed");

                entity.HasIndex(e => new { e.CueName, e.CueSheet }, "audio_ignored_cue_on_highspeed_0_cue_name_1_cue_sheet");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("cue_name");
                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("cue_sheet");
            });

            modelBuilder.Entity<AudioStoryEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("audio_story_effect");

                entity.HasIndex(e => e.EffectName, "audio_story_effect_0_effect_name").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
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
                    .HasColumnType("text")
                    .HasColumnName("effect_name");
                entity.Property(e => e.LoopSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("loop_set");
            });

            modelBuilder.Entity<AvailableSkillSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("available_skill_set");

                entity.HasIndex(e => e.AvailableSkillSetId, "available_skill_set_0_available_skill_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AvailableSkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("available_skill_set_id");
                entity.Property(e => e.NeedRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_rank");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
            });

            modelBuilder.Entity<BackgroundData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("background_data");

                entity.HasIndex(e => new { e.BgId, e.BgSub }, "background_data_0_bg_id_1_bg_sub").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSub)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub");
                entity.Property(e => e.BusParamSetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bus_param_set_name");
                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name");
                entity.Property(e => e.Height)
                    .HasColumnType("int(11)")
                    .HasColumnName("height");
                entity.Property(e => e.PosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_x");
                entity.Property(e => e.PosY)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_y");
                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sheet_name");
                entity.Property(e => e.Width)
                    .HasColumnType("int(11)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<BackgroundOffsetData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("background_offset_data");

                entity.HasIndex(e => new { e.BgId, e.BgSub }, "background_offset_data_0_bg_id_1_bg_sub");

                entity.HasIndex(e => new { e.BgId, e.BgSub, e.OffsetId }, "bg_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSub)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub");
                entity.Property(e => e.Height)
                    .HasColumnType("int(11)")
                    .HasColumnName("height");
                entity.Property(e => e.OffsetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset_id");
                entity.Property(e => e.PosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_x");
                entity.Property(e => e.PosY)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_y");
                entity.Property(e => e.Width)
                    .HasColumnType("int(11)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<BannerData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("banner_data");

                entity.HasIndex(e => e.GroupId, "banner_data_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BannerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("banner_id");
                entity.Property(e => e.BannerImageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("banner_image_id");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.DialogImageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dialog_image_id");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.Transition)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CampaignCharaStorySchedule>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("campaign_chara_story_schedule");

                entity.HasIndex(e => e.CampaignId, "campaign_chara_story_schedule_0_campaign_id");

                entity.HasIndex(e => e.CharaId, "campaign_chara_story_schedule_0_chara_id");

                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<CampaignCuttData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_cutt_data");

                entity.HasIndex(e => e.CharaId, "campaign_cutt_data_0_chara_id");

                entity.HasIndex(e => new { e.CutId, e.CutSubId }, "campaign_cutt_data_0_cut_id_1_cut_sub_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CharaNoChange)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_no_change");
                entity.Property(e => e.ColorType)
                    .HasColumnType("int(11)")
                    .HasColumnName("color_type");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.CutSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_sub_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.MotionRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_rate");
                entity.Property(e => e.MotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_type");
                entity.Property(e => e.TrainerGenderType)
                    .HasColumnType("int(11)")
                    .HasColumnName("trainer_gender_type");
            });

            modelBuilder.Entity<CampaignData>(entity =>
            {
                entity.HasKey(e => e.CampaignId).HasName("PRIMARY");

                entity.ToTable("campaign_data");

                entity.HasIndex(e => e.ImageChange, "campaign_data_0_image_change");

                entity.HasIndex(e => e.TargetType, "campaign_data_0_target_type");

                entity.Property(e => e.CampaignId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.EffectType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type_1");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EndTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_time");
                entity.Property(e => e.ImageChange)
                    .HasColumnType("int(11)")
                    .HasColumnName("image_change");
                entity.Property(e => e.ImageIconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("image_icon_id");
                entity.Property(e => e.LogoType)
                    .HasColumnType("int(11)")
                    .HasColumnName("logo_type");
                entity.Property(e => e.OpenFlagId)
                    .HasColumnType("int(11)")
                    .HasColumnName("open_flag_id");
                entity.Property(e => e.StartTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_time");
                entity.Property(e => e.TargetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_id");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.TransitionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition_type");
                entity.Property(e => e.UserShow)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_show");
            });

            modelBuilder.Entity<CampaignNPresentBonusData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_n_present_bonus_data");

                entity.HasIndex(e => e.CardId, "campaign_n_present_bonus_data_0_card_id");

                entity.HasIndex(e => new { e.TargetType, e.CardId }, "campaign_n_present_bonus_data_0_target_type_1_card_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
            });

            modelBuilder.Entity<CampaignPresentBonusDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_present_bonus_detail");

                entity.HasIndex(e => new { e.CampaignId, e.CardId }, "campaign_id").IsUnique();

                entity.HasIndex(e => e.CardId, "campaign_present_bonus_detail_0_card_id");

                entity.HasIndex(e => e.ItemId1, "item_id_1").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
            });

            modelBuilder.Entity<CampaignRentalSupportCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_rental_support_card");

                entity.HasIndex(e => e.CampaignRentalSupportDataId, "campaign_rental_support_card_0_campaign_rental_support_data_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CampaignRentalSupportDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_rental_support_data_id");
                entity.Property(e => e.LimitBreakCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_break_count");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<CampaignRentalSupportData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_rental_support_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.RentalLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("rental_limit");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<CampaignSingleRaceAddData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_single_race_add_data");

                entity.HasIndex(e => e.RaceAdditionalId, "campaign_single_race_add_data_0_race_additional_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceAdditionalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_additional_id");
                entity.Property(e => e.RaceAdditionalRewardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_additional_reward_id");
                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_program_id");
                entity.Property(e => e.RewardLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_limit");
            });

            modelBuilder.Entity<CampaignSingleRaceAddReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_single_race_add_reward");

                entity.HasIndex(e => e.RaceAdditionalRewardId, "campaign_single_race_add_reward_0_race_additional_reward_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.RaceAdditionalRewardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_additional_reward_id");
                entity.Property(e => e.RewardRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_rate");
                entity.Property(e => e.RewardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_type");
                entity.Property(e => e.RewardValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_value");
            });

            modelBuilder.Entity<CampaignSpPresentBonusData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_sp_present_bonus_data");

                entity.HasIndex(e => e.CardId, "campaign_sp_present_bonus_data_0_card_id");

                entity.HasIndex(e => new { e.TargetType, e.CardId }, "campaign_sp_present_bonus_data_0_target_type_1_card_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.LocationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("location_id");
                entity.Property(e => e.MotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_type");
                entity.Property(e => e.PropId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id");
                entity.Property(e => e.ReplaceIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("replace_index");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
            });

            modelBuilder.Entity<CampaignStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_story_data");

                entity.HasIndex(e => e.CampaignId, "campaign_story_data_0_campaign_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<CampaignSwapMotionData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_swap_motion_data");

                entity.HasIndex(e => e.DressId, "campaign_swap_motion_data_0_dress_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.CutSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_sub_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.ReplaceIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("replace_index");
            });

            modelBuilder.Entity<CampaignWalkingChara>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("campaign_walking_chara");

                entity.HasIndex(e => new { e.CampaignId, e.CharaId }, "campaign_id").IsUnique();

                entity.HasIndex(e => e.CharaId, "campaign_walking_chara_0_chara_id");

                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Location1)
                    .HasColumnType("int(11)")
                    .HasColumnName("location_1");
                entity.Property(e => e.Location2)
                    .HasColumnType("int(11)")
                    .HasColumnName("location_2");
                entity.Property(e => e.Location3)
                    .HasColumnType("int(11)")
                    .HasColumnName("location_3");
            });

            modelBuilder.Entity<CampaignWalkingData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_walking_data");

                entity.HasIndex(e => e.CampaignId, "campaign_walking_data_0_campaign_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CampaignId)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_id");
                entity.Property(e => e.GaugeConsumeNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_consume_num");
                entity.Property(e => e.GaugeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_max");
                entity.Property(e => e.GaugeUpDailylegendrace)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_dailylegendrace");
                entity.Property(e => e.GaugeUpDailyrace)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_dailyrace");
                entity.Property(e => e.GaugeUpLogin)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_login");
                entity.Property(e => e.GaugeUpSinglemode)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_singlemode");
                entity.Property(e => e.GaugeUpTeamstadium)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_teamstadium");
                entity.Property(e => e.IconIdLocation1)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id_location_1");
                entity.Property(e => e.IconIdLocation2)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id_location_2");
                entity.Property(e => e.IconIdLocation3)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id_location_3");
                entity.Property(e => e.LogoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("logo_id");
                entity.Property(e => e.MapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("map_id");
                entity.Property(e => e.SpecialCampaignType)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_campaign_type");
                entity.Property(e => e.WalkingLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("walking_limit");
            });

            modelBuilder.Entity<CampaignWalkingFriend>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_walking_friend");

                entity.HasIndex(e => e.FriendListId, "campaign_walking_friend_0_friend_list_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.FriendListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("friend_list_id");
            });

            modelBuilder.Entity<CampaignWalkingLocation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_walking_location");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BackgroundDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("background_data_id");
                entity.Property(e => e.BgPositionCustom)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_position_custom");
                entity.Property(e => e.BgPositionX)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_position_x");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.CutSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_sub_id");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.FriendListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("friend_list_id");
                entity.Property(e => e.LovePoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("love_point");
                entity.Property(e => e.MaterialId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("material_id");
                entity.Property(e => e.PlaceColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("place_color_main");
                entity.Property(e => e.PlaceColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("place_color_sub");
                entity.Property(e => e.PlacePositionX)
                    .HasColumnType("int(11)")
                    .HasColumnName("place_position_x");
                entity.Property(e => e.PlacePositionY)
                    .HasColumnType("int(11)")
                    .HasColumnName("place_position_y");
                entity.Property(e => e.PlaceTail)
                    .HasColumnType("int(11)")
                    .HasColumnName("place_tail");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<CampaignWalkingRewardSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("campaign_walking_reward_set");

                entity.HasIndex(e => e.RewardSetId, "campaign_walking_reward_set_0_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.LimitNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_num");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<CardData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("card_data");

                entity.HasIndex(e => e.CharaId, "card_data_0_chara_id");

                entity.HasIndex(e => e.GetPieceId, "card_data_0_get_piece_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AvailableSkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("available_skill_set_id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DefaultRarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_rarity");
                entity.Property(e => e.GetPieceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("get_piece_id");
                entity.Property(e => e.LimitedChara)
                    .HasColumnType("int(11)")
                    .HasColumnName("limited_chara");
                entity.Property(e => e.RunningStyle)
                    .HasColumnType("int(11)")
                    .HasColumnName("running_style");
                entity.Property(e => e.TalentGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_group_id");
                entity.Property(e => e.TalentGuts)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_guts");
                entity.Property(e => e.TalentPow)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_pow");
                entity.Property(e => e.TalentSpeed)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_speed");
                entity.Property(e => e.TalentStamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_stamina");
                entity.Property(e => e.TalentWiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_wiz");
            });

            modelBuilder.Entity<CardRarityData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("card_rarity_data");

                entity.HasIndex(e => e.CardId, "card_rarity_data_0_card_id");

                entity.HasIndex(e => new { e.CardId, e.Rarity }, "card_rarity_data_0_card_id_1_rarity").IsUnique();

                entity.HasIndex(e => e.RaceDressId, "card_rarity_data_0_race_dress_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.GetDressId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("get_dress_id_1");
                entity.Property(e => e.GetDressId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("get_dress_id_2");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.MaxGuts)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_guts");
                entity.Property(e => e.MaxPow)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_pow");
                entity.Property(e => e.MaxSpeed)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_speed");
                entity.Property(e => e.MaxStamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_stamina");
                entity.Property(e => e.MaxWiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_wiz");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.SkillSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<CardTalentHintUpgrade>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("card_talent_hint_upgrade");

                entity.HasIndex(e => new { e.Rarity, e.TalentLevel }, "card_talent_hint_upgrade_0_rarity_1_talent_level");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemDispOrder1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_disp_order_1");
                entity.Property(e => e.ItemDispOrder2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_disp_order_2");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
                entity.Property(e => e.MoneyNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("money_num");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.TalentLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_level");
            });

            modelBuilder.Entity<CardTalentUpgrade>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("card_talent_upgrade");

                entity.HasIndex(e => new { e.TalentGroupId, e.TalentLevel }, "card_talent_upgrade_0_talent_group_id_1_talent_level");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_3");
                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_4");
                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_5");
                entity.Property(e => e.ItemCategory6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_6");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_3");
                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_4");
                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_5");
                entity.Property(e => e.ItemId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_6");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
                entity.Property(e => e.ItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_3");
                entity.Property(e => e.ItemNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_4");
                entity.Property(e => e.ItemNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_5");
                entity.Property(e => e.ItemNum6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_6");
                entity.Property(e => e.TalentGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_group_id");
                entity.Property(e => e.TalentLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_level");
            });

            modelBuilder.Entity<ChallengeMatchBossNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("challenge_match_boss_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardRarityDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_rarity_data_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.NicknameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("nickname_id");
                entity.Property(e => e.Post)
                    .HasColumnType("int(11)")
                    .HasColumnName("post");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<ChallengeMatchData>(entity =>
            {
                entity.HasKey(e => e.ChallengeMatchId).HasName("PRIMARY");

                entity.ToTable("challenge_match_data");

                entity.Property(e => e.ChallengeMatchId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("challenge_match_id");
                entity.Property(e => e.AnnounceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("announce_id");
                entity.Property(e => e.BonusFactorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_factor_id");
                entity.Property(e => e.BonusSkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_skill_id");
                entity.Property(e => e.ChallengeMatchTopBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("challenge_match_top_bg_id");
                entity.Property(e => e.ChallengeMatchTopBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("challenge_match_top_bg_sub_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EndingDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_date");
                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_top_id");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ChallengeMatchRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("challenge_match_race");

                entity.HasIndex(e => e.ChallengeMatchId, "challenge_match_race_0_challenge_match_id");

                entity.HasIndex(e => e.RaceInstanceId, "challenge_match_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ChallengeMatchBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("challenge_match_bg_id");
                entity.Property(e => e.ChallengeMatchBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("challenge_match_bg_sub_id");
                entity.Property(e => e.ChallengeMatchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("challenge_match_id");
                entity.Property(e => e.ChallengeMatchRaceBossNpcId)
                    .HasColumnType("int(11)")
                    .HasColumnName("challenge_match_race_boss_npc_id");
                entity.Property(e => e.CostRp)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_rp");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.DropRewardOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("drop_reward_odds_id");
                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_1");
                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_2");
                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_3");
                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_1");
                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_2");
                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_3");
                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_1");
                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_2");
                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_3");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.PickUpItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_1");
                entity.Property(e => e.PickUpItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_2");
                entity.Property(e => e.PickUpItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_3");
                entity.Property(e => e.PickUpItemCategory4)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_4");
                entity.Property(e => e.PickUpItemCategory5)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_5");
                entity.Property(e => e.PickUpItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_1");
                entity.Property(e => e.PickUpItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_2");
                entity.Property(e => e.PickUpItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_3");
                entity.Property(e => e.PickUpItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_4");
                entity.Property(e => e.PickUpItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_5");
                entity.Property(e => e.PickUpItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_1");
                entity.Property(e => e.PickUpItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_2");
                entity.Property(e => e.PickUpItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_3");
                entity.Property(e => e.PickUpItemNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_4");
                entity.Property(e => e.PickUpItemNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_5");
                entity.Property(e => e.RaceAppearanceRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_appearance_rate");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.RaceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_type");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.VictoryRewardOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("victory_reward_odds_id");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<ChallengeMatchRawPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("challenge_match_raw_point");

                entity.HasIndex(e => e.ConditionType, "challenge_match_raw_point_0_condition_type");

                entity.HasIndex(e => e.RacePointNameId, "challenge_match_raw_point_0_race_point_name_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.Point)
                    .HasColumnType("int(11)")
                    .HasColumnName("point");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.RacePointNameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_point_name_id");
                entity.Property(e => e.SortOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_order");
            });

            modelBuilder.Entity<ChampionsBgm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_bgm");

                entity.HasIndex(e => new { e.RoundId, e.SceneType, e.RaceNumber }, "champions_bgm_0_round_id_1_scene_type_2_race_number");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name");
                entity.Property(e => e.CuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cuesheet_name");
                entity.Property(e => e.FirstBgmPattern)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_bgm_pattern");
                entity.Property(e => e.RaceNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_number");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
                entity.Property(e => e.SceneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("scene_type");
                entity.Property(e => e.SecondBgmPattern)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<ChampionsEvaluationRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_evaluation_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ProperRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_rank");
                entity.Property(e => e.ProperType)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_type");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<ChampionsNewsCharaComment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_news_chara_comment");

                entity.HasIndex(e => e.RoundId, "champions_news_chara_comment_0_round_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BigFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("big_flag");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
            });

            modelBuilder.Entity<ChampionsNewsRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_news_race");

                entity.HasIndex(e => e.RoundId, "champions_news_race_0_round_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Distance)
                    .HasColumnType("int(11)")
                    .HasColumnName("distance");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");
                entity.Property(e => e.ResourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("resource_id");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
                entity.Property(e => e.TextNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_number");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
                entity.Property(e => e.WinPercentType)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_percent_type");
            });

            modelBuilder.Entity<ChampionsNewsTitle>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_news_title");

                entity.HasIndex(e => e.RoundId, "champions_news_title_0_round_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Distance)
                    .HasColumnType("int(11)")
                    .HasColumnName("distance");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");
                entity.Property(e => e.ResourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("resource_id");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
                entity.Property(e => e.SubTitle)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_title");
                entity.Property(e => e.Title)
                    .HasColumnType("int(11)")
                    .HasColumnName("title");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
                entity.Property(e => e.WinPercentType)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_percent_type");
            });

            modelBuilder.Entity<ChampionsNewsWinComment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_news_win_comment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BigFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("big_flag");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
            });

            modelBuilder.Entity<ChampionsNewsWinTitle>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_news_win_title");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BashinMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("bashin_max");
                entity.Property(e => e.BashinMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("bashin_min");
                entity.Property(e => e.Distance)
                    .HasColumnType("int(11)")
                    .HasColumnName("distance");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");
                entity.Property(e => e.ResourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("resource_id");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
                entity.Property(e => e.RunningStyle)
                    .HasColumnType("int(11)")
                    .HasColumnName("running_style");
                entity.Property(e => e.SubTitle)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_title");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
                entity.Property(e => e.WinPercentType)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_percent_type");
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
                    .HasColumnType("int(11)")
                    .HasColumnName("race_condition_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<ChampionsRewardRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_reward_rate");

                entity.HasIndex(e => new { e.ChampionsId, e.RoundId }, "champions_reward_rate_0_champions_id_1_round_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BoxGrade)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_grade");
                entity.Property(e => e.ChampionsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_id");
                entity.Property(e => e.LeagueType)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_type");
                entity.Property(e => e.Ranking)
                    .HasColumnType("int(11)")
                    .HasColumnName("ranking");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
                entity.Property(e => e.WinCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_count");
            });

            modelBuilder.Entity<ChampionsRoundDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_round_detail");

                entity.HasIndex(e => new { e.ChampionsId, e.LeagueType }, "champions_round_detail_0_champions_id_1_league_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BreakthroughNumber1)
                    .HasColumnType("int(11)")
                    .HasColumnName("breakthrough_number_1");
                entity.Property(e => e.BreakthroughNumber2)
                    .HasColumnType("int(11)")
                    .HasColumnName("breakthrough_number_2");
                entity.Property(e => e.ChampionsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_id");
                entity.Property(e => e.EntryNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("entry_number");
                entity.Property(e => e.FreeEntryNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("free_entry_number");
                entity.Property(e => e.LeagueType)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_type");
                entity.Property(e => e.Round)
                    .HasColumnType("int(11)")
                    .HasColumnName("round");
                entity.Property(e => e.RoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_id");
                entity.Property(e => e.RoundNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_number");
                entity.Property(e => e.Tier)
                    .HasColumnType("int(11)")
                    .HasColumnName("tier");
            });

            modelBuilder.Entity<ChampionsRoundSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_round_schedule");

                entity.HasIndex(e => e.ChampionsId, "champions_round_schedule_0_champions_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ChampionsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.IntervalEndTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("interval_end_time");
                entity.Property(e => e.IntervalStartTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("interval_start_time");
                entity.Property(e => e.Round)
                    .HasColumnType("int(11)")
                    .HasColumnName("round");
                entity.Property(e => e.RoundDetail)
                    .HasColumnType("int(11)")
                    .HasColumnName("round_detail");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ChampionsSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("champions_schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ChampionsBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_bg_id");
                entity.Property(e => e.ChampionsBgPositionX)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_bg_position_x");
                entity.Property(e => e.ChampionsBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_bg_sub_id");
                entity.Property(e => e.ChampionsCharaSelectBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_chara_select_bg_id");
                entity.Property(e => e.ChampionsCharaSelectBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_chara_select_bg_sub_id");
                entity.Property(e => e.ChampionsFinishBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_finish_bg_id");
                entity.Property(e => e.ChampionsFinishBgPositionX)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_finish_bg_position_x");
                entity.Property(e => e.ChampionsFinishBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_finish_bg_sub_id");
                entity.Property(e => e.ChampionsLeagueSelectBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("champions_league_select_bg_sub_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.InfoDetail)
                    .HasColumnType("int(11)")
                    .HasColumnName("info_detail");
                entity.Property(e => e.InfoDetail1)
                    .HasColumnType("int(11)")
                    .HasColumnName("info_detail_1");
                entity.Property(e => e.InfoDetail2)
                    .HasColumnType("int(11)")
                    .HasColumnName("info_detail_2");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.ResourceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("resource_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_set");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
            });

            modelBuilder.Entity<CharaCategoryMotion>(entity =>
            {
                entity.HasKey(e => e.CharaId).HasName("PRIMARY");

                entity.ToTable("chara_category_motion");

                entity.Property(e => e.CharaId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.StandbyMotion1)
                    .HasColumnType("int(11)")
                    .HasColumnName("standby_motion_1");
                entity.Property(e => e.StandbyMotion2)
                    .HasColumnType("int(11)")
                    .HasColumnName("standby_motion_2");
                entity.Property(e => e.StandbyMotion3)
                    .HasColumnType("int(11)")
                    .HasColumnName("standby_motion_3");
                entity.Property(e => e.StandbyMotion4)
                    .HasColumnType("int(11)")
                    .HasColumnName("standby_motion_4");
                entity.Property(e => e.StandbyMotion5)
                    .HasColumnType("int(11)")
                    .HasColumnName("standby_motion_5");
                entity.Property(e => e.StandbyMotion6)
                    .HasColumnType("int(11)")
                    .HasColumnName("standby_motion_6");
            });

            modelBuilder.Entity<CharaDataGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_data_group");

                entity.HasIndex(e => e.CharaId, "chara_data_group_0_chara_id");

                entity.HasIndex(e => e.GroupId, "chara_data_group_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<CharaData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AttachmentModelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("attachment_model_id");
                entity.Property(e => e.BirthDay)
                    .HasColumnType("int(11)")
                    .HasColumnName("birth_day");
                entity.Property(e => e.BirthMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("birth_month");
                entity.Property(e => e.BirthYear)
                    .HasColumnType("int(11)")
                    .HasColumnName("birth_year");
                entity.Property(e => e.Bust)
                    .HasColumnType("int(11)")
                    .HasColumnName("bust");
                entity.Property(e => e.CharaCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_category");
                entity.Property(e => e.EarRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("ear_random_time_max");
                entity.Property(e => e.EarRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("ear_random_time_min");
                entity.Property(e => e.Height)
                    .HasColumnType("int(11)")
                    .HasColumnName("height");
                entity.Property(e => e.ImageColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_main");
                entity.Property(e => e.ImageColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_sub");
                entity.Property(e => e.LastYear)
                    .HasColumnType("int(11)")
                    .HasColumnName("last_year");
                entity.Property(e => e.LoveRankLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("love_rank_limit");
                entity.Property(e => e.MiniMayuShaderType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_mayu_shader_type");
                entity.Property(e => e.PersonalDress)
                    .HasColumnType("int(11)")
                    .HasColumnName("personal_dress");
                entity.Property(e => e.RaceRunningType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_running_type");
                entity.Property(e => e.Scale)
                    .HasColumnType("int(11)")
                    .HasColumnName("scale");
                entity.Property(e => e.Sex)
                    .HasColumnType("int(11)")
                    .HasColumnName("sex");
                entity.Property(e => e.Shape)
                    .HasColumnType("int(11)")
                    .HasColumnName("shape");
                entity.Property(e => e.Skin)
                    .HasColumnType("int(11)")
                    .HasColumnName("skin");
                entity.Property(e => e.Socks)
                    .HasColumnType("int(11)")
                    .HasColumnName("socks");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryEarRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_ear_random_time_max");
                entity.Property(e => e.StoryEarRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_ear_random_time_min");
                entity.Property(e => e.StoryTailRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_tail_random_time_max");
                entity.Property(e => e.StoryTailRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_tail_random_time_min");
                entity.Property(e => e.TailModelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_model_id");
                entity.Property(e => e.TailRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_random_time_max");
                entity.Property(e => e.TailRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_random_time_min");
                entity.Property(e => e.UiBorderColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_border_color");
                entity.Property(e => e.UiColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_main");
                entity.Property(e => e.UiColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_sub");
                entity.Property(e => e.UiNameplateColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_1");
                entity.Property(e => e.UiNameplateColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_2");
                entity.Property(e => e.UiNumColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_1");
                entity.Property(e => e.UiNumColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_2");
                entity.Property(e => e.UiSpeechColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_1");
                entity.Property(e => e.UiSpeechColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_2");
                entity.Property(e => e.UiTrainingColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_1");
                entity.Property(e => e.UiTrainingColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_2");
                entity.Property(e => e.UiTurnColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_turn_color");
                entity.Property(e => e.UiWipeColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_1");
                entity.Property(e => e.UiWipeColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_2");
                entity.Property(e => e.UiWipeColor3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_3");
            });

            modelBuilder.Entity<CharaDressColorSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_dress_color_set");

                entity.HasIndex(e => e.DressId, "chara_dress_color_set_0_dress_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AreaMapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("area_map_id");
                entity.Property(e => e.ColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b1");
                entity.Property(e => e.ColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b2");
                entity.Property(e => e.ColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g1");
                entity.Property(e => e.ColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g2");
                entity.Property(e => e.ColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r1");
                entity.Property(e => e.ColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r2");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.ToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b1");
                entity.Property(e => e.ToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b2");
                entity.Property(e => e.ToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g1");
                entity.Property(e => e.ToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g2");
                entity.Property(e => e.ToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r1");
                entity.Property(e => e.ToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r2");
            });

            modelBuilder.Entity<CharaDressColorSetDefault>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_dress_color_set_default");

                entity.HasIndex(e => e.CharaId, "chara_dress_color_set_default_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ColorSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("color_set_id");
            });

            modelBuilder.Entity<CharaMotionAct>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_motion_act");

                entity.HasIndex(e => e.CharaId, "chara_motion_act_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.CommandName }, "chara_motion_act_0_chara_id_1_command_name").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("command_name");
                entity.Property(e => e.TargetMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_motion");
            });

            modelBuilder.Entity<CharaMotionSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_motion_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BodyMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("body_motion");
                entity.Property(e => e.BodyMotionPathSegment)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_motion_path_segment");
                entity.Property(e => e.BodyMotionPlayType)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_motion_play_type");
                entity.Property(e => e.BodyMotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_motion_type");
                entity.Property(e => e.Cheek)
                    .HasColumnType("int(11)")
                    .HasColumnName("cheek");
                entity.Property(e => e.EarMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ear_motion");
                entity.Property(e => e.EyeDefault)
                    .HasColumnType("int(11)")
                    .HasColumnName("eye_default");
                entity.Property(e => e.FaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("face_type");
                entity.Property(e => e.TailMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_motion");
                entity.Property(e => e.TailMotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_motion_type");
            });

            modelBuilder.Entity<CharaStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_story_data");

                entity.HasIndex(e => e.CharaId, "chara_story_data_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.EpisodeIndex }, "chara_story_data_0_chara_id_1_episode_index");

                entity.HasIndex(e => e.StoryId, "chara_story_data_0_story_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_category_1");
                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_id_1");
                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_num_1");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.EpisodeIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index");
                entity.Property(e => e.ExpType)
                    .HasColumnType("int(11)")
                    .HasColumnName("exp_type");
                entity.Property(e => e.LockType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_type_1");
                entity.Property(e => e.LockValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_1_1");
                entity.Property(e => e.LockValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_1_2");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<CharaType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("chara_type");

                entity.HasIndex(e => new { e.TargetScene, e.TargetCut }, "chara_type_0_target_scene_1_target_cut");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.TargetCut)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_cut");
                entity.Property(e => e.TargetScene)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_scene");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.Value)
                    .HasColumnType("int(11)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CharacterPropAnimation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("character_prop_animation");

                entity.HasIndex(e => new { e.PropId, e.SceneType }, "character_prop_animation_0_prop_id_1_scene_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.LayerIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("layer_index");
                entity.Property(e => e.PropAnimId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_anim_id");
                entity.Property(e => e.PropId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id");
                entity.Property(e => e.SceneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("scene_type");
                entity.Property(e => e.UseStateName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("use_state_name");
            });

            modelBuilder.Entity<CharacterSystemLottery>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("character_system_lottery");

                entity.HasIndex(e => e.CharaId, "character_system_lottery_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.Trigger }, "character_system_lottery_0_chara_id_1_trigger");

                entity.HasIndex(e => new { e.Trigger, e.Param1 }, "character_system_lottery_0_trigger_1_param1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.CardRarityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_rarity_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Param1)
                    .HasColumnType("int(11)")
                    .HasColumnName("param1");
                entity.Property(e => e.Per)
                    .HasColumnType("int(11)")
                    .HasColumnName("per");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.SysTextId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sys_text_id");
                entity.Property(e => e.Trigger)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.CueId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cue_id");
                entity.Property(e => e.CueSheet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_sheet");
                entity.Property(e => e.GalleryKeyUsageCondition)
                    .HasColumnType("int(11)")
                    .HasColumnName("gallery_key_usage_condition");
                entity.Property(e => e.Gender)
                    .HasColumnType("int(11)")
                    .HasColumnName("gender");
                entity.Property(e => e.LipSyncData)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("lip_sync_data");
                entity.Property(e => e.MotionSecondSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_second_set");
                entity.Property(e => e.MotionSecondStart)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_second_start");
                entity.Property(e => e.MotionSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_set");
                entity.Property(e => e.Scene)
                    .HasColumnType("int(11)")
                    .HasColumnName("scene");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text");
                entity.Property(e => e.UseGallery)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_gallery");
            });

            modelBuilder.Entity<CircleRankData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("circle_rank_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.NeedRankingMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_ranking_max");
                entity.Property(e => e.NeedRankingMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_ranking_min");
                entity.Property(e => e.RewardItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_category_1");
                entity.Property(e => e.RewardItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_category_2");
                entity.Property(e => e.RewardItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_id_1");
                entity.Property(e => e.RewardItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_id_2");
                entity.Property(e => e.RewardNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_num_1");
                entity.Property(e => e.RewardNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_num_2");
            });

            modelBuilder.Entity<CircleStampData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("circle_stamp_data");

                entity.HasIndex(e => e.DispOrder, "disp_order").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CollectEventMapBgData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_event_map_bg_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
            });

            modelBuilder.Entity<CollectEventMapMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_event_map_master");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BannerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("banner_id");
                entity.Property(e => e.BgDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_data_id");
                entity.Property(e => e.CollectTapEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_tap_end_date");
                entity.Property(e => e.CollectTapMaxPosIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_tap_max_pos_index");
                entity.Property(e => e.CollectTapRewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_tap_reward_set_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EventEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_end_date");
                entity.Property(e => e.LoginBonusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("login_bonus_id");
                entity.Property(e => e.ShortEpisodeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("short_episode_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TipsGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tips_group_id");
            });

            modelBuilder.Entity<CollectRaidAllReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_all_reward");

                entity.HasIndex(e => e.AllRewardSetId, "collect_raid_all_reward_0_all_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AllCollectItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("all_collect_item_num");
                entity.Property(e => e.AllRewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("all_reward_set_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<CollectRaidDressColor>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_dress_color");

                entity.HasIndex(e => e.CollectRaidId, "collect_raid_dress_color_0_collect_raid_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CollectRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_raid_id");
                entity.Property(e => e.ColorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("color_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
            });

            modelBuilder.Entity<CollectRaidIndividualReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_individual_reward");

                entity.HasIndex(e => e.IndividualRewardSetId, "collect_raid_individual_reward_0_individual_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.IndividualCollectItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("individual_collect_item_num");
                entity.Property(e => e.IndividualRewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("individual_reward_set_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<CollectRaidMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_master");

                entity.HasIndex(e => e.IndividualRewardSetId, "collect_raid_master_0_individual_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AllRewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("all_reward_set_id");
                entity.Property(e => e.CalcEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("calc_end_date");
                entity.Property(e => e.CalcStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("calc_start_date");
                entity.Property(e => e.CollectEventMapMasterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_event_map_master_id");
                entity.Property(e => e.CollectItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_item_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.GainCollectItemMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_collect_item_min");
                entity.Property(e => e.GainCollectItemRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_collect_item_rate");
                entity.Property(e => e.IndividualRewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("individual_reward_set_id");
                entity.Property(e => e.MissionTopCharaGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mission_top_chara_group_id");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.StagingMiniCharaGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("staging_mini_chara_group_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryExtraId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_extra_id");
                entity.Property(e => e.StoryListBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_list_bg_id");
                entity.Property(e => e.StoryListBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_list_bg_sub_id");
                entity.Property(e => e.StorySetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_set_id");
                entity.Property(e => e.StoryVoiceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_voice_type");
                entity.Property(e => e.UseAllRewardVoice)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_all_reward_voice");
                entity.Property(e => e.UseMission)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_mission");
                entity.Property(e => e.UseTransitionDialog)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_transition_dialog");
            });

            modelBuilder.Entity<CollectRaidMission>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_mission");

                entity.HasIndex(e => e.MissionDataId, "collect_raid_mission_0_mission_data_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CollectRaidMasterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_raid_master_id");
                entity.Property(e => e.MissionDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mission_data_id");
            });

            modelBuilder.Entity<CollectRaidMissionTopChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_mission_top_chara");

                entity.HasIndex(e => e.MissionTopCharaGroupId, "collect_raid_mission_top_chara_0_mission_top_chara_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EndingFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_flag");
                entity.Property(e => e.MissionTopCharaGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mission_top_chara_group_id");
            });

            modelBuilder.Entity<CollectRaidSegmentCutt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_segment_cutt");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.CutSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_sub_id");
            });

            modelBuilder.Entity<CollectRaidStagingMiniChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_staging_mini_chara");

                entity.HasIndex(e => e.StagingMiniCharaGroupId, "collect_raid_staging_mini_chara_0_staging_mini_chara_group_id");

                entity.HasIndex(e => new { e.StagingMiniCharaGroupId, e.StagingType }, "collect_raid_staging_mini_chara_0_staging_mini_chara_group_id_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaAngle)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_angle");
                entity.Property(e => e.CharaAngle2)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_angle_2");
                entity.Property(e => e.CharaAngle3)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_angle_3");
                entity.Property(e => e.CharaAngle4)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_angle_4");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CharaId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_2");
                entity.Property(e => e.CharaId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_3");
                entity.Property(e => e.CharaId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_4");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.DressId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id_2");
                entity.Property(e => e.DressId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id_3");
                entity.Property(e => e.DressId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id_4");
                entity.Property(e => e.MiniMotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_id");
                entity.Property(e => e.MiniMotionId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_id_2");
                entity.Property(e => e.MiniMotionId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_id_3");
                entity.Property(e => e.MiniMotionId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_id_4");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
                entity.Property(e => e.StagingMiniCharaGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("staging_mini_chara_group_id");
                entity.Property(e => e.StagingType)
                    .HasColumnType("int(11)")
                    .HasColumnName("staging_type");
            });

            modelBuilder.Entity<CollectRaidStory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_story");

                entity.HasIndex(e => e.StorySetId, "collect_raid_story_0_story_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CollectRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_raid_id");
                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index_id");
                entity.Property(e => e.StoryConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_condition_type");
                entity.Property(e => e.StoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_1");
                entity.Property(e => e.StoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_2");
                entity.Property(e => e.StoryId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_3");
                entity.Property(e => e.StorySetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_set_id");
                entity.Property(e => e.StoryType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_1");
                entity.Property(e => e.StoryType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_2");
                entity.Property(e => e.StoryType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_3");
                entity.Property(e => e.UnlockCondition)
                    .HasColumnType("int(11)")
                    .HasColumnName("unlock_condition");
            });

            modelBuilder.Entity<CollectRaidTopData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("collect_raid_top_data");

                entity.HasIndex(e => e.CollectRaidId, "collect_raid_top_data_0_collect_raid_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.CollectRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("collect_raid_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.CutSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_sub_id");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.SegmentCuttId)
                    .HasColumnType("int(11)")
                    .HasColumnName("segment_cutt_id");
            });

            modelBuilder.Entity<CraneGameArmSwing>(entity =>
            {
                entity.HasKey(e => e.ResultType).HasName("PRIMARY");

                entity.ToTable("crane_game_arm_swing");

                entity.Property(e => e.ResultType)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("result_type");
                entity.Property(e => e.Odds1)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds_1");
                entity.Property(e => e.Odds2)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds_2");
                entity.Property(e => e.Odds3)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_1_1");
                entity.Property(e => e.LotteryWeight12)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_1_2");
                entity.Property(e => e.LotteryWeight21)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_2_1");
                entity.Property(e => e.LotteryWeight22)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_2_2");
                entity.Property(e => e.LotteryWeight31)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_3_1");
                entity.Property(e => e.LotteryWeight32)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_3_2");
                entity.Property(e => e.LotteryWeightExtra1)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_extra_1");
                entity.Property(e => e.LotteryWeightExtra2)
                    .HasColumnType("int(11)")
                    .HasColumnName("lottery_weight_extra_2");
            });

            modelBuilder.Entity<CraneGameDefineParam>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("crane_game_define_param");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Distance1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("distance1");
                entity.Property(e => e.Distance2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("distance2");
                entity.Property(e => e.MoveSpeed1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("move_speed_1");
                entity.Property(e => e.MoveSpeed2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("move_speed_2");
                entity.Property(e => e.MoveSpeed3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("move_speed_3");
            });

            modelBuilder.Entity<CraneGameExtraOddsCondition>(entity =>
            {
                entity.HasKey(e => e.Credit).HasName("PRIMARY");

                entity.ToTable("crane_game_extra_odds_condition");

                entity.Property(e => e.Credit)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("credit");
                entity.Property(e => e.GetNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("get_num");
            });

            modelBuilder.Entity<CraneGameHiddenOdd>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("crane_game_hidden_odds");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AnimationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("animation_id");
                entity.Property(e => e.Big)
                    .HasColumnType("int(11)")
                    .HasColumnName("big");
                entity.Property(e => e.BigIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("big_index");
                entity.Property(e => e.CraneAnimationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("crane_animation_id");
                entity.Property(e => e.JointType)
                    .HasColumnType("int(11)")
                    .HasColumnName("joint_type");
                entity.Property(e => e.LiftType)
                    .HasColumnType("int(11)")
                    .HasColumnName("lift_type");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
                entity.Property(e => e.Odds1)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds_1");
                entity.Property(e => e.Odds2)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds_2");
                entity.Property(e => e.Odds3)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds_3");
                entity.Property(e => e.OddsExtra)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds_extra");
                entity.Property(e => e.PushType)
                    .HasColumnType("int(11)")
                    .HasColumnName("push_type");
                entity.Property(e => e.RareEffectOdds)
                    .HasColumnType("int(11)")
                    .HasColumnName("rare_effect_odds");
                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id");
            });

            modelBuilder.Entity<CraneGamePrizeFace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("crane_game_prize_face");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("face_type");
            });

            modelBuilder.Entity<CraneGamePrizePattern>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("crane_game_prize_pattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.PropPatternId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_pattern_id");
            });

            modelBuilder.Entity<CraneGameProp>(entity =>
            {
                entity.HasKey(e => e.Type).HasName("PRIMARY");

                entity.ToTable("crane_game_prop");

                entity.Property(e => e.Type)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
            });

            modelBuilder.Entity<DailyLegendRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("daily_legend_race");

                entity.HasIndex(e => e.GroupId, "daily_legend_race_0_group_id");

                entity.HasIndex(e => e.RaceInstanceId, "daily_legend_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CostNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_num");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.DropRewardOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("drop_reward_odds_id");
                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_1");
                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_2");
                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_3");
                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_1");
                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_2");
                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_3");
                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_1");
                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_2");
                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_3");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.HasUniqueBgEnv)
                    .HasColumnType("int(11)")
                    .HasColumnName("has_unique_bg_env");
                entity.Property(e => e.ImageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("image_id");
                entity.Property(e => e.LegendBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_bg_id");
                entity.Property(e => e.LegendBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_bg_sub_id");
                entity.Property(e => e.LegendRaceBossNpcId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_race_boss_npc_id");
                entity.Property(e => e.PickUpItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_1");
                entity.Property(e => e.PickUpItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_2");
                entity.Property(e => e.PickUpItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_3");
                entity.Property(e => e.PickUpItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_1");
                entity.Property(e => e.PickUpItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_2");
                entity.Property(e => e.PickUpItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_3");
                entity.Property(e => e.PickUpItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_1");
                entity.Property(e => e.PickUpItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_2");
                entity.Property(e => e.PickUpItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_3");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.VictoryRewardOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("victory_reward_odds_id");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
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
                    .HasColumnType("int(11)")
                    .HasColumnName("daily_free_num");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.RepurchaseDay)
                    .HasColumnType("int(11)")
                    .HasColumnName("repurchase_day");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.Term)
                    .HasColumnType("int(11)")
                    .HasColumnName("term");
            });

            modelBuilder.Entity<DailyRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("daily_race");

                entity.HasIndex(e => e.RaceInstanceId, "daily_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusRewardsOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_rewards_odds_id");
                entity.Property(e => e.CostNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_num");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_1");
                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_2");
                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_3");
                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_1");
                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_2");
                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_3");
                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_1");
                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_2");
                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_3");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.NormalRewardsOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("normal_rewards_odds_id");
                entity.Property(e => e.PickUpItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_1");
                entity.Property(e => e.PickUpItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_2");
                entity.Property(e => e.PickUpItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_3");
                entity.Property(e => e.PickUpItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_1");
                entity.Property(e => e.PickUpItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_2");
                entity.Property(e => e.PickUpItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_3");
                entity.Property(e => e.PickUpItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_1");
                entity.Property(e => e.PickUpItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_2");
                entity.Property(e => e.PickUpItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_3");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.RareRewardOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rare_reward_odds_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.UniqueCharaNpcMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("unique_chara_npc_max");
                entity.Property(e => e.UniqueCharaNpcMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("unique_chara_npc_min");
            });

            modelBuilder.Entity<DailyRaceBilling>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("daily_race_billing");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Frequency)
                    .HasColumnType("int(11)")
                    .HasColumnName("frequency");
                entity.Property(e => e.PayCost)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_cost");
            });

            modelBuilder.Entity<DailyRaceNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("daily_race_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<DeckRecommendException>(entity =>
            {
                entity.HasKey(e => e.SupportCardId).HasName("PRIMARY");

                entity.ToTable("deck_recommend_exception");

                entity.Property(e => e.SupportCardId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.DistributionFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("distribution_flag");
            });

            modelBuilder.Entity<DeckRecommendLvCorrection>(entity =>
            {
                entity.HasKey(e => e.ConditionType).HasName("PRIMARY");

                entity.ToTable("deck_recommend_lv_correction");

                entity.Property(e => e.ConditionType)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.CorrectionLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("correction_lv");
            });

            modelBuilder.Entity<DeckRecommendOrganize>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("deck_recommend_organize");

                entity.HasIndex(e => e.DistanceType, "deck_recommend_organize_0_distance_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id_1");
                entity.Property(e => e.CommandId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id_2");
                entity.Property(e => e.CommandId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id_3");
                entity.Property(e => e.CommandId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id_4");
                entity.Property(e => e.CommandId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id_5");
                entity.Property(e => e.CommandId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id_6");
                entity.Property(e => e.DistanceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("distance_type");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<Directory>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("directory");

                entity.HasIndex(e => e.RankLevel, "directory_0_rank_level").IsUnique();

                entity.HasIndex(e => e.RequiredPoint, "directory_0_required_point");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.RankLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_level");
                entity.Property(e => e.RequiredPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("required_point");
            });

            modelBuilder.Entity<DressData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("dress_data");

                entity.HasIndex(e => e.BodyType, "dress_data_0_body_type");

                entity.HasIndex(e => e.CharaId, "dress_data_0_chara_id");

                entity.HasIndex(e => e.ConditionType, "dress_data_0_condition_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BodySetting)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_setting");
                entity.Property(e => e.BodyShape)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_shape");
                entity.Property(e => e.BodyType)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_type");
                entity.Property(e => e.BodyTypeSub)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_type_sub");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ColorNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("color_num");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.CostumeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("costume_type");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.DressColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_main");
                entity.Property(e => e.DressColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_sub");
                entity.Property(e => e.EndTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_time");
                entity.Property(e => e.GeneralPurpose)
                    .HasColumnType("int(11)")
                    .HasColumnName("general_purpose");
                entity.Property(e => e.HaveMini)
                    .HasColumnType("int(11)")
                    .HasColumnName("have_mini");
                entity.Property(e => e.HeadSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("head_sub_id");
                entity.Property(e => e.IsDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_dirt");
                entity.Property(e => e.IsWet)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_wet");
                entity.Property(e => e.MiniMayuShaderType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_mayu_shader_type");
                entity.Property(e => e.StartTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_time");
                entity.Property(e => e.TailModelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_model_id");
                entity.Property(e => e.TailModelSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_model_sub_id");
                entity.Property(e => e.UseDressChange)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_dress_change");
                entity.Property(e => e.UseGender)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_gender");
                entity.Property(e => e.UseHome)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_home");
                entity.Property(e => e.UseLive)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_live");
                entity.Property(e => e.UseLiveTheater)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_live_theater");
                entity.Property(e => e.UseRace)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_race");
                entity.Property(e => e.UseSeason)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_season");
            });

            modelBuilder.Entity<EventMotionData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("event_motion_data");

                entity.HasIndex(e => e.CommandName, "command_name").IsUnique();

                entity.HasIndex(e => e.Type, "event_motion_data_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseStateName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("base_state_name");
                entity.Property(e => e.Category)
                    .HasColumnType("int(11)")
                    .HasColumnName("category");
                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("command_name");
                entity.Property(e => e.EndBlendTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_blend_time");
                entity.Property(e => e.PoseBlend)
                    .HasColumnType("int(11)")
                    .HasColumnName("pose_blend");
                entity.Property(e => e.StartBlendTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_blend_time");
                entity.Property(e => e.StateGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("state_group");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<EventMotionPlusData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("event_motion_plus_data");

                entity.HasIndex(e => e.BaseStateName, "event_motion_plus_data_0_base_state_name");

                entity.HasIndex(e => e.LayerIndex, "event_motion_plus_data_0_layer_index");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseStateName)
                    .IsRequired()
                    .HasMaxLength(750)
                    .HasColumnName("base_state_name");
                entity.Property(e => e.CommandName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("command_name");
                entity.Property(e => e.EndBlendTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_blend_time");
                entity.Property(e => e.LayerIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("layer_index");
                entity.Property(e => e.StartBlendTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_blend_time");
                entity.Property(e => e.TailMotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_motion_type");
            });

            modelBuilder.Entity<ExchangeTicketDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("exchange_ticket_detail");

                entity.HasIndex(e => e.CardType, "exchange_ticket_detail_0_card_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AdditionalPieceNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.CardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_type");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<FaceTypeData>(entity =>
            {
                entity.HasKey(e => e.Label).HasName("PRIMARY");

                entity.ToTable("face_type_data");

                entity.Property(e => e.Label)
                    .HasMaxLength(300)
                    .HasColumnName("label");
                entity.Property(e => e.EyeL)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_l");
                entity.Property(e => e.EyeR)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_r");
                entity.Property(e => e.EyebrowL)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eyebrow_l");
                entity.Property(e => e.EyebrowR)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eyebrow_r");
                entity.Property(e => e.InverceFaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("inverce_face_type");
                entity.Property(e => e.Mouth)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mouth");
                entity.Property(e => e.MouthShapeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mouth_shape_type");
                entity.Property(e => e.SetFaceGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("set_face_group");
            });

            modelBuilder.Entity<FacialMouthChange>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("facial_mouth_change");

                entity.HasIndex(e => e.CharaId, "facial_mouth_change_0_chara_id");

                entity.HasIndex(e => new { e.CharaId, e.BeforeFacialname }, "facial_mouth_change_0_chara_id_1_before_facialname").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AfterFacialname)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("after_facialname");
                entity.Property(e => e.BeforeFacialname)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("before_facialname");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
            });

            modelBuilder.Entity<FactorResearchAnimationData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("factor_research_animation_data");

                entity.HasIndex(e => new { e.SpecialEventType, e.PriseType }, "factor_research_animation_data_0_special_event_type_1_prise_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaAngle)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_angle");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CharaOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_order");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.InMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("in_motion");
                entity.Property(e => e.PriseType)
                    .HasColumnType("int(11)")
                    .HasColumnName("prise_type");
                entity.Property(e => e.PrizeMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_motion");
                entity.Property(e => e.SpecialEventType)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_event_type");
                entity.Property(e => e.StandMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("stand_motion");
            });

            modelBuilder.Entity<FactorResearchBox>(entity =>
            {
                entity.HasKey(e => e.BoxId).HasName("PRIMARY");

                entity.ToTable("factor_research_box");

                entity.HasIndex(e => e.FactorResearchEventId, "factor_research_box_0_factor_research_event_id");

                entity.Property(e => e.BoxId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("box_id");
                entity.Property(e => e.BoxStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_step");
                entity.Property(e => e.FactorResearchEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_research_event_id");
            });

            modelBuilder.Entity<FactorResearchBoxReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("factor_research_box_reward");

                entity.HasIndex(e => e.BoxId, "factor_research_box_reward_0_box_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BoxId)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_id");
                entity.Property(e => e.BoxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_num");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.PrizeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_type");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<FactorResearchData>(entity =>
            {
                entity.HasKey(e => e.FactorResearchEventId).HasName("PRIMARY");

                entity.ToTable("factor_research_data");

                entity.Property(e => e.FactorResearchEventId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_research_event_id");
                entity.Property(e => e.BonusRewardRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_reward_ratio");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ConsumeTpRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("consume_tp_ratio");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EndingDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_date");
                entity.Property(e => e.InMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("in_motion");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.PrizeMotion1)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_motion1");
                entity.Property(e => e.PrizeMotion2)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_motion2");
                entity.Property(e => e.ResultType)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_type");
                entity.Property(e => e.SpecialEventType)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_event_type");
                entity.Property(e => e.StandMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("stand_motion");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<FactorResearchFactorUpgrade>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("factor_research_factor_upgrade");

                entity.HasIndex(e => e.FactorType, "factor_research_factor_upgrade_0_factor_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FactorRarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_rarity");
                entity.Property(e => e.FactorType)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_type");
                entity.Property(e => e.IsUpgradable)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_upgradable");
                entity.Property(e => e.UseItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_item_num");
            });

            modelBuilder.Entity<FactorResearchTop>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("factor_research_top");

                entity.HasIndex(e => new { e.FactorResearchEventId, e.EndingFlag }, "factor_research_top_0_factor_research_event_id_1_ending_flag");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EndingFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_flag");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.FactorResearchEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_research_event_id");
                entity.Property(e => e.MenuBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_id");
                entity.Property(e => e.MenuBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_sub_id");
            });

            modelBuilder.Entity<FanRaidAllReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("fan_raid_all_reward");

                entity.HasIndex(e => e.FanRaidId, "fan_raid_all_reward_0_fan_raid_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AllFan)
                    .HasColumnType("int(11)")
                    .HasColumnName("all_fan");
                entity.Property(e => e.FanRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_raid_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<FanRaidBonusChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("fan_raid_bonus_chara");

                entity.HasIndex(e => e.FanRaidId, "fan_raid_bonus_chara_0_fan_raid_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddFan)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_fan");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.FanRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_raid_id");
            });

            modelBuilder.Entity<FanRaidBonusSupportCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("fan_raid_bonus_support_card");

                entity.HasIndex(e => e.FanRaidId, "fan_raid_bonus_support_card_0_fan_raid_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddFan)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_fan");
                entity.Property(e => e.FanRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_raid_id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<FanRaidData>(entity =>
            {
                entity.HasKey(e => e.FanRaidId).HasName("PRIMARY");

                entity.ToTable("fan_raid_data");

                entity.Property(e => e.FanRaidId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_raid_id");
                entity.Property(e => e.CalcEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("calc_end_date");
                entity.Property(e => e.CalcStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("calc_start_date");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.ResultSeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_se_cue_name");
                entity.Property(e => e.ResultSeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_se_cuesheet_name");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<FanRaidIndividualReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("fan_raid_individual_reward");

                entity.HasIndex(e => e.FanRaidId, "fan_raid_individual_reward_0_fan_raid_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FanRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_raid_id");
                entity.Property(e => e.IndividualFan)
                    .HasColumnType("int(11)")
                    .HasColumnName("individual_fan");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<FanRaidStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("fan_raid_story_data");

                entity.HasIndex(e => new { e.FanRaidId, e.StoryConditionType }, "fan_raid_story_data_0_fan_raid_id_1_story_condition_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FanRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_raid_id");
                entity.Property(e => e.StoryConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_condition_type");
                entity.Property(e => e.StoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_1");
                entity.Property(e => e.StoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_2");
                entity.Property(e => e.StoryType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_1");
                entity.Property(e => e.StoryType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_2");
            });

            modelBuilder.Entity<FanRaidTopChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("fan_raid_top_chara");

                entity.HasIndex(e => e.TopDataId, "fan_raid_top_chara_0_top_data_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.MiniMotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_id");
                entity.Property(e => e.TopDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("top_data_id");
            });

            modelBuilder.Entity<FanRaidTopData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("fan_raid_top_data");

                entity.HasIndex(e => e.FanRaidId, "fan_raid_top_data_0_fan_raid_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.FanRaidId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_raid_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
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
                    .HasColumnType("int(11)")
                    .HasColumnName("card_type");
                entity.Property(e => e.IsPickup)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_pickup");
                entity.Property(e => e.IsPrizeSelectable)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_prize_selectable");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.RecommendOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("recommend_order");
            });

            modelBuilder.Entity<GachaData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("gacha_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AdditionalPieceNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num_1");
                entity.Property(e => e.AdditionalPieceNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num_2");
                entity.Property(e => e.AdditionalPieceNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num_3");
                entity.Property(e => e.AdditionalPieceNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num_4");
                entity.Property(e => e.AdditionalPieceNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num_5");
                entity.Property(e => e.AdditionalPieceNum6)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num_6");
                entity.Property(e => e.AdditionalPieceTargetCardId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_id_1");
                entity.Property(e => e.AdditionalPieceTargetCardId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_id_2");
                entity.Property(e => e.AdditionalPieceTargetCardId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_id_3");
                entity.Property(e => e.AdditionalPieceTargetCardId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_id_4");
                entity.Property(e => e.AdditionalPieceTargetCardId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_id_5");
                entity.Property(e => e.AdditionalPieceTargetCardId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_id_6");
                entity.Property(e => e.AdditionalPieceTargetCardType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_type_1");
                entity.Property(e => e.AdditionalPieceTargetCardType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_type_2");
                entity.Property(e => e.AdditionalPieceTargetCardType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_type_3");
                entity.Property(e => e.AdditionalPieceTargetCardType4)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_type_4");
                entity.Property(e => e.AdditionalPieceTargetCardType5)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_type_5");
                entity.Property(e => e.AdditionalPieceTargetCardType6)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_card_type_6");
                entity.Property(e => e.AdditionalPieceTargetRarity1)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_rarity_1");
                entity.Property(e => e.AdditionalPieceTargetRarity2)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_rarity_2");
                entity.Property(e => e.AdditionalPieceTargetRarity3)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_rarity_3");
                entity.Property(e => e.AdditionalPieceTargetRarity4)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_rarity_4");
                entity.Property(e => e.AdditionalPieceTargetRarity5)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_rarity_5");
                entity.Property(e => e.AdditionalPieceTargetRarity6)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_target_rarity_6");
                entity.Property(e => e.BonusItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_item_category_1");
                entity.Property(e => e.BonusItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_item_category_2");
                entity.Property(e => e.BonusItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_item_id_1");
                entity.Property(e => e.BonusItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_item_id_2");
                entity.Property(e => e.BonusItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_item_num_1");
                entity.Property(e => e.BonusItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_item_num_2");
                entity.Property(e => e.BonusTargetDrawNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_target_draw_num");
                entity.Property(e => e.CardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_type");
                entity.Property(e => e.CostSingle)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_single");
                entity.Property(e => e.CostType)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_type");
                entity.Property(e => e.DailyPayCost)
                    .HasColumnType("int(11)")
                    .HasColumnName("daily_pay_cost");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.DrawGuaranteeNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_guarantee_num");
                entity.Property(e => e.DrawGuaranteeRarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_guarantee_rarity");
                entity.Property(e => e.DrawGuaranteeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_guarantee_type");
                entity.Property(e => e.DrawLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_limit");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.ForceExchange)
                    .HasColumnType("int(11)")
                    .HasColumnName("force_exchange");
                entity.Property(e => e.GachaOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_odds_id");
                entity.Property(e => e.OnlyOnceFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("only_once_flag");
                entity.Property(e => e.PaidGachaButtonType)
                    .HasColumnType("int(11)")
                    .HasColumnName("paid_gacha_button_type");
                entity.Property(e => e.PrizeOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_odds_id");
                entity.Property(e => e.RarityOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity_odds_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("card_type");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.PayItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_item_num");
            });

            modelBuilder.Entity<GachaFreeCampaign>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("gacha_free_campaign");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TargetDrawType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_draw_type");
            });

            modelBuilder.Entity<GachaGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("gacha_group");

                entity.HasIndex(e => e.GroupId, "gacha_group_0_group_id");

                entity.HasIndex(e => e.TargetGachaId, "gacha_group_0_target_gacha_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.TargetGachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_gacha_id");
            });

            modelBuilder.Entity<GachaPiece>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("gacha_piece");

                entity.HasIndex(e => e.Rarity, "gacha_piece_0_rarity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.PieceNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("piece_num");
                entity.Property(e => e.PieceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("piece_type");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_3");
                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_4");
                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_5");
                entity.Property(e => e.ItemCategory6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_6");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_3");
                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_4");
                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_5");
                entity.Property(e => e.ItemId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_6");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
                entity.Property(e => e.ItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_3");
                entity.Property(e => e.ItemNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_4");
                entity.Property(e => e.ItemNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_5");
                entity.Property(e => e.ItemNum6)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_6");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.PieceNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("piece_num");
            });

            modelBuilder.Entity<GachaStepUp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("gacha_stepup");

                entity.HasIndex(e => e.StepUpId, "gacha_stepup_0_stepup_id");

                entity.HasIndex(e => new { e.StepUpId, e.StepUpStep }, "gacha_stepup_0_stepup_id_1_stepup_step").IsUnique();

                entity.HasIndex(e => e.TargetGachaId, "gacha_stepup_0_target_gacha_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.StepUpId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stepup_id");
                entity.Property(e => e.StepUpStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("stepup_step");
                entity.Property(e => e.TargetGachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_gacha_id");
            });

            modelBuilder.Entity<GachaTopBg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("gacha_top_bg");

                entity.HasIndex(e => e.GachaId, "gacha_top_bg_0_gacha_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");
                entity.Property(e => e.LogoSizeX)
                    .HasColumnType("int(11)")
                    .HasColumnName("logo_size_x");
                entity.Property(e => e.LogoSizeY)
                    .HasColumnType("int(11)")
                    .HasColumnName("logo_size_y");
            });

            modelBuilder.Entity<GiftMessage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("gift_message");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Type1)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_1");
                entity.Property(e => e.Type2)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_2");
                entity.Property(e => e.Type3)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_3");
                entity.Property(e => e.Type4)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_4");
            });

            modelBuilder.Entity<HeroesData>(entity =>
            {
                entity.HasKey(e => e.HeroesId).HasName("PRIMARY");

                entity.ToTable("heroes_data");

                entity.Property(e => e.HeroesId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("heroes_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.FinalStageUserNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("final_stage_user_num");
                entity.Property(e => e.HeroGaugeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("hero_gauge_max");
                entity.Property(e => e.InfoDetail1)
                    .HasColumnType("int(11)")
                    .HasColumnName("info_detail_1");
                entity.Property(e => e.InfoDetail2)
                    .HasColumnType("int(11)")
                    .HasColumnName("info_detail_2");
                entity.Property(e => e.RaceItemLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_item_limit");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TicketAdd)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket_add");
                entity.Property(e => e.TicketMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket_max");
            });

            modelBuilder.Entity<HeroesFinalStageRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_final_stage_race");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.HeroesSpecialReward)
                    .HasColumnType("int(11)")
                    .HasColumnName("heroes_special_reward");
                entity.Property(e => e.RaceNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_number");
                entity.Property(e => e.RacePlay)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_play");
                entity.Property(e => e.RankingMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("ranking_max");
                entity.Property(e => e.RankingMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("ranking_min");
            });

            modelBuilder.Entity<HeroesGauge>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_gauge");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddTiming)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_timing");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.GaugeUp)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
            });

            modelBuilder.Entity<HeroesLeagueRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_league_rank");

                entity.HasIndex(e => e.LeagueRank, "heroes_league_rank_0_league_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.LeagueMaxValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_max_value");
                entity.Property(e => e.LeagueMinValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_min_value");
                entity.Property(e => e.LeagueRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_rank");
                entity.Property(e => e.LeagueRankType)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_rank_type");
                entity.Property(e => e.RacingBaseBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("racing_base_bgm_cue_name");
                entity.Property(e => e.RacingBaseBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("racing_base_bgm_cuesheet_name");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
                entity.Property(e => e.TicketNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket_num");
                entity.Property(e => e.TopBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("top_bgm_cue_name");
                entity.Property(e => e.TopBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("top_bgm_cuesheet_name");
            });

            modelBuilder.Entity<HeroesLeagueRankRewardGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_league_rank_reward_group");

                entity.HasIndex(e => e.RewardGroupId, "heroes_league_rank_reward_group_0_reward_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
            });

            modelBuilder.Entity<HeroesLeagueScore>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_league_score");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.LeagueRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_rank");
                entity.Property(e => e.LeagueScore)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_score");
                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");
            });

            modelBuilder.Entity<HeroesLotteryMessage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_lottery_message");

                entity.HasIndex(e => e.ViewType, "heroes_lottery_message_0_view_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_flag");
                entity.Property(e => e.ViewType)
                    .HasColumnType("int(11)")
                    .HasColumnName("view_type");
            });

            modelBuilder.Entity<HeroesRaceCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_race_condition");

                entity.HasIndex(e => e.HeroesId, "heroes_race_condition_0_heroes_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.HeroesId)
                    .HasColumnType("int(11)")
                    .HasColumnName("heroes_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.Stage)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<HeroesRaceDefaultNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_race_default_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardRarityDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_rarity_data_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DefaultNpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_npc_group_id");
                entity.Property(e => e.DefaultNpcTeamId)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_npc_team_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
                entity.Property(e => e.SkillLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<HeroesRaceDefaultUser>(entity =>
            {
                entity.HasKey(e => e.DefaultNpcTeamId).HasName("PRIMARY");

                entity.ToTable("heroes_race_default_user");

                entity.Property(e => e.DefaultNpcTeamId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("default_npc_team_id");
            });

            modelBuilder.Entity<HeroesRaceMobNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_race_mob_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.SkillSetId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id_1");
                entity.Property(e => e.SkillSetId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id_2");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<HeroesSkill>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_skill");

                entity.HasIndex(e => e.SkillId, "heroes_skill_0_skill_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.LeagueRankMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_rank_max");
                entity.Property(e => e.LeagueRankMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("league_rank_min");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
            });

            modelBuilder.Entity<HeroesSkillItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_skill_item");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
            });

            modelBuilder.Entity<HeroesSkillMotion>(entity =>
            {
                entity.HasKey(e => e.CharacterId).HasName("PRIMARY");

                entity.ToTable("heroes_skill_motion");

                entity.Property(e => e.CharacterId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.MotionSet1)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_set_1");
                entity.Property(e => e.MotionSet2)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_set_2");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.StayMotionSet1)
                    .HasColumnType("int(11)")
                    .HasColumnName("stay_motion_set_1");
                entity.Property(e => e.TimeMotionSet2)
                    .HasColumnType("int(11)")
                    .HasColumnName("time_motion_set_2");
            });

            modelBuilder.Entity<HeroesSpecialReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_special_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<HeroesStageSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("heroes_stage_schedule");

                entity.HasIndex(e => e.HeroesId, "heroes_stage_schedule_0_heroes_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.HeroesId)
                    .HasColumnType("int(11)")
                    .HasColumnName("heroes_id");
                entity.Property(e => e.RaceNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_num");
                entity.Property(e => e.Stage)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage");
                entity.Property(e => e.StageStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("stage_step");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<HighlightInterpolate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("highlight_interpolate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.InTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("in_time");
                entity.Property(e => e.OutTime)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("change_personality");
            });

            modelBuilder.Entity<HomeEat>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("home_eat");

                entity.HasIndex(e => e.CharaId, "home_eat_0_chara_id");

                entity.Property(e => e.BodyShape)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_shape");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.EatFacialMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eat_facial_motion");
                entity.Property(e => e.EatMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eat_motion");
                entity.Property(e => e.EventType)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_type");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.OverrideMotionLeft)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("override_motion_left");
                entity.Property(e => e.OverrideMotionRight)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("override_motion_right");
                entity.Property(e => e.PropEatAnimationLeft)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("prop_eat_animation_left");
                entity.Property(e => e.PropEatAnimationRight)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("prop_eat_animation_right");
                entity.Property(e => e.PropIdLeft)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id_left");
                entity.Property(e => e.PropIdRight)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id_right");
                entity.Property(e => e.WalkCharaFaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("walk_chara_face_type");
                entity.Property(e => e.WalkMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("walk_motion");
            });

            modelBuilder.Entity<HomeEnvSetting>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("home_env_setting");

                entity.HasIndex(e => new { e.HomeSetId, e.HomeEventType, e.Season, e.Weather, e.Timezone }, "home_env_setting_index").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.HomeEventType)
                    .HasColumnType("int(11)")
                    .HasColumnName("home_event_type");
                entity.Property(e => e.HomeSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("home_set_id");
                entity.Property(e => e.Resource)
                    .HasColumnType("int(11)")
                    .HasColumnName("resource");
                entity.Property(e => e.ResourceEventCheck)
                    .HasColumnType("int(11)")
                    .HasColumnName("resource_event_check");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.Timezone)
                    .HasColumnType("int(11)")
                    .HasColumnName("timezone");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<HomeEventSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("home_event_schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EventFooterPropId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_footer_propid");
                entity.Property(e => e.EventFooterType)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_footer_type");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.EventStoryType)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_story_type");
                entity.Property(e => e.EventWalkPropId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_walk_propid");
                entity.Property(e => e.EventWalkType)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_walk_type");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<HomePosterData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("home_poster_data");

                entity.HasIndex(e => e.Priority, "home_poster_data_0_priority");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DetailValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("detail_value");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.Height)
                    .HasColumnType("int(11)")
                    .HasColumnName("height");
                entity.Property(e => e.PosIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_index");
                entity.Property(e => e.PosiHorizontal)
                    .HasColumnType("int(11)")
                    .HasColumnName("posi_horizontal");
                entity.Property(e => e.PosiVertical)
                    .HasColumnType("int(11)")
                    .HasColumnName("posi_vertical");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("url");
                entity.Property(e => e.UrlValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("url_value");
                entity.Property(e => e.Width)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("attach_node");
                entity.Property(e => e.PropId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id");
            });

            modelBuilder.Entity<HomeStoryTrigger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("home_story_trigger");

                entity.HasIndex(e => new { e.GalleryCharaId, e.DispOrder }, "gallery_chara_id").IsUnique();

                entity.HasIndex(e => e.GalleryCharaId, "home_story_trigger_0_gallery_chara_id");

                entity.HasIndex(e => new { e.HomeEventType, e.StoryId }, "home_story_trigger_0_home_event_type_1_story_id");

                entity.HasIndex(e => e.PosId, "home_story_trigger_0_pos_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AvailableGalleryKey)
                    .HasColumnType("int(11)")
                    .HasColumnName("available_gallery_key");
                entity.Property(e => e.CharaId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_1");
                entity.Property(e => e.CharaId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_2");
                entity.Property(e => e.CharaId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_3");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.GalleryCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gallery_chara_id");
                entity.Property(e => e.HomeEventType)
                    .HasColumnType("int(11)")
                    .HasColumnName("home_event_type");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
                entity.Property(e => e.PosId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<HomeWalkGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("home_walk_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_1");
                entity.Property(e => e.CharaId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_2");
                entity.Property(e => e.CharaId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_3");
                entity.Property(e => e.EnableEat1)
                    .HasColumnType("int(11)")
                    .HasColumnName("enable_eat_1");
                entity.Property(e => e.EnableEat2)
                    .HasColumnType("int(11)")
                    .HasColumnName("enable_eat_2");
                entity.Property(e => e.EnableEat3)
                    .HasColumnType("int(11)")
                    .HasColumnName("enable_eat_3");
            });

            modelBuilder.Entity<HomeStoryHipOffset>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("homestory_hip_offset");

                entity.HasIndex(e => new { e.StoryId, e.CharaId }, "homestory_hip_offset_0_story_id_1_chara_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.HomeEventType)
                    .HasColumnType("int(11)")
                    .HasColumnName("home_event_type");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
                entity.Property(e => e.Offset)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<HonorData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("honor_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Category)
                    .HasColumnType("int(11)")
                    .HasColumnName("category");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.StepGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("step_group_id");
                entity.Property(e => e.StepOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("step_order");
            });

            modelBuilder.Entity<ItemData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("item_data");

                entity.HasIndex(e => e.GroupId, "item_data_0_group_id");

                entity.HasIndex(e => e.ItemCategory, "item_data_0_item_category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value_1");
                entity.Property(e => e.AddValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value_2");
                entity.Property(e => e.AddValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value_3");
                entity.Property(e => e.EffectTarget1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_target_1");
                entity.Property(e => e.EffectTarget2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_target_2");
                entity.Property(e => e.EffectType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type_1");
                entity.Property(e => e.EffectType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type_2");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EnableRequest)
                    .HasColumnType("int(11)")
                    .HasColumnName("enable_request");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_place_id");
                entity.Property(e => e.LimitNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_num");
                entity.Property(e => e.Rare)
                    .HasColumnType("int(11)")
                    .HasColumnName("rare");
                entity.Property(e => e.RequestReward)
                    .HasColumnType("int(11)")
                    .HasColumnName("request_reward");
                entity.Property(e => e.SellItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sell_item_id");
                entity.Property(e => e.SellPrice)
                    .HasColumnType("int(11)")
                    .HasColumnName("sell_price");
                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ItemExchange>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("item_exchange");

                entity.HasIndex(e => e.ItemExchangeTopId, "item_exchange_0_item_exchange_top_id");

                entity.HasIndex(e => e.PayItemId, "item_exchange_0_pay_item_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AdditionalPieceNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_piece_num");
                entity.Property(e => e.ChangeItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("change_item_category");
                entity.Property(e => e.ChangeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("change_item_id");
                entity.Property(e => e.ChangeItemLimitNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("change_item_limit_num");
                entity.Property(e => e.ChangeItemLimitType)
                    .HasColumnType("int(11)")
                    .HasColumnName("change_item_limit_type");
                entity.Property(e => e.ChangeItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("change_item_num");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_top_id");
                entity.Property(e => e.PayItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_item_category");
                entity.Property(e => e.PayItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_item_id");
                entity.Property(e => e.PayItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_item_num");
                entity.Property(e => e.PriceChangeGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("price_change_group_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ItemExchangeTop>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("item_exchange_top");

                entity.HasIndex(e => e.ItemTopCategory, "item_exchange_top_0_item_top_category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.IsAnnivShopTop)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_anniv_shop_top");
                entity.Property(e => e.ItemExchangeDispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_disp_order");
                entity.Property(e => e.ItemExchangeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_type");
                entity.Property(e => e.ItemTopCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_top_category");
                entity.Property(e => e.ShopEnterTrigger)
                    .HasColumnType("int(11)")
                    .HasColumnName("shop_enter_trigger");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("item_group");

                entity.HasIndex(e => e.GroupId, "item_group_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<ItemPlace>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("item_place");

                entity.HasIndex(e => new { e.Id, e.TransitionType, e.TransitionValue }, "id").IsUnique();

                entity.HasIndex(e => e.Id, "item_place_0_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TransitionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition_type");
                entity.Property(e => e.TransitionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition_value");
            });

            modelBuilder.Entity<JobsGenre>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jobs_genre");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MiniBgId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_bg_id_1");
                entity.Property(e => e.MiniBgId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_bg_id_2");
                entity.Property(e => e.MiniBgId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_bg_id_3");
            });

            modelBuilder.Entity<JobsPlace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jobs_place");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");
            });

            modelBuilder.Entity<JobsPointLimit>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jobs_point_limit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.JobsStoryEventPointLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("jobs_story_event_point_limit");
                entity.Property(e => e.JobsStoryEventRouletteCoinLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("jobs_story_event_roulette_coin_limit");
                entity.Property(e => e.JobsTrainingChallengeCoinLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("jobs_training_challenge_coin_limit");
            });

            modelBuilder.Entity<JobsRandomDropReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jobs_random_drop_reward");

                entity.HasIndex(e => e.GroupId, "jobs_random_drop_reward_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
            });

            modelBuilder.Entity<JobsReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jobs_reward");

                entity.HasIndex(e => e.PlaceId, "jobs_reward_0_place_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CampaignWalkingGaugeUp)
                    .HasColumnType("int(11)")
                    .HasColumnName("campaign_walking_gauge_up");
                entity.Property(e => e.FactorResearchGaugeUp)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_research_gauge_up");
                entity.Property(e => e.FanNumMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_num_min");
                entity.Property(e => e.FanNumOddsGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_num_odds_group_id");
                entity.Property(e => e.GenreId)
                    .HasColumnType("int(11)")
                    .HasColumnName("genre_id");
                entity.Property(e => e.LovePoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("love_point");
                entity.Property(e => e.MainReward1ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_1_item_category");
                entity.Property(e => e.MainReward1ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_1_item_disp_type");
                entity.Property(e => e.MainReward1ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_1_item_id");
                entity.Property(e => e.MainReward1ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_1_item_num");
                entity.Property(e => e.MainReward2ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_2_item_category");
                entity.Property(e => e.MainReward2ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_2_item_disp_type");
                entity.Property(e => e.MainReward2ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_2_item_id");
                entity.Property(e => e.MainReward2ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_2_item_num");
                entity.Property(e => e.MainReward3ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_3_item_category");
                entity.Property(e => e.MainReward3ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_3_item_disp_type");
                entity.Property(e => e.MainReward3ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_3_item_id");
                entity.Property(e => e.MainReward3ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_3_item_num");
                entity.Property(e => e.MainReward4ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_4_item_category");
                entity.Property(e => e.MainReward4ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_4_item_disp_type");
                entity.Property(e => e.MainReward4ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_4_item_id");
                entity.Property(e => e.MainReward4ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_4_item_num");
                entity.Property(e => e.MainReward5ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_5_item_category");
                entity.Property(e => e.MainReward5ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_5_item_disp_type");
                entity.Property(e => e.MainReward5ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_5_item_id");
                entity.Property(e => e.MainReward5ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_5_item_num");
                entity.Property(e => e.MainReward6ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_6_item_category");
                entity.Property(e => e.MainReward6ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_6_item_disp_type");
                entity.Property(e => e.MainReward6ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_6_item_id");
                entity.Property(e => e.MainReward6ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_6_item_num");
                entity.Property(e => e.MainReward7ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_7_item_category");
                entity.Property(e => e.MainReward7ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_7_item_disp_type");
                entity.Property(e => e.MainReward7ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_7_item_id");
                entity.Property(e => e.MainReward7ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_7_item_num");
                entity.Property(e => e.MainReward8ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_8_item_category");
                entity.Property(e => e.MainReward8ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_8_item_disp_type");
                entity.Property(e => e.MainReward8ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_8_item_id");
                entity.Property(e => e.MainReward8ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_8_item_num");
                entity.Property(e => e.MainReward9ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_9_item_category");
                entity.Property(e => e.MainReward9ItemDispType)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_9_item_disp_type");
                entity.Property(e => e.MainReward9ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_9_item_id");
                entity.Property(e => e.MainReward9ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_9_item_num");
                entity.Property(e => e.MainRewardSlotsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_reward_slots_id");
                entity.Property(e => e.MinutesToJobComplete)
                    .HasColumnType("int(11)")
                    .HasColumnName("minutes_to_job_complete");
                entity.Property(e => e.MoneyMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("money_min");
                entity.Property(e => e.MoneyRewardItemOddsGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("money_reward_item_odds_group_id");
                entity.Property(e => e.PlaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("place_id");
                entity.Property(e => e.RandomDropRewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("random_drop_reward_group_id");
                entity.Property(e => e.StoryEventEventPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_event_pt");
                entity.Property(e => e.StoryEventRouletteCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_roulette_coin");
                entity.Property(e => e.SupportPointMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_point_min");
                entity.Property(e => e.SupportPointRewardItemOddsGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_point_reward_item_odds_group_id");
                entity.Property(e => e.TrainerMedal)
                    .HasColumnType("int(11)")
                    .HasColumnName("trainer_medal");
                entity.Property(e => e.TrainingChallengeRewardCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_challenge_reward_coin");
                entity.Property(e => e.TrainingReportPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_report_pt");
            });

            modelBuilder.Entity<JobsRewardSortDispOrder>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jobs_reward_sort_disp_order");

                entity.HasIndex(e => new { e.ItemCategory, e.ItemId }, "jobs_reward_sort_disp_order_0_item_category_1_item_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
            });

            modelBuilder.Entity<JukeboxComment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jukebox_comment");

                entity.HasIndex(e => new { e.CharaId, e.CommentType }, "jukebox_comment_0_chara_id_1_comment_type");

                entity.HasIndex(e => e.CommentId, "jukebox_comment_0_comment_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CommentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("comment_id");
                entity.Property(e => e.CommentType)
                    .HasColumnType("int(11)")
                    .HasColumnName("comment_type");
                entity.Property(e => e.VariationType)
                    .HasColumnType("int(11)")
                    .HasColumnName("variation_type");
                entity.Property(e => e.VariationValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("variation_value");
            });

            modelBuilder.Entity<JukeboxMotionData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jukebox_motion_data");

                entity.HasIndex(e => e.SongType, "jukebox_motion_data_0_song_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id");
                entity.Property(e => e.SongType)
                    .HasColumnType("int(11)")
                    .HasColumnName("song_type");
            });

            modelBuilder.Entity<JukeboxMusicData>(entity =>
            {
                entity.HasKey(e => e.MusicId).HasName("PRIMARY");

                entity.ToTable("jukebox_music_data");

                entity.HasIndex(e => e.VersionType, "jukebox_music_data_0_version_type");

                entity.HasIndex(e => e.Sort, "sort").IsUnique();

                entity.Property(e => e.MusicId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.AlterJacket)
                    .HasColumnType("int(11)")
                    .HasColumnName("alter_jacket");
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
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.IsHidden)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_hidden");
                entity.Property(e => e.LampAnimation)
                    .HasColumnType("int(11)")
                    .HasColumnName("lamp_animation");
                entity.Property(e => e.LampColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("lamp_color");
                entity.Property(e => e.NameTextureLength)
                    .HasColumnType("int(11)")
                    .HasColumnName("name_texture_length");
                entity.Property(e => e.RequestType)
                    .HasColumnType("int(11)")
                    .HasColumnName("request_type");
                entity.Property(e => e.ShortLength)
                    .HasColumnType("int(11)")
                    .HasColumnName("short_length");
                entity.Property(e => e.SongType)
                    .HasColumnType("int(11)")
                    .HasColumnName("song_type");
                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.VersionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("version_type");
            });

            modelBuilder.Entity<JukeboxSetlistData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jukebox_setlist_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<JukeboxSetlistMusicData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jukebox_setlist_music_data");

                entity.HasIndex(e => e.SetlistId, "jukebox_setlist_music_data_0_setlist_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.PlayLength)
                    .HasColumnType("int(11)")
                    .HasColumnName("play_length");
                entity.Property(e => e.SetOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("set_order");
                entity.Property(e => e.SetlistId)
                    .HasColumnType("int(11)")
                    .HasColumnName("setlist_id");
            });

            modelBuilder.Entity<JukeboxSetlistSingerData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("jukebox_setlist_singer_data");

                entity.HasIndex(e => e.SetlistMusicId, "jukebox_setlist_singer_data_0_setlist_music_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Performer)
                    .HasColumnType("int(11)")
                    .HasColumnName("performer");
                entity.Property(e => e.SetlistMusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("setlist_music_id");
            });

            modelBuilder.Entity<LegendRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("legend_race");

                entity.HasIndex(e => e.GroupId, "legend_race_0_group_id");

                entity.HasIndex(e => e.RaceInstanceId, "legend_race_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CostNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_num");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.DropRewardOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("drop_reward_odds_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_1");
                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_2");
                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_3");
                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_1");
                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_2");
                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_3");
                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_1");
                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_2");
                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_3");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.HasUniqueBgEnv)
                    .HasColumnType("int(11)")
                    .HasColumnName("has_unique_bg_env");
                entity.Property(e => e.ImageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("image_id");
                entity.Property(e => e.LegendBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_bg_id");
                entity.Property(e => e.LegendBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_bg_sub_id");
                entity.Property(e => e.LegendRaceBossNpcId)
                    .HasColumnType("int(11)")
                    .HasColumnName("legend_race_boss_npc_id");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.PickUpItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_1");
                entity.Property(e => e.PickUpItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_2");
                entity.Property(e => e.PickUpItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_category_3");
                entity.Property(e => e.PickUpItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_1");
                entity.Property(e => e.PickUpItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_2");
                entity.Property(e => e.PickUpItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_id_3");
                entity.Property(e => e.PickUpItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_1");
                entity.Property(e => e.PickUpItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_2");
                entity.Property(e => e.PickUpItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("pick_up_item_num_3");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.VictoryRewardOddsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("victory_reward_odds_id");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<LegendRaceBilling>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("legend_race_billing");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Frequency)
                    .HasColumnType("int(11)")
                    .HasColumnName("frequency");
                entity.Property(e => e.PayCost)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_cost");
            });

            modelBuilder.Entity<LegendRaceBossNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("legend_race_boss_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardRarityDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_rarity_data_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.NicknameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("nickname_id");
                entity.Property(e => e.Post)
                    .HasColumnType("int(11)")
                    .HasColumnName("post");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<LegendRaceCuttCharaData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("legend_race_cutt_chara_data");

                entity.HasIndex(e => new { e.SubId, e.CharaNum }, "legend_race_cutt_chara_data_0_sub_id_1_chara_num");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CharaNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_num");
                entity.Property(e => e.SubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_id");
                entity.Property(e => e.TargetListIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_list_index");
                entity.Property(e => e.TargetTimeline)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_timeline");
            });

            modelBuilder.Entity<LegendRaceNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("legend_race_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<LiveData>(entity =>
            {
                entity.HasKey(e => e.MusicId).HasName("PRIMARY");

                entity.ToTable("live_data");

                entity.HasIndex(e => e.Sort, "sort").IsUnique();

                entity.Property(e => e.MusicId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.BackdancerDress)
                    .HasColumnType("int(11)")
                    .HasColumnName("backdancer_dress");
                entity.Property(e => e.BackdancerDressColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("backdancer_dress_color");
                entity.Property(e => e.BackdancerOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("backdancer_order");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.DefaultMainDress)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_main_dress");
                entity.Property(e => e.DefaultMainDressColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_main_dress_color");
                entity.Property(e => e.DefaultMobDress)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_mob_dress");
                entity.Property(e => e.DefaultMobDressColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_mob_dress_color");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.HasLive)
                    .HasColumnType("int(11)")
                    .HasColumnName("has_live");
                entity.Property(e => e.LiveMemberNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("live_member_number");
                entity.Property(e => e.MusicType)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_type");
                entity.Property(e => e.SongCharaType)
                    .HasColumnType("int(11)")
                    .HasColumnName("song_chara_type");
                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TitleColorBottom)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("title_color_bottom");
                entity.Property(e => e.TitleColorTop)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("title_color_top");
            });

            modelBuilder.Entity<LiveExtraData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("live_extra_data");

                entity.HasIndex(e => e.MusicId, "live_extra_data_0_music_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.NextMusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("next_music_id");
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

            modelBuilder.Entity<LoginBonusChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("login_bonus_chara");

                entity.HasIndex(e => e.LoginBonusDetailId, "login_bonus_chara_0_login_bonus_detail_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CharaId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id_2");
                entity.Property(e => e.CharaNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_num");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.DressId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id_2");
                entity.Property(e => e.LoginBonusDetailId)
                    .HasColumnType("int(11)")
                    .HasColumnName("login_bonus_detail_id");
                entity.Property(e => e.PoseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("pose_id");
                entity.Property(e => e.PoseId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("pose_id_2");
            });

            modelBuilder.Entity<LoginBonusData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("login_bonus_data");

                entity.HasIndex(e => e.GroupId, "login_bonus_data_0_group_id");

                entity.HasIndex(e => e.Type, "login_bonus_data_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AnimeFileId)
                    .HasColumnType("int(11)")
                    .HasColumnName("anime_file_id");
                entity.Property(e => e.AnimeFileLabel)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("anime_file_label");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.CountNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("count_num");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.GiftMessageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gift_message_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.NewStartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("new_start_date");
                entity.Property(e => e.StampId)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamp_id");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.Step)
                    .HasColumnType("int(11)")
                    .HasColumnName("step");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<LoginBonusDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("login_bonus_detail");

                entity.HasIndex(e => e.LoginBonusId, "login_bonus_detail_0_login_bonus_id");

                entity.HasIndex(e => new { e.LoginBonusId, e.Count }, "login_bonus_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Count)
                    .HasColumnType("int(11)")
                    .HasColumnName("count");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_3");
                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_4");
                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_5");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_3");
                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_4");
                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_5");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
                entity.Property(e => e.ItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_3");
                entity.Property(e => e.ItemNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_4");
                entity.Property(e => e.ItemNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_5");
                entity.Property(e => e.LoginBonusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("login_bonus_id");
            });

            modelBuilder.Entity<LoveRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("love_rank");

                entity.HasIndex(e => e.Rank, "love_rank_0_rank").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank");
                entity.Property(e => e.TotalPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_point");
            });

            modelBuilder.Entity<MainStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("main_story_data");

                entity.HasIndex(e => e.PartId, "main_story_data_0_part_id");

                entity.HasIndex(e => e.StoryId1, "story_id_1").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_category_1");
                entity.Property(e => e.AddRewardCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_category_2");
                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_id_1");
                entity.Property(e => e.AddRewardId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_id_2");
                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_num_1");
                entity.Property(e => e.AddRewardNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_num_2");
                entity.Property(e => e.DisplayType)
                    .HasColumnType("int(11)")
                    .HasColumnName("display_type");
                entity.Property(e => e.EpisodeIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index");
                entity.Property(e => e.LockReferenceEpisodeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_reference_episode_id");
                entity.Property(e => e.LockType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_type_1");
                entity.Property(e => e.LockType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_type_2");
                entity.Property(e => e.LockType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_type_3");
                entity.Property(e => e.LockValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_1_1");
                entity.Property(e => e.LockValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_1_2");
                entity.Property(e => e.LockValue21)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_2_1");
                entity.Property(e => e.LockValue22)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_2_2");
                entity.Property(e => e.LockValue31)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_3_1");
                entity.Property(e => e.LockValue32)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value_3_2");
                entity.Property(e => e.NextEpisodeIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("next_episode_index");
                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("part_id");
                entity.Property(e => e.PrevEpisodeIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("prev_episode_index");
                entity.Property(e => e.StoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_1");
                entity.Property(e => e.StoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_2");
                entity.Property(e => e.StoryId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_3");
                entity.Property(e => e.StoryId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_4");
                entity.Property(e => e.StoryId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_5");
                entity.Property(e => e.StoryNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_number");
                entity.Property(e => e.StoryType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_1");
                entity.Property(e => e.StoryType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_2");
                entity.Property(e => e.StoryType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_3");
                entity.Property(e => e.StoryType4)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_4");
                entity.Property(e => e.StoryType5)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_5");
            });

            modelBuilder.Entity<MainStoryPart>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("main_story_part");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.IsLastPart)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_last_part");
                entity.Property(e => e.MainStoryLastChapter)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_story_last_chapter");
                entity.Property(e => e.PartIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("part_index");
                entity.Property(e => e.SectionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("section_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.UiColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color");
            });

            modelBuilder.Entity<MainStoryRaceBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("main_story_race_bonus");

                entity.HasIndex(e => e.GroupId, "main_story_race_bonus_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusType)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_type");
                entity.Property(e => e.BonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value");
                entity.Property(e => e.ConditionGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_group");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<MainStoryRaceBonusCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("main_story_race_bonus_condition");

                entity.HasIndex(e => e.GroupId, "main_story_race_bonus_condition_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<MainStoryRaceCharaData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("main_story_race_chara_data");

                entity.HasIndex(e => e.GroupId, "main_story_race_chara_data_0_group_id");

                entity.HasIndex(e => e.RunningStyle, "main_story_race_chara_data_0_running_style");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BracketNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("bracket_number");
                entity.Property(e => e.CharaColorType)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_color_type");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.IsPlayer)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_player");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.Motivation)
                    .HasColumnType("int(11)")
                    .HasColumnName("motivation");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RunningStyle)
                    .HasColumnType("int(11)")
                    .HasColumnName("running_style");
                entity.Property(e => e.ShowSkillType)
                    .HasColumnType("int(11)")
                    .HasColumnName("show_skill_type");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<MainStoryRaceData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("main_story_race_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusChara1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_chara_1");
                entity.Property(e => e.BonusChara2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_chara_2");
                entity.Property(e => e.BonusChara3)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_chara_3");
                entity.Property(e => e.BonusGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_group_id");
                entity.Property(e => e.ClearRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("clear_rank");
                entity.Property(e => e.GimmickMatchRaceAsset)
                    .HasColumnType("int(11)")
                    .HasColumnName("gimmick_match_race_asset");
                entity.Property(e => e.GimmickTriggerSkill)
                    .HasColumnType("int(11)")
                    .HasColumnName("gimmick_trigger_skill");
                entity.Property(e => e.GimmickType)
                    .HasColumnType("int(11)")
                    .HasColumnName("gimmick_type");
                entity.Property(e => e.GimmickUnmatchRaceAsset)
                    .HasColumnType("int(11)")
                    .HasColumnName("gimmick_unmatch_race_asset");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.RaceConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_condition_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<MapEventAreaData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("map_event_area_data");

                entity.HasIndex(e => e.EventId, "map_event_area_data_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("area_id");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<MapEventData>(entity =>
            {
                entity.HasKey(e => e.EventId).HasName("PRIMARY");

                entity.ToTable("map_event_data");

                entity.Property(e => e.EventId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.GaugeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_max");
                entity.Property(e => e.GaugeUpLogin)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_login");
                entity.Property(e => e.GaugeUpSinglemode)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_singlemode");
                entity.Property(e => e.GaugeUpTeamstadium)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up_teamstadium");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<MapEventFlavorText>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("map_event_flavor_text");

                entity.HasIndex(e => e.EventId, "map_event_flavor_text_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.ImageType)
                    .HasColumnType("int(11)")
                    .HasColumnName("image_type");
                entity.Property(e => e.StoryConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_condition_type");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<MapEventMapPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("map_event_map_point");

                entity.HasIndex(e => e.EventId, "map_event_map_point_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("area_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CheckPointFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("check_point_flag");
                entity.Property(e => e.DispFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_flag");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.GaugeNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_num");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.MapPointId)
                    .HasColumnType("int(11)")
                    .HasColumnName("map_point_id");
                entity.Property(e => e.MotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id");
                entity.Property(e => e.MovieStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("movie_start_date");
                entity.Property(e => e.NextEpisodeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("next_episode_id");
                entity.Property(e => e.NextEpisodeUnlockMapPointId)
                    .HasColumnType("int(11)")
                    .HasColumnName("next_episode_unlock_map_point_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_1");
                entity.Property(e => e.StoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_2");
            });

            modelBuilder.Entity<MapEventMiniMotion>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("map_event_mini_motion");

                entity.HasIndex(e => e.EventId, "map_event_mini_motion_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ArriveMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("arrive_motion");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CheckpointMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("checkpoint_motion");
                entity.Property(e => e.CompleteMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("complete_motion");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.StandMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("stand_motion");
                entity.Property(e => e.TapMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("tap_motion");
                entity.Property(e => e.WalkMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("walk_motion");
            });

            modelBuilder.Entity<MapEventStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("map_event_story_data");

                entity.HasIndex(e => e.EventId, "map_event_story_data_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index_id");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.PointConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("point_condition_type");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_condition_type");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<MetaA>(entity =>
            {
                entity.HasKey(e => e.I).HasName("PRIMARY");

                entity.ToTable("meta_a");

                entity.HasIndex(e => e.S, "a1");

                entity.HasIndex(e => new { e.G, e.S }, "a3");

                entity.HasIndex(e => e.P, "a4");

                entity.Property(e => e.I)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("i");
                entity.Property(e => e.C)
                    .HasColumnType("int(8)")
                    .HasColumnName("c");
                entity.Property(e => e.D)
                    .HasColumnType("text")
                    .HasColumnName("d");
                entity.Property(e => e.G)
                    .HasColumnType("int(4)")
                    .HasColumnName("g");
                entity.Property(e => e.H)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("h");
                entity.Property(e => e.K)
                    .HasColumnType("int(1)")
                    .HasColumnName("k");
                entity.Property(e => e.L)
                    .HasColumnType("int(8)")
                    .HasColumnName("l");
                entity.Property(e => e.M)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("m");
                entity.Property(e => e.N)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("n");
                entity.Property(e => e.P)
                    .HasColumnType("int(4)")
                    .HasColumnName("p");
                entity.Property(e => e.S)
                    .HasColumnType("int(1)")
                    .HasColumnName("s");
            });

            modelBuilder.Entity<MetaC>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("meta_c");

                entity.HasIndex(e => e.N, "n").IsUnique();

                entity.Property(e => e.H)
                    .HasColumnType("text")
                    .HasColumnName("h");
                entity.Property(e => e.N)
                    .HasColumnType("text")
                    .HasColumnName("n");
            });

            modelBuilder.Entity<MetaI>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("meta_i");

                entity.HasIndex(e => e.K, "k").IsUnique();

                entity.Property(e => e.K)
                    .HasColumnType("text")
                    .HasColumnName("k");
                entity.Property(e => e.V)
                    .HasColumnType("text")
                    .HasColumnName("v");
            });

            modelBuilder.Entity<MetaR>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("meta_r");

                entity.HasIndex(e => new { e.F, e.T }, "r0").IsUnique();

                entity.HasIndex(e => e.D, "r1");

                entity.Property(e => e.D)
                    .HasColumnType("int(2)")
                    .HasColumnName("d");
                entity.Property(e => e.F)
                    .HasColumnType("int(4)")
                    .HasColumnName("f");
                entity.Property(e => e.T)
                    .HasColumnType("int(4)")
                    .HasColumnName("t");
            });

            modelBuilder.Entity<MiniBg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mini_bg");

                entity.HasIndex(e => e.SceneType, "mini_bg_0_scene_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.GridOffsetX)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("grid_offset_x");
                entity.Property(e => e.GridOffsetY)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("grid_offset_y");
                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("position");
                entity.Property(e => e.ReleaseNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("release_num");
                entity.Property(e => e.SceneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("scene_type");
                entity.Property(e => e.SizeX)
                    .HasColumnType("int(11)")
                    .HasColumnName("size_x");
                entity.Property(e => e.SizeY)
                    .HasColumnType("int(11)")
                    .HasColumnName("size_y");
            });

            modelBuilder.Entity<MiniBgCharaMotion>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mini_bg_chara_motion");

                entity.HasIndex(e => e.BgId, "mini_bg_chara_motion_0_bg_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.CharaPosY)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chara_pos_y");
                entity.Property(e => e.CharaShadow)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_shadow");
                entity.Property(e => e.Direction)
                    .HasColumnType("int(11)")
                    .HasColumnName("direction");
                entity.Property(e => e.EffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_id");
                entity.Property(e => e.EffectStartSec)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("effect_start_sec");
                entity.Property(e => e.FixedRenderOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("fixed_render_order");
                entity.Property(e => e.GridPosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("grid_pos_x");
                entity.Property(e => e.GridPosY)
                    .HasColumnType("int(11)")
                    .HasColumnName("grid_pos_y");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.IsMob)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_mob");
                entity.Property(e => e.MainCharaNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_chara_num");
                entity.Property(e => e.MotionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("motion_name");
                entity.Property(e => e.PosObj)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("pos_obj");
                entity.Property(e => e.PositionAnim)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("position_anim");
                entity.Property(e => e.PositionFile)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("position_file");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.SeCueName01)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name01");
                entity.Property(e => e.SeCueName02)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name02");
                entity.Property(e => e.SeCueSheet01)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_sheet01");
                entity.Property(e => e.SeCueSheet02)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_sheet02");
                entity.Property(e => e.SeStartFrame01)
                    .HasColumnType("int(11)")
                    .HasColumnName("se_start_frame01");
                entity.Property(e => e.SeStartFrame02)
                    .HasColumnType("int(11)")
                    .HasColumnName("se_start_frame02");
                entity.Property(e => e.SecondPosObj)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("second_pos_obj");
                entity.Property(e => e.SubGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_group_id");
                entity.Property(e => e.Timeline)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("timeline");
                entity.Property(e => e.TimelineActor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("timeline_actor");
                entity.Property(e => e.UseGridPosJobSelect)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_grid_pos_job_select");
            });

            modelBuilder.Entity<MiniFaceTypeData>(entity =>
            {
                entity.HasKey(e => e.Label).HasName("PRIMARY");

                entity.ToTable("mini_face_type_data");

                entity.Property(e => e.Label)
                    .HasMaxLength(300)
                    .HasColumnName("label");
                entity.Property(e => e.Cheek)
                    .HasColumnType("int(11)")
                    .HasColumnName("cheek");
                entity.Property(e => e.EyeL)
                    .HasColumnType("int(11)")
                    .HasColumnName("eye_l");
                entity.Property(e => e.EyeR)
                    .HasColumnType("int(11)")
                    .HasColumnName("eye_r");
                entity.Property(e => e.EyebrowL)
                    .HasColumnType("int(11)")
                    .HasColumnName("eyebrow_l");
                entity.Property(e => e.EyebrowR)
                    .HasColumnType("int(11)")
                    .HasColumnName("eyebrow_r");
                entity.Property(e => e.Mouth)
                    .HasColumnType("int(11)")
                    .HasColumnName("mouth");
            });

            modelBuilder.Entity<MiniMob>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mini_mob");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Body)
                    .HasColumnType("int(11)")
                    .HasColumnName("body");
                entity.Property(e => e.Hair)
                    .HasColumnType("int(11)")
                    .HasColumnName("hair");
                entity.Property(e => e.Tail)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<MiniMotionSet>(entity =>
            {
                entity.HasKey(e => e.Label).HasName("PRIMARY");

                entity.ToTable("mini_motion_set");

                entity.HasIndex(e => e.Id, "mini_motion_set_0_id");

                entity.Property(e => e.Label)
                    .HasMaxLength(300)
                    .HasColumnName("label");
                entity.Property(e => e.AddLayerIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_layer_index");
                entity.Property(e => e.BodyMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("body_motion");
                entity.Property(e => e.BodyMotionPlayType)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_motion_play_type");
                entity.Property(e => e.BodyMotionSceneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_motion_scene_type");
                entity.Property(e => e.BodyMotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("body_motion_type");
                entity.Property(e => e.CharaFaceType)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chara_face_type");
                entity.Property(e => e.CharaTypeTarget)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_type_target");
                entity.Property(e => e.EarMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ear_motion");
                entity.Property(e => e.FacialMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("facial_motion");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.IsEnableRandomeEar)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_enable_randome_ear");
                entity.Property(e => e.IsEnableRandomeTail)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_enable_randome_tail");
                entity.Property(e => e.IsMirror)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_mirror");
                entity.Property(e => e.IsPropRequireMotionEnd)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_prop_require_motion_end");
                entity.Property(e => e.PropAttachNodeNameType)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_attach_node_name_type");
                entity.Property(e => e.PropAttachNodeNameType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_attach_node_name_type_2");
                entity.Property(e => e.PropId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id");
                entity.Property(e => e.PropId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_id_2");
                entity.Property(e => e.PropMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("prop_motion");
                entity.Property(e => e.PropMotion2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("prop_motion_2");
                entity.Property(e => e.PropMotionSceneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_motion_scene_type");
                entity.Property(e => e.PropMotionSceneType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_motion_scene_type_2");
                entity.Property(e => e.SceneSubFolder)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("scene_sub_folder");
                entity.Property(e => e.TailMotion)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_motion");
                entity.Property(e => e.TailMotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_motion_type");
                entity.Property(e => e.TransitionTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition_time");
                entity.Property(e => e.UseTailInBodyMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_tail_in_body_motion");
            });

            modelBuilder.Entity<MiniMouthType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mini_mouth_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ReverseMouthId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reverse_mouth_id");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<MissionData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mission_data");

                entity.HasIndex(e => e.MissionType, "mission_data_0_mission_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_num");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
                entity.Property(e => e.ConditionValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_4");
                entity.Property(e => e.DateCheckFlg)
                    .HasColumnType("int(11)")
                    .HasColumnName("date_check_flg");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.MissionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mission_type");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.StepGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("step_group_id");
                entity.Property(e => e.StepOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("step_order");
                entity.Property(e => e.TransitionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition_type");
                entity.Property(e => e.UserShow)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_show");
            });

            modelBuilder.Entity<MissionRaceEquate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mission_race_equate");

                entity.HasIndex(e => e.InputId, "mission_race_equate_0_input_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EquateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("equate_id");
                entity.Property(e => e.InputId)
                    .HasColumnType("int(11)")
                    .HasColumnName("input_id");
            });

            modelBuilder.Entity<MissionRaceScenarioGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mission_race_scenario_group");

                entity.HasIndex(e => e.RaceInstanceId, "mission_race_scenario_group_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<MobData>(entity =>
            {
                entity.HasKey(e => e.MobId).HasName("PRIMARY");

                entity.ToTable("mob_data");

                entity.Property(e => e.MobId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.AttachmentModelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("attachment_model_id");
                entity.Property(e => e.CaptureType)
                    .HasColumnType("int(11)")
                    .HasColumnName("capture_type");
                entity.Property(e => e.CharaBustSize)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_bust_size");
                entity.Property(e => e.CharaFaceModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_face_model");
                entity.Property(e => e.CharaHairColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_hair_color");
                entity.Property(e => e.CharaHairModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_hair_model");
                entity.Property(e => e.CharaHeight)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_height");
                entity.Property(e => e.CharaSkinColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_skin_color");
                entity.Property(e => e.DefaultPersonality)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_personality");
                entity.Property(e => e.DressColorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_color_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.HairCutoff)
                    .HasColumnType("int(11)")
                    .HasColumnName("hair_cutoff");
                entity.Property(e => e.MayuVisibleType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mayu_visible_type");
                entity.Property(e => e.RacePersonality)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_personality");
                entity.Property(e => e.RaceRunningType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_running_type");
                entity.Property(e => e.Sex)
                    .HasColumnType("int(11)")
                    .HasColumnName("sex");
                entity.Property(e => e.Socks)
                    .HasColumnType("int(11)")
                    .HasColumnName("socks");
                entity.Property(e => e.UseLive)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_live");
            });

            modelBuilder.Entity<MobDressColorSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mob_dress_color_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b1");
                entity.Property(e => e.ColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_b2");
                entity.Property(e => e.ColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g1");
                entity.Property(e => e.ColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_g2");
                entity.Property(e => e.ColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r1");
                entity.Property(e => e.ColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("color_r2");
                entity.Property(e => e.ToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b1");
                entity.Property(e => e.ToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_b2");
                entity.Property(e => e.ToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g1");
                entity.Property(e => e.ToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_g2");
                entity.Property(e => e.ToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r1");
                entity.Property(e => e.ToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("toon_color_r2");
            });

            modelBuilder.Entity<MobHairColorSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("mob_hair_color_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EyeColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_b1");
                entity.Property(e => e.EyeColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_b2");
                entity.Property(e => e.EyeColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_g1");
                entity.Property(e => e.EyeColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_g2");
                entity.Property(e => e.EyeColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_r1");
                entity.Property(e => e.EyeColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("eye_color_r2");
                entity.Property(e => e.HairColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_b1");
                entity.Property(e => e.HairColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_b2");
                entity.Property(e => e.HairColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_g1");
                entity.Property(e => e.HairColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_g2");
                entity.Property(e => e.HairColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_r1");
                entity.Property(e => e.HairColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_color_r2");
                entity.Property(e => e.HairToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_b1");
                entity.Property(e => e.HairToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_b2");
                entity.Property(e => e.HairToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_g1");
                entity.Property(e => e.HairToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_g2");
                entity.Property(e => e.HairToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_r1");
                entity.Property(e => e.HairToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("hair_toon_color_r2");
                entity.Property(e => e.MayuColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_b1");
                entity.Property(e => e.MayuColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_b2");
                entity.Property(e => e.MayuColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_g1");
                entity.Property(e => e.MayuColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_g2");
                entity.Property(e => e.MayuColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_r1");
                entity.Property(e => e.MayuColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_color_r2");
                entity.Property(e => e.MayuToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_b1");
                entity.Property(e => e.MayuToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_b2");
                entity.Property(e => e.MayuToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_g1");
                entity.Property(e => e.MayuToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_g2");
                entity.Property(e => e.MayuToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_r1");
                entity.Property(e => e.MayuToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mayu_toon_color_r2");
                entity.Property(e => e.TailColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_b1");
                entity.Property(e => e.TailColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_b2");
                entity.Property(e => e.TailColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_g1");
                entity.Property(e => e.TailColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_g2");
                entity.Property(e => e.TailColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_r1");
                entity.Property(e => e.TailColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_color_r2");
                entity.Property(e => e.TailToonColorB1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_b1");
                entity.Property(e => e.TailToonColorB2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_b2");
                entity.Property(e => e.TailToonColorG1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_g1");
                entity.Property(e => e.TailToonColorG2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_g2");
                entity.Property(e => e.TailToonColorR1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_r1");
                entity.Property(e => e.TailToonColorR2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tail_toon_color_r2");
            });

            modelBuilder.Entity<NameCardBg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("name_card_bg");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_group");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSub)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub");
                entity.Property(e => e.Height)
                    .HasColumnType("int(11)")
                    .HasColumnName("height");
                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");
                entity.Property(e => e.OtherGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("other_group");
                entity.Property(e => e.PosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_x");
                entity.Property(e => e.PosY)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_y");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TimeGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("time_group");
                entity.Property(e => e.Width)
                    .HasColumnType("int(11)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<NeedPieceNumData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("need_piece_num_data");

                entity.HasIndex(e => e.Rarity, "need_piece_num_data_0_rarity").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.PieceNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("piece_num");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
            });

            modelBuilder.Entity<Nickname>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("nickname");

                entity.HasIndex(e => e.UserShow, "nickname_0_user_show");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_data_id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank");
                entity.Property(e => e.ReceiveConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("receive_condition_type");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
                entity.Property(e => e.UserShow)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_show");
            });

            modelBuilder.Entity<NoteProfile>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("note_profile");

                entity.HasIndex(e => e.CharaId, "note_profile_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.LockType)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_type");
                entity.Property(e => e.LockValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("lock_value");
                entity.Property(e => e.SecretFlg)
                    .HasColumnType("int(11)")
                    .HasColumnName("secret_flg");
                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort");
                entity.Property(e => e.TextType)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_type");
            });

            modelBuilder.Entity<NoteProfileTextType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("note_profile_text_type");

                entity.HasIndex(e => e.TextType, "note_profile_text_type_0_text_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort");
                entity.Property(e => e.TextCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_category_id");
                entity.Property(e => e.TextType)
                    .HasColumnType("int(11)")
                    .HasColumnName("text_type");
            });

            modelBuilder.Entity<PaidGachaButtonType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("paid_gacha_button_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DrawGuaranteeRarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_guarantee_rarity");
                entity.Property(e => e.GachaCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_count");
                entity.Property(e => e.PaidNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("paid_num");
            });

            modelBuilder.Entity<PieceData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("piece_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_place_id");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<PriceChange>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("price_change");

                entity.HasIndex(e => e.GroupId, "price_change_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.MaxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_num");
                entity.Property(e => e.MinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_num");
                entity.Property(e => e.PayItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("pay_item_num");
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race");

                entity.HasIndex(e => e.CourseSet, "race_0_course_set");

                entity.HasIndex(e => e.Group, "race_0_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Audience)
                    .HasColumnType("int(11)")
                    .HasColumnName("audience");
                entity.Property(e => e.AudienceGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audience_group_id");
                entity.Property(e => e.ChangeFullGate)
                    .HasColumnType("int(11)")
                    .HasColumnName("change_full_gate");
                entity.Property(e => e.CourseSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("course_set");
                entity.Property(e => e.EntryNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("entry_num");
                entity.Property(e => e.FfAnim)
                    .HasColumnType("int(11)")
                    .HasColumnName("ff_anim");
                entity.Property(e => e.FfCamera)
                    .HasColumnType("int(11)")
                    .HasColumnName("ff_camera");
                entity.Property(e => e.FfCameraSub)
                    .HasColumnType("int(11)")
                    .HasColumnName("ff_camera_sub");
                entity.Property(e => e.FfCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ff_cue_name");
                entity.Property(e => e.FfCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ff_cuesheet_name");
                entity.Property(e => e.FfSub)
                    .HasColumnType("int(11)")
                    .HasColumnName("ff_sub");
                entity.Property(e => e.GoalFlower)
                    .HasColumnType("int(11)")
                    .HasColumnName("goal_flower");
                entity.Property(e => e.GoalGate)
                    .HasColumnType("int(11)")
                    .HasColumnName("goal_gate");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
                entity.Property(e => e.Group)
                    .HasColumnType("int(11)")
                    .HasColumnName("group");
                entity.Property(e => e.IsDirtGrade)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_dirtgrade");
                entity.Property(e => e.PaddockBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("paddock_bg_id");
                entity.Property(e => e.RealFfCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("real_ff_cue_name");
                entity.Property(e => e.RealFfCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("real_ff_cuesheet_name");
                entity.Property(e => e.ResultPodium)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_podium");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StartGate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_gate");
                entity.Property(e => e.StartGatePanel)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_gate_panel");
                entity.Property(e => e.ThumbnailId)
                    .HasColumnType("int(11)")
                    .HasColumnName("thumbnail_id");
            });

            modelBuilder.Entity<RaceBgm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_bgm");

                entity.HasIndex(e => e.RaceType, "race_bgm_0_race_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.EntrytableBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("entrytable_bgm_cue_name");
                entity.Property(e => e.EntrytableBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("entrytable_bgm_cuesheet_name");
                entity.Property(e => e.FirstBgmPattern)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_bgm_pattern");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
                entity.Property(e => e.PaddockBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("paddock_bgm_cue_name");
                entity.Property(e => e.PaddockBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("paddock_bgm_cuesheet_name");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.RaceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_type");
                entity.Property(e => e.ResultCutinBgmCueName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cue_name_1");
                entity.Property(e => e.ResultCutinBgmCueName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cue_name_2");
                entity.Property(e => e.ResultCutinBgmCueName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cue_name_3");
                entity.Property(e => e.ResultCutinBgmCuesheetName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cuesheet_name_1");
                entity.Property(e => e.ResultCutinBgmCuesheetName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cuesheet_name_2");
                entity.Property(e => e.ResultCutinBgmCuesheetName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_cutin_bgm_cuesheet_name_3");
                entity.Property(e => e.ResultListBgmCueName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cue_name_1");
                entity.Property(e => e.ResultListBgmCueName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cue_name_2");
                entity.Property(e => e.ResultListBgmCueName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cue_name_3");
                entity.Property(e => e.ResultListBgmCuesheetName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cuesheet_name_1");
                entity.Property(e => e.ResultListBgmCuesheetName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cuesheet_name_2");
                entity.Property(e => e.ResultListBgmCuesheetName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("result_list_bgm_cuesheet_name_3");
                entity.Property(e => e.SecondBgmPattern)
                    .HasColumnType("int(11)")
                    .HasColumnName("second_bgm_pattern");
                entity.Property(e => e.SingleModeProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("single_mode_program_id");
                entity.Property(e => e.SingleModeRouteRaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("single_mode_route_race_id");
            });

            modelBuilder.Entity<RaceBgmCutin>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_bgm_cutin");

                entity.HasIndex(e => e.BgmGroupId, "race_bgm_cutin_0_bgm_group_id");

                entity.HasIndex(e => e.CardId, "race_bgm_cutin_0_card_id").IsUnique();

                entity.HasIndex(e => new { e.CardId, e.BgmGroupId }, "race_bgm_cutin_0_card_id_1_bgm_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_group_id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.ExclusiveControl)
                    .HasColumnType("int(11)")
                    .HasColumnName("exclusive_control");
                entity.Property(e => e.FadeoutTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("fadeout_time");
                entity.Property(e => e.LongCutinBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("long_cutin_bgm_cue_name");
                entity.Property(e => e.LongCutinBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("long_cutin_bgm_cuesheet_name");
                entity.Property(e => e.ShortCutinBgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("short_cutin_bgm_cue_name");
                entity.Property(e => e.ShortCutinBgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("short_cutin_bgm_cuesheet_name");
            });

            modelBuilder.Entity<RaceBgmPattern>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_bgm_pattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmCueName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_1");
                entity.Property(e => e.BgmCueName10)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_10");
                entity.Property(e => e.BgmCueName11)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_11");
                entity.Property(e => e.BgmCueName12)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_12");
                entity.Property(e => e.BgmCueName13)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_13");
                entity.Property(e => e.BgmCueName14)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_14");
                entity.Property(e => e.BgmCueName15)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_15");
                entity.Property(e => e.BgmCueName16)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_16");
                entity.Property(e => e.BgmCueName17)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_17");
                entity.Property(e => e.BgmCueName18)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_18");
                entity.Property(e => e.BgmCueName19)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_19");
                entity.Property(e => e.BgmCueName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_2");
                entity.Property(e => e.BgmCueName20)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_20");
                entity.Property(e => e.BgmCueName21)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_21");
                entity.Property(e => e.BgmCueName22)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_22");
                entity.Property(e => e.BgmCueName23)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_23");
                entity.Property(e => e.BgmCueName24)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_24");
                entity.Property(e => e.BgmCueName25)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_25");
                entity.Property(e => e.BgmCueName26)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_26");
                entity.Property(e => e.BgmCueName27)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_27");
                entity.Property(e => e.BgmCueName28)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_28");
                entity.Property(e => e.BgmCueName29)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_29");
                entity.Property(e => e.BgmCueName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_3");
                entity.Property(e => e.BgmCueName30)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_30");
                entity.Property(e => e.BgmCueName4)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_4");
                entity.Property(e => e.BgmCueName5)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_5");
                entity.Property(e => e.BgmCueName6)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_6");
                entity.Property(e => e.BgmCueName7)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_7");
                entity.Property(e => e.BgmCueName8)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_8");
                entity.Property(e => e.BgmCueName9)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name_9");
                entity.Property(e => e.BgmCuesheetName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_1");
                entity.Property(e => e.BgmCuesheetName10)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_10");
                entity.Property(e => e.BgmCuesheetName11)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_11");
                entity.Property(e => e.BgmCuesheetName12)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_12");
                entity.Property(e => e.BgmCuesheetName13)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_13");
                entity.Property(e => e.BgmCuesheetName14)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_14");
                entity.Property(e => e.BgmCuesheetName15)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_15");
                entity.Property(e => e.BgmCuesheetName16)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_16");
                entity.Property(e => e.BgmCuesheetName17)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_17");
                entity.Property(e => e.BgmCuesheetName18)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_18");
                entity.Property(e => e.BgmCuesheetName19)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_19");
                entity.Property(e => e.BgmCuesheetName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_2");
                entity.Property(e => e.BgmCuesheetName20)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_20");
                entity.Property(e => e.BgmCuesheetName21)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_21");
                entity.Property(e => e.BgmCuesheetName22)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_22");
                entity.Property(e => e.BgmCuesheetName23)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_23");
                entity.Property(e => e.BgmCuesheetName24)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_24");
                entity.Property(e => e.BgmCuesheetName25)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_25");
                entity.Property(e => e.BgmCuesheetName26)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_26");
                entity.Property(e => e.BgmCuesheetName27)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_27");
                entity.Property(e => e.BgmCuesheetName28)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_28");
                entity.Property(e => e.BgmCuesheetName29)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_29");
                entity.Property(e => e.BgmCuesheetName3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_3");
                entity.Property(e => e.BgmCuesheetName30)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_30");
                entity.Property(e => e.BgmCuesheetName4)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_4");
                entity.Property(e => e.BgmCuesheetName5)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_5");
                entity.Property(e => e.BgmCuesheetName6)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_6");
                entity.Property(e => e.BgmCuesheetName7)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_7");
                entity.Property(e => e.BgmCuesheetName8)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_8");
                entity.Property(e => e.BgmCuesheetName9)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name_9");
                entity.Property(e => e.BgmSkipTriggerCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_skip_trigger_cue_name");
                entity.Property(e => e.BgmSkipTriggerCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_skip_trigger_cuesheet_name");
                entity.Property(e => e.BgmTime1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_1");
                entity.Property(e => e.BgmTime10)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_10");
                entity.Property(e => e.BgmTime11)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_11");
                entity.Property(e => e.BgmTime12)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_12");
                entity.Property(e => e.BgmTime13)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_13");
                entity.Property(e => e.BgmTime14)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_14");
                entity.Property(e => e.BgmTime15)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_15");
                entity.Property(e => e.BgmTime16)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_16");
                entity.Property(e => e.BgmTime17)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_17");
                entity.Property(e => e.BgmTime18)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_18");
                entity.Property(e => e.BgmTime19)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_19");
                entity.Property(e => e.BgmTime2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_2");
                entity.Property(e => e.BgmTime20)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_20");
                entity.Property(e => e.BgmTime21)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_21");
                entity.Property(e => e.BgmTime22)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_22");
                entity.Property(e => e.BgmTime23)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_23");
                entity.Property(e => e.BgmTime24)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_24");
                entity.Property(e => e.BgmTime25)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_25");
                entity.Property(e => e.BgmTime26)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_26");
                entity.Property(e => e.BgmTime27)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_27");
                entity.Property(e => e.BgmTime28)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_28");
                entity.Property(e => e.BgmTime29)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_29");
                entity.Property(e => e.BgmTime3)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_3");
                entity.Property(e => e.BgmTime30)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_30");
                entity.Property(e => e.BgmTime4)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_4");
                entity.Property(e => e.BgmTime5)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_5");
                entity.Property(e => e.BgmTime6)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_6");
                entity.Property(e => e.BgmTime7)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_7");
                entity.Property(e => e.BgmTime8)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_8");
                entity.Property(e => e.BgmTime9)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_time_9");
                entity.Property(e => e.BgmTriggerCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_trigger_cue_name");
                entity.Property(e => e.BgmTriggerCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_trigger_cuesheet_name");
                entity.Property(e => e.BgmTriggerTimeAgo)
                    .HasColumnType("int(11)")
                    .HasColumnName("bgm_trigger_time_ago");
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
                    .HasColumnType("int(11)")
                    .HasColumnName("bib_color");
                entity.Property(e => e.FontColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("font_color");
            });

            modelBuilder.Entity<RaceCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_condition");

                entity.HasIndex(e => new { e.Ground, e.Weather }, "race_condition_0_ground_1_weather");

                entity.HasIndex(e => new { e.Season, e.Ground }, "race_condition_0_season_1_ground");

                entity.HasIndex(e => new { e.Season, e.Weather }, "race_condition_0_season_1_weather");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Area)
                    .HasColumnType("int(11)")
                    .HasColumnName("area");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<RaceCourseSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_course_set");

                entity.HasIndex(e => e.RaceTrackId, "race_course_set_0_race_track_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CourseSetStatusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("course_set_status_id");
                entity.Property(e => e.Distance)
                    .HasColumnType("int(11)")
                    .HasColumnName("distance");
                entity.Property(e => e.ExCamera)
                    .HasColumnType("int(11)")
                    .HasColumnName("ex_camera");
                entity.Property(e => e.FenceSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_set");
                entity.Property(e => e.FinishTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_time_max");
                entity.Property(e => e.FinishTimeMaxRandomRange)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_time_max_random_range");
                entity.Property(e => e.FinishTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_time_min");
                entity.Property(e => e.FinishTimeMinRandomRange)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_time_min_random_range");
                entity.Property(e => e.FloatLaneMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_lane_max");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.Inout)
                    .HasColumnType("int(11)")
                    .HasColumnName("inout");
                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");
                entity.Property(e => e.RunOutside)
                    .HasColumnType("int(11)")
                    .HasColumnName("run_outside");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<RaceCourseSetStatus>(entity =>
            {
                entity.HasKey(e => e.CourseSetStatusId).HasName("PRIMARY");

                entity.ToTable("race_course_set_status");

                entity.Property(e => e.CourseSetStatusId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("course_set_status_id");
                entity.Property(e => e.TargetStatus1)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_status_1");
                entity.Property(e => e.TargetStatus2)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_status_2");
            });

            modelBuilder.Entity<RaceEnvDefine>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_env_define");

                entity.HasIndex(e => e.RaceTrackId, "race_env_define_0_race_track_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");
                entity.Property(e => e.Resource)
                    .HasColumnType("int(11)")
                    .HasColumnName("resource");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.Timezone)
                    .HasColumnType("int(11)")
                    .HasColumnName("timezone");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<RaceFenceSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_fence_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Fence1)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_1");
                entity.Property(e => e.Fence2)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_2");
                entity.Property(e => e.Fence3)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_3");
                entity.Property(e => e.Fence4)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_4");
                entity.Property(e => e.Fence5)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_5");
                entity.Property(e => e.Fence6)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_6");
                entity.Property(e => e.Fence7)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_7");
                entity.Property(e => e.Fence8)
                    .HasColumnType("int(11)")
                    .HasColumnName("fence_8");
            });

            modelBuilder.Entity<RaceInstance>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_instance");

                entity.HasIndex(e => e.RaceId, "race_instance_0_race_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ClockTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("clock_time");
                entity.Property(e => e.Date)
                    .HasColumnType("int(11)")
                    .HasColumnName("date");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
                entity.Property(e => e.RaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_id");
                entity.Property(e => e.RaceNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_number");
                entity.Property(e => e.Time)
                    .HasColumnType("int(11)")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<RaceJikkyoBase>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_jikkyo_base");

                entity.HasIndex(e => e.Mode, "race_jikkyo_base_0_mode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CameraHorse1)
                    .HasColumnType("int(11)")
                    .HasColumnName("camera_horse1");
                entity.Property(e => e.CameraHorse2)
                    .HasColumnType("int(11)")
                    .HasColumnName("camera_horse2");
                entity.Property(e => e.CameraId)
                    .HasColumnType("int(11)")
                    .HasColumnName("camera_id");
                entity.Property(e => e.CommentGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("comment_group");
                entity.Property(e => e.DisableReentrySituation)
                    .HasColumnType("int(11)")
                    .HasColumnName("disable_reentry_situation");
                entity.Property(e => e.DisableReuse)
                    .HasColumnType("int(11)")
                    .HasColumnName("disable_reuse");
                entity.Property(e => e.Discard)
                    .HasColumnType("int(11)")
                    .HasColumnName("discard");
                entity.Property(e => e.Immediate)
                    .HasColumnType("int(11)")
                    .HasColumnName("immediate");
                entity.Property(e => e.IsForcePlayEventCamera)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_force_play_event_camera");
                entity.Property(e => e.MessageGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("message_group");
                entity.Property(e => e.Mode)
                    .HasColumnType("int(11)")
                    .HasColumnName("mode");
                entity.Property(e => e.Per)
                    .HasColumnType("int(11)")
                    .HasColumnName("per");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.Situation)
                    .HasColumnType("int(11)")
                    .HasColumnName("situation");
                entity.Property(e => e.SituationEnd)
                    .HasColumnType("int(11)")
                    .HasColumnName("situation_end");
                entity.Property(e => e.SubMode)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_mode");
                entity.Property(e => e.SubModeJump)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_mode_jump");
                entity.Property(e => e.SubSituation)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_situation");
                entity.Property(e => e.Tension)
                    .HasColumnType("int(11)")
                    .HasColumnName("tension");
                entity.Property(e => e.Trigger0)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger0");
                entity.Property(e => e.Trigger1)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger1");
                entity.Property(e => e.Trigger2)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger2");
                entity.Property(e => e.Trigger3)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger3");
                entity.Property(e => e.Trigger4)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger4");
                entity.Property(e => e.Trigger5)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger5");
                entity.Property(e => e.Trigger6)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger6");
                entity.Property(e => e.Trigger7)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger7");
                entity.Property(e => e.Trigger8)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger8");
                entity.Property(e => e.Trigger9)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger9");
            });

            modelBuilder.Entity<RaceJikkyoBaseVenus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_jikkyo_base_venus");

                entity.HasIndex(e => e.Mode, "race_jikkyo_base_venus_0_mode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CameraHorse1)
                    .HasColumnType("int(11)")
                    .HasColumnName("camera_horse1");
                entity.Property(e => e.CameraHorse2)
                    .HasColumnType("int(11)")
                    .HasColumnName("camera_horse2");
                entity.Property(e => e.CameraId)
                    .HasColumnType("int(11)")
                    .HasColumnName("camera_id");
                entity.Property(e => e.CommentGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("comment_group");
                entity.Property(e => e.DisableReentrySituation)
                    .HasColumnType("int(11)")
                    .HasColumnName("disable_reentry_situation");
                entity.Property(e => e.DisableReuse)
                    .HasColumnType("int(11)")
                    .HasColumnName("disable_reuse");
                entity.Property(e => e.Discard)
                    .HasColumnType("int(11)")
                    .HasColumnName("discard");
                entity.Property(e => e.Immediate)
                    .HasColumnType("int(11)")
                    .HasColumnName("immediate");
                entity.Property(e => e.MessageGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("message_group");
                entity.Property(e => e.Mode)
                    .HasColumnType("int(11)")
                    .HasColumnName("mode");
                entity.Property(e => e.Per)
                    .HasColumnType("int(11)")
                    .HasColumnName("per");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.Situation)
                    .HasColumnType("int(11)")
                    .HasColumnName("situation");
                entity.Property(e => e.SituationEnd)
                    .HasColumnType("int(11)")
                    .HasColumnName("situation_end");
                entity.Property(e => e.SubMode)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_mode");
                entity.Property(e => e.SubModeJump)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_mode_jump");
                entity.Property(e => e.SubSituation)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_situation");
                entity.Property(e => e.Tension)
                    .HasColumnType("int(11)")
                    .HasColumnName("tension");
                entity.Property(e => e.Trigger0)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger0");
                entity.Property(e => e.Trigger1)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger1");
                entity.Property(e => e.Trigger2)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger2");
                entity.Property(e => e.Trigger3)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger3");
                entity.Property(e => e.Trigger4)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger4");
                entity.Property(e => e.Trigger5)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger5");
                entity.Property(e => e.Trigger6)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger6");
                entity.Property(e => e.Trigger7)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger7");
                entity.Property(e => e.Trigger8)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger8");
                entity.Property(e => e.Trigger9)
                    .HasColumnType("int(11)")
                    .HasColumnName("trigger9");
            });

            modelBuilder.Entity<RaceJikkyoComment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_jikkyo_comment");

                entity.HasIndex(e => e.GroupId, "race_jikkyo_comment_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("message");
                entity.Property(e => e.MessageGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("message_group");
                entity.Property(e => e.OmitTag)
                    .HasColumnType("int(11)")
                    .HasColumnName("omit_tag");
                entity.Property(e => e.Per)
                    .HasColumnType("int(11)")
                    .HasColumnName("per");
                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("voice");
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
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.ConditionType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_3");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
                entity.Property(e => e.CuesheetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cuesheet_id");
                entity.Property(e => e.CuesheetName)
                    .HasColumnType("int(11)")
                    .HasColumnName("cuesheet_name");
            });

            modelBuilder.Entity<RaceJikkyoMessage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_jikkyo_message");

                entity.HasIndex(e => e.CommentGroup, "race_jikkyo_message_0_comment_group");

                entity.HasIndex(e => e.GroupId, "race_jikkyo_message_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommentGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("comment_group");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("message");
                entity.Property(e => e.OmitTag)
                    .HasColumnType("int(11)")
                    .HasColumnName("omit_tag");
                entity.Property(e => e.Per)
                    .HasColumnType("int(11)")
                    .HasColumnName("per");
                entity.Property(e => e.Reuse)
                    .HasColumnType("int(11)")
                    .HasColumnName("reuse");
                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("voice");
            });

            modelBuilder.Entity<RaceJikkyoRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_jikkyo_race");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CueId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cue_id");
            });

            modelBuilder.Entity<RaceJikkyoTrigger>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_jikkyo_trigger");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Command)
                    .HasColumnType("int(11)")
                    .HasColumnName("command");
                entity.Property(e => e.Horse1)
                    .HasColumnType("int(11)")
                    .HasColumnName("horse1");
                entity.Property(e => e.Horse2)
                    .HasColumnType("int(11)")
                    .HasColumnName("horse2");
                entity.Property(e => e.Inequality)
                    .HasColumnType("int(11)")
                    .HasColumnName("inequality");
                entity.Property(e => e.Param1)
                    .HasColumnType("int(11)")
                    .HasColumnName("param1");
                entity.Property(e => e.Param2)
                    .HasColumnType("int(11)")
                    .HasColumnName("param2");
            });

            modelBuilder.Entity<RaceMotivationRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_motivation_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MotivationRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("motivation_rate");
            });

            modelBuilder.Entity<RaceOverrunPattern>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_overrun_pattern");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FinishOrder0Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order_0_type");
                entity.Property(e => e.FinishOrder1Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order_1_type");
                entity.Property(e => e.FinishOrder2Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order_2_type");
                entity.Property(e => e.FinishOrder3Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order_3_type");
                entity.Property(e => e.FinishOrder4Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order_4_type");
                entity.Property(e => e.FinishOrderLoseType)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order_lose_type");
            });

            modelBuilder.Entity<RacePlayerCamera>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_player_camera");

                entity.HasIndex(e => e.Category, "race_player_camera_0_category");

                entity.HasIndex(e => e.PrefabName, "race_player_camera_0_prefab_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Category)
                    .HasColumnType("int(11)")
                    .HasColumnName("category");
                entity.Property(e => e.PrefabName)
                    .IsRequired()
                    .HasMaxLength(750)
                    .HasColumnName("prefab_name");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
            });

            modelBuilder.Entity<RaceProperDistanceRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_proper_distance_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ProperRatePower)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_rate_power");
                entity.Property(e => e.ProperRateSpeed)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_rate_speed");
            });

            modelBuilder.Entity<RaceProperGroundRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_proper_ground_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ProperRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_rate");
            });

            modelBuilder.Entity<RaceProperRunningstyleRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_proper_runningstyle_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ProperRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_rate");
            });

            modelBuilder.Entity<RaceSingleModeTeamStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_single_mode_team_status");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_status");
                entity.Property(e => e.TeamRankThreshold)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_rank_threshold");
            });

            modelBuilder.Entity<RaceTrack>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_track");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Area)
                    .HasColumnType("int(11)")
                    .HasColumnName("area");
                entity.Property(e => e.BoardConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("board_condition_type");
                entity.Property(e => e.EnableHalfGate)
                    .HasColumnType("int(11)")
                    .HasColumnName("enable_half_gate");
                entity.Property(e => e.FlagType)
                    .HasColumnType("int(11)")
                    .HasColumnName("flag_type");
                entity.Property(e => e.FootsmokeColorType)
                    .HasColumnType("int(11)")
                    .HasColumnName("footsmoke_color_type");
                entity.Property(e => e.GateLampType)
                    .HasColumnType("int(11)")
                    .HasColumnName("gate_lamp_type");
                entity.Property(e => e.GatePanelType)
                    .HasColumnType("int(11)")
                    .HasColumnName("gate_panel_type");
                entity.Property(e => e.HorseNumGateVariation)
                    .HasColumnType("int(11)")
                    .HasColumnName("horse_num_gate_variation");
                entity.Property(e => e.InitialLaneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("initial_lane_type");
                entity.Property(e => e.ResultBoardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_board_type");
                entity.Property(e => e.TurfVisionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("turf_vision_type");
            });

            modelBuilder.Entity<RaceTrophy>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("race_trophy");

                entity.HasIndex(e => e.RaceInstanceId, "race_trophy_0_race_instance_id").IsUnique();

                entity.HasIndex(e => e.TrophyId, "race_trophy_0_trophy_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.DisplayEndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("display_end_date");
                entity.Property(e => e.EventType)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_type");
                entity.Property(e => e.OriginalFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("original_flag");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.Size)
                    .HasColumnType("int(11)")
                    .HasColumnName("size");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.TrophyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("trophy_id");
            });

            modelBuilder.Entity<RandomEarTailMotion>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("random_ear_tail_motion");

                entity.HasIndex(e => e.PartsType, "random_ear_tail_motion_0_parts_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EarType)
                    .HasColumnType("int(11)")
                    .HasColumnName("ear_type");
                entity.Property(e => e.MotionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("motion_name");
                entity.Property(e => e.PartsType)
                    .HasColumnType("int(11)")
                    .HasColumnName("parts_type");
                entity.Property(e => e.UseStory)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_story");
                entity.Property(e => e.UseTheater)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_theater");
            });

            modelBuilder.Entity<RatingRaceCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("rating_race_condition");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<RatingRaceData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("rating_race_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.RatingRankInitialLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_rank_initial_limit");
                entity.Property(e => e.RatingRankResetLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_rank_reset_limit");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.WeekdayFreePlayNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("weekday_free_play_num");
                entity.Property(e => e.WeekendFreePlayNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("weekend_free_play_num");
            });

            modelBuilder.Entity<RatingRaceFinaleReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("rating_race_finale_reward");

                entity.HasIndex(e => e.RatingRaceDataId, "rating_race_finale_reward_0_rating_race_data_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FinishOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_order");
                entity.Property(e => e.RatingRaceDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_data_id");
                entity.Property(e => e.RatingRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_rank");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
            });

            modelBuilder.Entity<RatingRacePhaseSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("rating_race_phase_schedule");

                entity.HasIndex(e => e.RatingRaceDataId, "rating_race_phase_schedule_0_rating_race_data_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.Phase)
                    .HasColumnType("int(11)")
                    .HasColumnName("phase");
                entity.Property(e => e.RatingRaceConditionIdDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_condition_id_dirt");
                entity.Property(e => e.RatingRaceConditionIdLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_condition_id_long");
                entity.Property(e => e.RatingRaceConditionIdMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_condition_id_middle");
                entity.Property(e => e.RatingRaceConditionIdMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_condition_id_mile");
                entity.Property(e => e.RatingRaceConditionIdShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_condition_id_short");
                entity.Property(e => e.RatingRaceDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_data_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.Week)
                    .HasColumnType("int(11)")
                    .HasColumnName("week");
            });

            modelBuilder.Entity<RatingRaceRatingRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("rating_race_rating_rank");

                entity.HasIndex(e => e.RatingRaceDataId, "rating_race_rating_rank_0_rating_race_data_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DowngradePermitted)
                    .HasColumnType("int(11)")
                    .HasColumnName("downgrade_permitted");
                entity.Property(e => e.NpcCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_count");
                entity.Property(e => e.RatingRaceDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_data_id");
                entity.Property(e => e.RatingRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_rank");
                entity.Property(e => e.RatingScoreMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_score_max");
                entity.Property(e => e.RatingScoreMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_score_min");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
            });

            modelBuilder.Entity<RatingRaceRewardGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("rating_race_reward_group");

                entity.HasIndex(e => e.RewardGroupId, "rating_race_reward_group_0_reward_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
            });

            modelBuilder.Entity<RatingRaceWeekendReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("rating_race_weekend_reward");

                entity.HasIndex(e => e.RatingRaceDataId, "rating_race_weekend_reward_0_rating_race_data_id");

                entity.HasIndex(e => new { e.RatingRaceDataId, e.RatingRank }, "rating_race_weekend_reward_0_rating_race_data_id_1_rating_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RatingRaceDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_race_data_id");
                entity.Property(e => e.RatingRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rating_rank");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
                entity.Property(e => e.WeekendRewardPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("weekend_reward_point");
            });

            modelBuilder.Entity<RoomMatchTrainingRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("room_match_training_rank");

                entity.HasIndex(e => e.Rank, "room_match_training_rank_0_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank");
                entity.Property(e => e.RuleLine)
                    .HasColumnType("int(11)")
                    .HasColumnName("rule_line");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<SeasonData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("season_data");

                entity.HasIndex(e => e.Type, "season_data_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SelectPickup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("select_pickup");

                entity.HasIndex(e => e.GachaId, "select_pickup_0_gacha_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.CardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_type");
                entity.Property(e => e.GachaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gacha_id");
                entity.Property(e => e.RecommendOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("recommend_order");
                entity.Property(e => e.RecommendType)
                    .HasColumnType("int(11)")
                    .HasColumnName("recommend_type");
            });

            modelBuilder.Entity<ShortEpisode>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("short_episode");

                entity.HasIndex(e => e.Scene, "short_episode_0_scene");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.Scene)
                    .HasColumnType("int(11)")
                    .HasColumnName("scene");
                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<SingleMode09Board>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_board");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
            });

            modelBuilder.Entity<SingleMode09Chip>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_chip");

                entity.HasIndex(e => e.BoardId, "single_mode_09_chip_0_board_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BoardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("board_id");
                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("schedule_id");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SingleMode09ChipEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_chip_effect");

                entity.HasIndex(e => e.ChipId, "single_mode_09_chip_effect_0_chip_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ChipId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chip_id");
                entity.Property(e => e.EffectCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_category");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Point)
                    .HasColumnType("int(11)")
                    .HasColumnName("point");
            });

            modelBuilder.Entity<SingleMode09LearningBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_learning_bonus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_value");
                entity.Property(e => e.BonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value");
                entity.Property(e => e.PointMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("point_max");
                entity.Property(e => e.PointMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("point_min");
            });

            modelBuilder.Entity<SingleMode09LinkEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_link_effect");

                entity.HasIndex(e => e.CharaId, "single_mode_09_link_effect_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });

            modelBuilder.Entity<SingleMode09ProgressRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_progress_rate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ProgressMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("progress_max");
                entity.Property(e => e.ProgressMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("progress_min");
                entity.Property(e => e.ResultType)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_type");
            });

            modelBuilder.Entity<SingleMode09Schedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.StockNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("stock_num");
                entity.Property(e => e.TargetPt)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_pt");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });

            modelBuilder.Entity<SingleMode09TrainingBoost>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_09_training_boost");

                entity.HasIndex(e => e.BoostSetId, "single_mode_09_training_boost_0_boost_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_value");
                entity.Property(e => e.BoostSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("boost_set_id");
                entity.Property(e => e.LevelMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_max");
                entity.Property(e => e.LevelMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("level_min");
            });

            modelBuilder.Entity<SingleModeAnalyzeCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_analyze_condition");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeAnalyzeMessage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_analyze_message");

                entity.HasIndex(e => e.Popularity, "single_mode_analyze_message_0_popularity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharacterType)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_type");
                entity.Property(e => e.ConditionSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set");
                entity.Property(e => e.MotionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_type");
                entity.Property(e => e.Popularity)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.ProperDistance)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance");
                entity.Property(e => e.ProperGround)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
                entity.Property(e => e.Year)
                    .HasColumnType("int(11)")
                    .HasColumnName("year");
            });

            modelBuilder.Entity<SingleModeAnalyzeTicket>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_analyze_ticket");

                entity.HasIndex(e => e.Grade, "single_mode_analyze_ticket_0_grade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CostTicket)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_ticket");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
            });

            modelBuilder.Entity<SingleModeAoOffset>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_ao_offset");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Offset1)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset_1");
                entity.Property(e => e.Offset2)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset_2");
                entity.Property(e => e.Offset3)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset_3");
                entity.Property(e => e.Offset4)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset_4");
                entity.Property(e => e.Offset5)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset_5");
            });

            modelBuilder.Entity<SingleModeAoharuCuttType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_aoharu_cutt_type");

                entity.HasIndex(e => e.CharaType, "single_mode_aoharu_cutt_type_0_chara_type");

                entity.HasIndex(e => new { e.CharaType, e.CuttType }, "single_mode_aoharu_cutt_type_0_chara_type_1_cutt_type");

                entity.HasIndex(e => e.CuttType, "single_mode_aoharu_cutt_type_0_cutt_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaType)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_type");
                entity.Property(e => e.CuttId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cutt_id");
                entity.Property(e => e.CuttType)
                    .HasColumnType("int(11)")
                    .HasColumnName("cutt_type");
            });

            modelBuilder.Entity<SingleModeAoharuResultCutt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_aoharu_result_cutt");

                entity.HasIndex(e => e.CharaId, "single_mode_aoharu_result_cutt_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CuttId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cutt_id");
            });

            modelBuilder.Entity<SingleModeAoharuSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_aoharu_schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.NoticeTurn1)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_turn_1");
                entity.Property(e => e.NoticeTurn2)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_turn_2");
                entity.Property(e => e.NoticeTurn3)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_turn_3");
                entity.Property(e => e.NoticeTurn4)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_turn_4");
                entity.Property(e => e.NoticeTurn5)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_turn_5");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });

            modelBuilder.Entity<SingleModeArcDebuff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_debuff");

                entity.HasIndex(e => e.PotentialId, "single_mode_arc_debuff_0_potential_id");

                entity.HasIndex(e => new { e.PotentialId, e.PotentialLv }, "single_mode_arc_debuff_0_potential_id_1_potential_lv");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.Middle)
                    .HasColumnType("int(11)")
                    .HasColumnName("middle");
                entity.Property(e => e.PotentialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_id");
                entity.Property(e => e.PotentialLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_lv");
                entity.Property(e => e.Power)
                    .HasColumnType("int(11)")
                    .HasColumnName("power");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Turf)
                    .HasColumnType("int(11)")
                    .HasColumnName("turf");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<SingleModeArcPotential>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_potential");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Queue)
                    .HasColumnType("int(11)")
                    .HasColumnName("queue");
                entity.Property(e => e.Row)
                    .HasColumnType("int(11)")
                    .HasColumnName("row");
            });

            modelBuilder.Entity<SingleModeArcPotentialBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_potential_bonus");

                entity.HasIndex(e => e.PotentialId, "single_mode_arc_potential_bonus_0_potential_id");

                entity.HasIndex(e => new { e.PotentialId, e.PotentialLv }, "single_mode_arc_potential_bonus_0_potential_id_1_potential_lv");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
                entity.Property(e => e.PotentialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_id");
                entity.Property(e => e.PotentialLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_lv");
            });

            modelBuilder.Entity<SingleModeArcPotentialBuff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_potential_buff");

                entity.HasIndex(e => e.PotentialId, "single_mode_arc_potential_buff_0_potential_id");

                entity.HasIndex(e => new { e.PotentialId, e.PotentialLv }, "single_mode_arc_potential_buff_0_potential_id_1_potential_lv");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.Middle)
                    .HasColumnType("int(11)")
                    .HasColumnName("middle");
                entity.Property(e => e.PotentialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_id");
                entity.Property(e => e.PotentialLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_lv");
                entity.Property(e => e.Power)
                    .HasColumnType("int(11)")
                    .HasColumnName("power");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Turf)
                    .HasColumnType("int(11)")
                    .HasColumnName("turf");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<SingleModeArcPotentialCond>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_potential_cond");

                entity.HasIndex(e => e.PotentialId, "single_mode_arc_potential_cond_0_potential_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
                entity.Property(e => e.ConditionValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_4");
                entity.Property(e => e.ConditionValue5)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_5");
                entity.Property(e => e.CountType)
                    .HasColumnType("int(11)")
                    .HasColumnName("count_type");
                entity.Property(e => e.DisplayTotalCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("display_total_count");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
                entity.Property(e => e.PotentialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_id");
            });

            modelBuilder.Entity<SingleModeArcPotentialLevel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_potential_level");

                entity.HasIndex(e => e.PotentialId, "single_mode_arc_potential_level_0_potential_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GlobalExp)
                    .HasColumnType("int(11)")
                    .HasColumnName("global_exp");
                entity.Property(e => e.PotentialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_id");
                entity.Property(e => e.PotentialLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_lv");
            });

            modelBuilder.Entity<SingleModeArcRaceDebuff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_race_debuff");

                entity.HasIndex(e => e.DebuffId, "single_mode_arc_race_debuff_0_debuff_id");

                entity.HasIndex(e => e.RaceInstanceId, "single_mode_arc_race_debuff_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DebuffId)
                    .HasColumnType("int(11)")
                    .HasColumnName("debuff_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<SingleModeArcSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_schedule");

                entity.HasIndex(e => e.RaceProgramId, "single_mode_arc_schedule_0_race_program_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_program_id");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });

            modelBuilder.Entity<SingleModeArcTaimanPeffGrp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_taiman_peff_grp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_id_1");
                entity.Property(e => e.EffectId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_id_2");
                entity.Property(e => e.IconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id");
                entity.Property(e => e.SubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_id");
            });

            modelBuilder.Entity<SingleModeArcTrainingEff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_training_eff");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RequirePtMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("require_pt_max");
                entity.Property(e => e.RequirePtMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("require_pt_min");
                entity.Property(e => e.TrainingEff)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_eff");
            });

            modelBuilder.Entity<SingleModeArcWinPt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_arc_win_pt");

                entity.HasIndex(e => e.Grade, "single_mode_arc_win_pt_0_grade");

                entity.HasIndex(e => e.RaceInstanceId, "single_mode_arc_win_pt_0_race_instance_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
                entity.Property(e => e.OrderMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_max");
                entity.Property(e => e.OrderMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_min");
                entity.Property(e => e.PointNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("point_num");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<SingleModeChangeCharaRoute>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_change_chara_route");

                entity.HasIndex(e => new { e.RouteRaceGroupId, e.CharaId }, "single_mode_change_chara_route_0_route_race_group_id_1_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.RouteRaceGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("route_race_group_id");
                entity.Property(e => e.RouteRaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("route_race_id");
            });

            modelBuilder.Entity<SingleModeCharaEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_chara_effect");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_category");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
            });

            modelBuilder.Entity<SingleModeCharaEffectBuff>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_chara_effect_buff");

                entity.HasIndex(e => e.CharaId, "single_mode_chara_effect_buff_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.EffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_id");
                entity.Property(e => e.GutsAdd)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts_add");
                entity.Property(e => e.PowerAdd)
                    .HasColumnType("int(11)")
                    .HasColumnName("power_add");
                entity.Property(e => e.ProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("program_id");
                entity.Property(e => e.SpeedAdd)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed_add");
                entity.Property(e => e.StaminaAdd)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina_add");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
                entity.Property(e => e.WizAdd)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz_add");
            });

            modelBuilder.Entity<SingleModeCharaGrade>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_chara_grade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.NeedFanCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_fan_count");
                entity.Property(e => e.RunNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("run_num");
                entity.Property(e => e.WinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_num");
            });

            modelBuilder.Entity<SingleModeCharaProgram>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_chara_program");

                entity.HasIndex(e => e.CharaId, "single_mode_chara_program_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ProgramGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("program_group");
                entity.Property(e => e.ProgramGroup2)
                    .HasColumnType("int(11)")
                    .HasColumnName("program_group_2");
            });

            modelBuilder.Entity<SingleModeConclusionSet>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("single_mode_conclusion_set");

                entity.HasIndex(e => e.StoryId, "single_mode_conclusion_set_0_story_id");

                entity.Property(e => e.ConclusionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("conclusion_id");
                entity.Property(e => e.RootId)
                    .HasColumnType("int(11)")
                    .HasColumnName("root_id");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
            });

            modelBuilder.Entity<SingleModeCookCoinRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_coin_rate");

                entity.HasIndex(e => new { e.MaterialCount, e.Period }, "single_mode_cook_coin_rate_0_material_count_1_period");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CoinQuantityRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("coin_quantity_rate");
                entity.Property(e => e.MaterialCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_count");
                entity.Property(e => e.Period)
                    .HasColumnType("int(11)")
                    .HasColumnName("period");
            });

            modelBuilder.Entity<SingleModeCookCookingCutt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_cooking_cutt");

                entity.HasIndex(e => e.CookingNum, "single_mode_cook_cooking_cutt_0_cooking_num");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Camera)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("camera");
                entity.Property(e => e.CookingMotionId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_motion_id_1");
                entity.Property(e => e.CookingMotionId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_motion_id_2");
                entity.Property(e => e.CookingMotionId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_motion_id_3");
                entity.Property(e => e.CookingMotionId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_motion_id_4");
                entity.Property(e => e.CookingNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_num");
                entity.Property(e => e.SuccessMotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_motion_id");
            });

            modelBuilder.Entity<SingleModeCookCookingRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_cooking_rate");

                entity.HasIndex(e => e.DishType, "single_mode_cook_cooking_rate_0_dish_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConfirmedGreatSuccessRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("confirmed_great_success_rate");
                entity.Property(e => e.CookingCuttId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_cutt_id");
                entity.Property(e => e.CookingNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_num");
                entity.Property(e => e.DishType)
                    .HasColumnType("int(11)")
                    .HasColumnName("dish_type");
                entity.Property(e => e.GreatSuccessRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("great_success_rate");
                entity.Property(e => e.SuccessRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_rate");
            });

            modelBuilder.Entity<SingleModeCookCookingType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_cooking_type");

                entity.HasIndex(e => e.CookingMotionId, "single_mode_cook_cooking_type_0_cooking_motion_id");

                entity.HasIndex(e => new { e.CookingMotionId, e.SwapType }, "single_mode_cook_cooking_type_0_cooking_motion_id_1_swap_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CookingEffectName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cooking_effect_name_1");
                entity.Property(e => e.CookingEffectName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cooking_effect_name_2");
                entity.Property(e => e.CookingEffectPosition1)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_effect_position_1");
                entity.Property(e => e.CookingEffectPosition2)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_effect_position_2");
                entity.Property(e => e.CookingEffectSwapName1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cooking_effect_swap_name_1");
                entity.Property(e => e.CookingEffectSwapName2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cooking_effect_swap_name_2");
                entity.Property(e => e.CookingEffectSwapPosition1)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_effect_swap_position_1");
                entity.Property(e => e.CookingEffectSwapPosition2)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_effect_swap_position_2");
                entity.Property(e => e.CookingMotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_motion_id");
                entity.Property(e => e.CookingMotionSwapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cooking_motion_swap_id");
                entity.Property(e => e.SwapType)
                    .HasColumnType("int(11)")
                    .HasColumnName("swap_type");
            });

            modelBuilder.Entity<SingleModeCookDish>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_dish");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DishGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dish_group_id");
                entity.Property(e => e.DishSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dish_set_id");
                entity.Property(e => e.DishType)
                    .HasColumnType("int(11)")
                    .HasColumnName("dish_type");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.GainCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_coin");
                entity.Property(e => e.GainPower)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_power");
                entity.Property(e => e.MaterialGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_group_id");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.SortOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_order");
                entity.Property(e => e.SuccessEffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_effect_group_id");
            });

            modelBuilder.Entity<SingleModeCookDishCutt>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_dish_cutt");

                entity.HasIndex(e => e.CommandGroupId, "single_mode_cook_dish_cutt_0_command_group_id");

                entity.HasIndex(e => new { e.CommandGroupId, e.MaterialGroupId }, "single_mode_cook_dish_cutt_0_command_group_id_material_group_id");

                entity.HasIndex(e => e.CuttId, "single_mode_cook_dish_cutt_0_cutt_id").HasAnnotation("MySql:IndexPrefixLength", new[] { 768 });

                entity.HasIndex(e => e.MaterialGroupId, "single_mode_cook_dish_cutt_0_material_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id");
                entity.Property(e => e.CuttId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cutt_id");
                entity.Property(e => e.IsSuccess)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_success");
                entity.Property(e => e.MaterialGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_group_id");
                entity.Property(e => e.PropId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("prop_id");
            });

            modelBuilder.Entity<SingleModeCookDishCuttSe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_dish_cutt_se");

                entity.HasIndex(e => e.CharaType, "single_mode_cook_dish_cutt_se_0_chara_type");

                entity.HasIndex(e => new { e.CharaType, e.CommandGroupId }, "single_mode_cook_dish_cutt_se_0_chara_type_1_command_group_id");

                entity.HasIndex(e => e.CommandGroupId, "single_mode_cook_dish_cutt_se_0_command_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaType)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_type");
                entity.Property(e => e.CommandGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id");
                entity.Property(e => e.SeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name");
                entity.Property(e => e.SeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cuesheet_name");
            });

            modelBuilder.Entity<SingleModeCookDishEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_dish_effect");

                entity.HasIndex(e => e.EffectGroupId, "single_mode_cook_dish_effect_0_effect_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });

            modelBuilder.Entity<SingleModeCookDishIcon>(entity =>
            {
                entity.HasKey(e => e.DishGroupId).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_dish_icon");

                entity.Property(e => e.DishGroupId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("dish_group_id");
                entity.Property(e => e.IconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id");
            });

            modelBuilder.Entity<SingleModeCookDishMaterial>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_dish_material");

                entity.HasIndex(e => e.MaterialGroupId, "single_mode_cook_dish_material_0_material_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MaterialGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_group_id");
                entity.Property(e => e.MaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_id");
                entity.Property(e => e.MaterialNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_num");
            });

            modelBuilder.Entity<SingleModeCookDishName>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_dish_name");

                entity.HasIndex(e => e.DishGroupId, "single_mode_cook_dish_name_0_dish_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.DishGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dish_group_id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.GreatSuccessFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("great_success_flag");
            });

            modelBuilder.Entity<SingleModeCookGarden>(entity =>
            {
                entity.HasKey(e => e.FacilityId).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_garden");

                entity.Property(e => e.FacilityId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_id");
            });

            modelBuilder.Entity<SingleModeCookGardenBg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_garden_bg");

                entity.HasIndex(e => e.BgId, "single_mode_cook_garden_bg_0_bg_id");

                entity.HasIndex(e => new { e.Month, e.HalfType }, "single_mode_cook_garden_bg_0_month_1_half_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.HalfType)
                    .HasColumnType("int(11)")
                    .HasColumnName("half_type");
                entity.Property(e => e.MiniMotionGroupIdMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_group_id_max");
                entity.Property(e => e.MiniMotionGroupIdMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_group_id_min");
                entity.Property(e => e.Month)
                    .HasColumnType("int(11)")
                    .HasColumnName("month");
                entity.Property(e => e.Progress)
                    .HasColumnType("int(11)")
                    .HasColumnName("progress");
                entity.Property(e => e.SubBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_bg_id");
            });

            modelBuilder.Entity<SingleModeCookGardenEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_garden_effect");

                entity.HasIndex(e => e.EffectGroupId, "single_mode_cook_garden_effect_0_effect_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });

            modelBuilder.Entity<SingleModeCookGardenLevel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_garden_level");

                entity.HasIndex(e => e.FacilityId, "single_mode_cook_garden_level_0_facility_id");

                entity.HasIndex(e => new { e.FacilityId, e.GardenLv }, "single_mode_cook_garden_level_0_facility_id_1_garden_lv");

                entity.HasIndex(e => e.GardenLv, "single_mode_cook_garden_level_0_garden_lv");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CoinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("coin_num");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_id");
                entity.Property(e => e.FacilityLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("facility_lv");
                entity.Property(e => e.GardenLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("garden_lv");
            });

            modelBuilder.Entity<SingleModeCookListener>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_listener");

                entity.HasIndex(e => e.Camera, "single_mode_cook_listener_0_camera").HasAnnotation("MySql:IndexPrefixLength", new[] { 768 });

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Camera)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("camera");
                entity.Property(e => e.PosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_x");
                entity.Property(e => e.PosY)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_y");
                entity.Property(e => e.PosZ)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_z");
            });

            modelBuilder.Entity<SingleModeCookMaterialRate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_material_rate");

                entity.HasIndex(e => new { e.MaterialCount, e.BoostType }, "single_mode_cook_material_rate_0_material_count_1_boost_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BoostType)
                    .HasColumnType("int(11)")
                    .HasColumnName("boost_type");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.MaterialCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_count");
                entity.Property(e => e.MaterialQuantityRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("material_quantity_rate");
            });

            modelBuilder.Entity<SingleModeCookMessage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_message");

                entity.HasIndex(e => e.ViewType, "single_mode_cook_message_0_view_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_flag");
                entity.Property(e => e.ViewType)
                    .HasColumnType("int(11)")
                    .HasColumnName("view_type");
            });

            modelBuilder.Entity<SingleModeCookMotionGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_motion_group");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgMotionId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_motion_id_1");
                entity.Property(e => e.BgMotionId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_motion_id_2");
                entity.Property(e => e.BgMotionId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_motion_id_3");
                entity.Property(e => e.BgSwapMotionBlend11)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_blend_1_1");
                entity.Property(e => e.BgSwapMotionBlend12)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_blend_1_2");
                entity.Property(e => e.BgSwapMotionBlend21)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_blend_2_1");
                entity.Property(e => e.BgSwapMotionBlend22)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_blend_2_2");
                entity.Property(e => e.BgSwapMotionBlend31)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_blend_3_1");
                entity.Property(e => e.BgSwapMotionBlend32)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_blend_3_2");
                entity.Property(e => e.BgSwapMotionId11)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_id_1_1");
                entity.Property(e => e.BgSwapMotionId12)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_id_1_2");
                entity.Property(e => e.BgSwapMotionId21)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_id_2_1");
                entity.Property(e => e.BgSwapMotionId22)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_id_2_2");
                entity.Property(e => e.BgSwapMotionId31)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_id_3_1");
                entity.Property(e => e.BgSwapMotionId32)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_id_3_2");
                entity.Property(e => e.BgSwapMotionSpeed11)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_speed_1_1");
                entity.Property(e => e.BgSwapMotionSpeed12)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_swap_motion_speed_1_2");
            });

            modelBuilder.Entity<SingleModeCookMotionStatus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_motion_status");

                entity.HasIndex(e => new { e.TurnProgress, e.GardenProgress }, "single_mode_cook_motion_status_0_turn_progress_1_garden_progress");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GardenProgress)
                    .HasColumnType("int(11)")
                    .HasColumnName("garden_progress");
                entity.Property(e => e.MotionId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id_1");
                entity.Property(e => e.MotionId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id_2");
                entity.Property(e => e.TurnProgress)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_progress");
            });

            modelBuilder.Entity<SingleModeCookPowerData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_power_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CookType)
                    .HasColumnType("int(11)")
                    .HasColumnName("cook_type");
                entity.Property(e => e.GardenLv)
                    .HasColumnType("int(11)")
                    .HasColumnName("garden_lv");
                entity.Property(e => e.GreatSuccessNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("great_success_num");
                entity.Property(e => e.SuccessNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_num");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });

            modelBuilder.Entity<SingleModeCookStandMotion>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_stand_motion");

                entity.HasIndex(e => e.Type, "single_mode_cook_stand_motion_0_type");

                entity.HasIndex(e => new { e.Type, e.CharaId }, "single_mode_cook_stand_motion_0_type_1_chara_id");

                entity.HasIndex(e => new { e.Type, e.CharaId, e.ConditionType }, "single_mode_cook_stand_motion_0_type_1_chara_id_2_condition_type");

                entity.HasIndex(e => new { e.Type, e.ConditionType }, "single_mode_cook_stand_motion_0_type_1_condition_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.MiniCharaMotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_chara_motion_id");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SingleModeCookSuccessEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_success_effect");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<SingleModeCookSuccessOdd>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_success_odds");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.PowerMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("power_max");
                entity.Property(e => e.PowerMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("power_min");
                entity.Property(e => e.SuccessRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_rate");
            });

            modelBuilder.Entity<SingleModeCookSuccessType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_cook_success_type");

                entity.HasIndex(e => e.SuccessMotionId, "single_mode_cook_success_type_0_success_motion_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SuccessEffectName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("success_effect_name");
                entity.Property(e => e.SuccessEffectPosition)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_effect_position");
                entity.Property(e => e.SuccessEffectSwap1Name)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("success_effect_swap1_name");
                entity.Property(e => e.SuccessEffectSwap2Name)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("success_effect_swap2_name");
                entity.Property(e => e.SuccessMotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_motion_id");
                entity.Property(e => e.SuccessMotionSwap1Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_motion_swap1_id");
                entity.Property(e => e.SuccessMotionSwap2Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_motion_swap2_id");
            });

            modelBuilder.Entity<SingleModeDifficultyBox>(entity =>
            {
                entity.HasKey(e => new { e.RewardSetId, e.BoxStep })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("single_mode_difficulty_box");

                entity.HasIndex(e => e.BoxId, "single_mode_difficulty_box_0_box_id");

                entity.HasIndex(e => e.BoxStep, "single_mode_difficulty_box_0_box_step");

                entity.HasIndex(e => e.RewardSetId, "single_mode_difficulty_box_0_reward_set_id");

                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
                entity.Property(e => e.BoxStep)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_step");
                entity.Property(e => e.BoxId)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_id");
                entity.Property(e => e.BoxOpenCondition)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_open_condition");
                entity.Property(e => e.BoxType)
                    .HasColumnType("int(11)")
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
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_difficulty_box_gauge");

                entity.HasIndex(e => e.DifficultyId, "single_mode_difficulty_box_gauge_0_difficulty_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddConditionMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_condition_max");
                entity.Property(e => e.AddConditionMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_condition_min");
                entity.Property(e => e.AddConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_condition_type");
                entity.Property(e => e.DifficultyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty_id");
                entity.Property(e => e.GaugeRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_rate");
                entity.Property(e => e.ResultMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_max");
                entity.Property(e => e.ResultMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_min");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeDifficultyBoxReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_difficulty_box_reward");

                entity.HasIndex(e => e.BoxId, "single_mode_difficulty_box_reward_0_box_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BoxId)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_id");
                entity.Property(e => e.BoxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_num");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.PrizeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_type");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<SingleModeDifficultyData>(entity =>
            {
                entity.HasKey(e => new { e.DifficultyId, e.Difficulty })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("single_mode_difficulty_data");

                entity.HasIndex(e => new { e.DifficultyId, e.DifficultyIndex }, "single_mode_difficulty_data_0_difficulty_id_1_difficulty_index");

                entity.Property(e => e.DifficultyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty_id");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.AdditionSkill)
                    .HasColumnType("int(11)")
                    .HasColumnName("addition_skill");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.ConditionValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ContinueFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("continue_flag");
                entity.Property(e => e.DescriptionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("description_id");
                entity.Property(e => e.DifficultyIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty_index");
                entity.Property(e => e.DifficultyMotivation)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty_motivation");
                entity.Property(e => e.DifficultyRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty_rate");
                entity.Property(e => e.FirstClearItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("firstclear_item_category");
                entity.Property(e => e.FirstClearItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("firstclear_item_id");
                entity.Property(e => e.FirstClearNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("firstclear_num");
                entity.Property(e => e.GaugeRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_rate");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.MaxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_num");
                entity.Property(e => e.ResultType)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_type");
                entity.Property(e => e.SpecialFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_flag");
            });

            modelBuilder.Entity<SingleModeDifficultyMode>(entity =>
            {
                entity.HasKey(e => e.DifficultyId).HasName("PRIMARY");

                entity.ToTable("single_mode_difficulty_mode");

                entity.Property(e => e.DifficultyId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ConsumeTpBonusRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("consume_tp_bonus_ratio");
                entity.Property(e => e.ConsumeTpRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("consume_tp_ratio");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.FirstClearMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("firstclear_motion");
                entity.Property(e => e.GaugeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_max");
                entity.Property(e => e.GaugeMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_motion");
                entity.Property(e => e.GaugeMotion2)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_motion2");
                entity.Property(e => e.GaugeMotion3)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_motion3");
                entity.Property(e => e.GaugeUp)
                    .HasColumnType("int(11)")
                    .HasColumnName("gauge_up");
                entity.Property(e => e.GuideId)
                    .HasColumnType("int(11)")
                    .HasColumnName("guide_id");
                entity.Property(e => e.InMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("in_motion");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.MaxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_num");
                entity.Property(e => e.PlayMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("play_motion");
                entity.Property(e => e.PopoutMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("popout_motion");
                entity.Property(e => e.PrizeMotion1)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_motion1");
                entity.Property(e => e.PrizeMotion2)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_motion2");
                entity.Property(e => e.PrizeMotion3)
                    .HasColumnType("int(11)")
                    .HasColumnName("prize_motion3");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
                entity.Property(e => e.RewardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_type");
                entity.Property(e => e.StandMotion)
                    .HasColumnType("int(11)")
                    .HasColumnName("stand_motion");
            });

            modelBuilder.Entity<SingleModeEvaluation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_evaluation");

                entity.HasIndex(e => e.CharaId, "single_mode_evaluation_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Evaluation)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_motion_set_id");
            });

            modelBuilder.Entity<SingleModeEventItemDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_event_item_detail");

                entity.HasIndex(e => new { e.EventCategoryId, e.ItemId }, "single_mode_event_item_detail_0_event_category_id_1_item_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EventCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_category_id");
                entity.Property(e => e.IsSpecial)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_special");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.NameIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("name_index");
            });

            modelBuilder.Entity<SingleModeEventProduction>(entity =>
            {
                entity.HasKey(e => e.StoryId).HasName("PRIMARY");

                entity.ToTable("single_mode_event_production");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
                entity.Property(e => e.EventCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_category_id");
                entity.Property(e => e.ItemDir)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_dir");
                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_name");
                entity.Property(e => e.MaxItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_item_id");
            });

            modelBuilder.Entity<SingleModeFanCount>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_fan_count");

                entity.HasIndex(e => e.FanSetId, "single_mode_fan_count_0_fan_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.FanCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_count");
                entity.Property(e => e.FanSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_set_id");
                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");
            });

            modelBuilder.Entity<SingleModeFreeCoinRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_free_coin_race");

                entity.HasIndex(e => e.Grade, "single_mode_free_coin_race_0_grade");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CoinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("coin_num");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
                entity.Property(e => e.OrderMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_max");
                entity.Property(e => e.OrderMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_min");
            });

            modelBuilder.Entity<SingleModeFreeShop>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_free_shop");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_turn");
                entity.Property(e => e.LineupGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("lineup_group_id");
                entity.Property(e => e.MaxLineupNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_lineup_num");
                entity.Property(e => e.StartTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_turn");
            });

            modelBuilder.Entity<SingleModeFreeShopBg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_free_shop_bg");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.EndTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_turn");
                entity.Property(e => e.StartTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_turn");
            });

            modelBuilder.Entity<SingleModeFreeShopEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_free_shop_effect");

                entity.HasIndex(e => e.EffectGroupId, "single_mode_free_shop_effect_0_effect_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeFreeShopItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_free_shop_item");

                entity.HasIndex(e => e.ItemId, "single_mode_free_shop_item_0_item_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CoinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("coin_num");
                entity.Property(e => e.EffectGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EffectPriority)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_priority");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.LimitNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_num");
                entity.Property(e => e.MotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id");
                entity.Property(e => e.UseFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_flag");
            });

            modelBuilder.Entity<SingleModeFreeTrainingPlate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_free_training_plate");

                entity.HasIndex(e => e.ConditionType, "single_mode_free_training_plate_0_condition_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ValueMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_max");
                entity.Property(e => e.ValueMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_min");
            });

            modelBuilder.Entity<SingleModeFreeWinPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_free_win_point");

                entity.HasIndex(e => e.Grade, "single_mode_free_win_point_0_grade");

                entity.HasIndex(e => e.RaceGroupId, "single_mode_free_win_point_0_race_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
                entity.Property(e => e.OrderMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_max");
                entity.Property(e => e.OrderMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_min");
                entity.Property(e => e.PointNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("point_num");
                entity.Property(e => e.RaceGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_group_id");
            });

            modelBuilder.Entity<SingleModeHideCharaText>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_hide_chara_text");

                entity.HasIndex(e => e.CharacterId, "single_mode_hide_chara_text_0_character_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.VoiceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_id");
            });

            modelBuilder.Entity<SingleModeHintGain>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("single_mode_hint_gain");

                entity.HasIndex(e => e.HintId, "single_mode_hint_gain_0_hint_id");

                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.HintGainType)
                    .HasColumnType("int(11)")
                    .HasColumnName("hint_gain_type");
                entity.Property(e => e.HintGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("hint_group");
                entity.Property(e => e.HintId)
                    .HasColumnType("int(11)")
                    .HasColumnName("hint_id");
                entity.Property(e => e.HintValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("hint_value_1");
                entity.Property(e => e.HintValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("hint_value_2");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SingleModeLiveLiveData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_live_live_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GreatSuccessNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("great_success_num");
                entity.Property(e => e.LiveType)
                    .HasColumnType("int(11)")
                    .HasColumnName("live_type");
                entity.Property(e => e.NormalMusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("normal_music_id");
                entity.Property(e => e.SongNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("song_num");
                entity.Property(e => e.SpecialMusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_music_id");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });

            modelBuilder.Entity<SingleModeLiveMasterBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_live_master_bonus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MasterBonusGainType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_type_1");
                entity.Property(e => e.MasterBonusGainType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_type_2");
                entity.Property(e => e.MasterBonusGainType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_type_3");
                entity.Property(e => e.MasterBonusGainValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_1_1");
                entity.Property(e => e.MasterBonusGainValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_1_2");
                entity.Property(e => e.MasterBonusGainValue13)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_1_3");
                entity.Property(e => e.MasterBonusGainValue14)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_1_4");
                entity.Property(e => e.MasterBonusGainValue21)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_2_1");
                entity.Property(e => e.MasterBonusGainValue22)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_2_2");
                entity.Property(e => e.MasterBonusGainValue23)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_2_3");
                entity.Property(e => e.MasterBonusGainValue24)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_2_4");
                entity.Property(e => e.MasterBonusGainValue31)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_3_1");
                entity.Property(e => e.MasterBonusGainValue32)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_3_2");
                entity.Property(e => e.MasterBonusGainValue33)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_3_3");
                entity.Property(e => e.MasterBonusGainValue34)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_gain_value_3_4");
                entity.Property(e => e.MasterBonusType)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_type");
                entity.Property(e => e.MasterBonusTypeValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_type_value");
            });

            modelBuilder.Entity<SingleModeLiveSongList>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_live_song_list");

                entity.HasIndex(e => e.CommandId, "single_mode_live_song_list_0_command_id");

                entity.HasIndex(e => e.LiveId, "single_mode_live_song_list_0_live_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
                entity.Property(e => e.LiveBonusType)
                    .HasColumnType("int(11)")
                    .HasColumnName("live_bonus_type");
                entity.Property(e => e.LiveBonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("live_bonus_value");
                entity.Property(e => e.LiveId)
                    .HasColumnType("int(11)")
                    .HasColumnName("live_id");
                entity.Property(e => e.MasterBonusContentTextId)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_content_text_id");
            });

            modelBuilder.Entity<SingleModeLiveSquare>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_live_square");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MasterBonusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("master_bonus_id");
                entity.Property(e => e.PerfType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_type_1");
                entity.Property(e => e.PerfType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_type_2");
                entity.Property(e => e.PerfType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_type_3");
                entity.Property(e => e.PerfType4)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_type_4");
                entity.Property(e => e.PerfType5)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_type_5");
                entity.Property(e => e.PerfValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_value_1");
                entity.Property(e => e.PerfValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_value_2");
                entity.Property(e => e.PerfValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_value_3");
                entity.Property(e => e.PerfValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_value_4");
                entity.Property(e => e.PerfValue5)
                    .HasColumnType("int(11)")
                    .HasColumnName("perf_value_5");
                entity.Property(e => e.SquareContentTextId)
                    .HasColumnType("int(11)")
                    .HasColumnName("square_content_text_id");
                entity.Property(e => e.SquareTitleTextId)
                    .HasColumnType("int(11)")
                    .HasColumnName("square_title_text_id");
                entity.Property(e => e.SquareType)
                    .HasColumnType("int(11)")
                    .HasColumnName("square_type");
            });

            modelBuilder.Entity<SingleModeMemberRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_member_rank");

                entity.HasIndex(e => e.MemberRankId, "single_mode_member_rank_0_member_rank_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MemberRankId)
                    .HasColumnType("int(11)")
                    .HasColumnName("member_rank_id");
                entity.Property(e => e.ValueMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_max");
                entity.Property(e => e.ValueMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_min");
            });

            modelBuilder.Entity<SingleModeMemberRankPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_member_rank_points");

                entity.HasIndex(e => e.RankId, "single_mode_member_rank_points_0_rank_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Points)
                    .HasColumnType("int(11)")
                    .HasColumnName("points");
                entity.Property(e => e.RankId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_id");
            });

            modelBuilder.Entity<SingleModeMessage>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_message");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharacterType)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_type");
                entity.Property(e => e.Emergent)
                    .HasColumnType("int(11)")
                    .HasColumnName("emergent");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.StatusType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_type_1");
                entity.Property(e => e.StatusType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_type_2");
                entity.Property(e => e.StatusValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_value_1_1");
                entity.Property(e => e.StatusValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_value_1_2");
                entity.Property(e => e.StatusValue21)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_value_2_1");
                entity.Property(e => e.StatusValue22)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_value_2_2");
            });

            modelBuilder.Entity<SingleModeNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_npc");

                entity.HasIndex(e => e.NpcGroupId, "single_mode_npc_0_npc_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.MotivationMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("motivation_max");
                entity.Property(e => e.MotivationMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("motivation_min");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<SingleModeOuting>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_outing");

                entity.HasIndex(e => e.CommandGroupId, "single_mode_outing_0_command_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id");
                entity.Property(e => e.Condition)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition");
                entity.Property(e => e.IsPlayCutt)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_play_cutt");
            });

            modelBuilder.Entity<SingleModeOutingSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_outing_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandGroupId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id_1");
                entity.Property(e => e.CommandGroupId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id_2");
                entity.Property(e => e.CommandGroupId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id_3");
                entity.Property(e => e.CommandGroupId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id_4");
                entity.Property(e => e.CommandGroupId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_group_id_5");
            });

            modelBuilder.Entity<SingleModePreviewBgm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_preview_bgm");

                entity.HasIndex(e => e.ScenarioId, "single_mode_preview_bgm_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name");
                entity.Property(e => e.CuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cuesheet_name");
                entity.Property(e => e.PreviewOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("preview_order");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeProgram>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_program");

                entity.HasIndex(e => e.Month, "single_mode_program_0_month");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_program_id");
                entity.Property(e => e.EntryDecrease)
                    .HasColumnType("int(11)")
                    .HasColumnName("entry_decrease");
                entity.Property(e => e.EntryDecreaseFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("entry_decrease_flag");
                entity.Property(e => e.FanSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_set_id");
                entity.Property(e => e.FillyOnlyFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("filly_only_flag");
                entity.Property(e => e.GradeRateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade_rate_id");
                entity.Property(e => e.Half)
                    .HasColumnType("int(11)")
                    .HasColumnName("half");
                entity.Property(e => e.Month)
                    .HasColumnType("int(11)")
                    .HasColumnName("month");
                entity.Property(e => e.NeedFanCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_fan_count");
                entity.Property(e => e.ProgramGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("program_group");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.RacePermission)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_permission");
                entity.Property(e => e.RandomGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("random_group_id");
                entity.Property(e => e.RecommendClassId)
                    .HasColumnType("int(11)")
                    .HasColumnName("recommend_class_id");
                entity.Property(e => e.ReserveProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reserve_program_id");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<SingleModeRaceGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_race_group");

                entity.HasIndex(e => e.RaceGroupId, "single_mode_race_group_0_race_group_id");

                entity.HasIndex(e => e.RaceProgramId, "single_mode_race_group_0_race_program_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_group_id");
                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_program_id");
            });

            modelBuilder.Entity<SingleModeRaceLimitReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_race_limit_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.RewardLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_limit");
                entity.Property(e => e.RewardNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_num");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<SingleModeRaceLive>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_race_live");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<SingleModeRaceRestrictTurn>(entity =>
            {
                entity.HasKey(e => new { e.CharaId, e.Turn })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("single_mode_race_restrict_turn");

                entity.HasIndex(e => e.CharaId, "single_mode_race_restrict_turn_0_chara_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
                entity.Property(e => e.GainId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_id");
            });

            modelBuilder.Entity<SingleModeRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MaxValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_value");
                entity.Property(e => e.MinValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_value");
            });

            modelBuilder.Entity<SingleModeRecommend>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_recommend");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GradeLowerLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade_lower_limit");
                entity.Property(e => e.GradeUpperLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade_upper_limit");
            });

            modelBuilder.Entity<SingleModeRecommendSetting>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_recommend_setting");

                entity.HasIndex(e => e.RecommendCourseId, "single_mode_recommend_setting_0_recommend_course_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.HeaderFontColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("header_font_color");
                entity.Property(e => e.RecommendCourseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("recommend_course_id");
            });

            modelBuilder.Entity<SingleModeRestrictSupport>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_restrict_support");

                entity.HasIndex(e => e.ScenarioId, "single_mode_restrict_support_0_scenario_id");

                entity.HasIndex(e => e.SupportCardId, "single_mode_restrict_support_0_support_card_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SingleModeRewardSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_reward_set");

                entity.HasIndex(e => e.RewardSetId, "single_mode_reward_set_0_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Bonus)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.OrderMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_max");
                entity.Property(e => e.OrderMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_min");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
                entity.Property(e => e.RewardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_type");
            });

            modelBuilder.Entity<SingleModeRival>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_rival");

                entity.HasIndex(e => new { e.CharaId, e.Turn, e.RaceProgramId, e.RivalCharaId, e.RivalFlagId, e.SingleModeNpcId }, "chara_id").IsUnique();

                entity.HasIndex(e => e.RaceProgramId, "single_mode_rival_0_race_program_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.FrameOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("frame_order");
                entity.Property(e => e.RaceProgramId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_program_id");
                entity.Property(e => e.RivalCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rival_chara_id");
                entity.Property(e => e.RivalFlagId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rival_flag_id");
                entity.Property(e => e.SingleModeNpcId)
                    .HasColumnType("int(11)")
                    .HasColumnName("single_mode_npc_id");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeRoute>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_route");

                entity.HasIndex(e => e.ScenarioId, "single_mode_route_0_scenario_id");

                entity.HasIndex(e => new { e.ScenarioId, e.CharaId }, "single_mode_route_0_scenario_id_1_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.RaceSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_set_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeRouteAnnounce>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_route_announce");

                entity.HasIndex(e => new { e.RouteRaceType, e.RouteRaceId }, "single_mode_route_announce_0_route_race_type_1_route_race_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RouteRaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("route_race_id");
                entity.Property(e => e.RouteRaceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("route_race_type");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.TargetValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeRouteCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_route_condition");

                entity.HasIndex(e => e.ConditionSetId, "single_mode_route_condition_0_condition_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_set_id");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
            });

            modelBuilder.Entity<SingleModeRouteRace>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_route_race");

                entity.HasIndex(e => e.RaceSetId, "single_mode_route_race_0_race_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.DetermineRace)
                    .HasColumnType("int(11)")
                    .HasColumnName("determine_race");
                entity.Property(e => e.DetermineRaceFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("determine_race_flag");
                entity.Property(e => e.RaceSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_set_id");
                entity.Property(e => e.RaceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_type");
                entity.Property(e => e.ScenarioGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_group_id");
                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<SingleModeScenario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_scenario");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AdditionalIconSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_icon_set_id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgOffsetX)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_offset_x");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.CharaProgramChangeFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_program_change_flag");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.GimmickDiscountRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("gimmick_discount_rate");
                entity.Property(e => e.HintRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("hint_rate");
                entity.Property(e => e.LabelBgColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("label_bg_color");
                entity.Property(e => e.LabelFontColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("label_font_color");
                entity.Property(e => e.MaxGuts)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_guts");
                entity.Property(e => e.MaxPow)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_pow");
                entity.Property(e => e.MaxSpeed)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_speed");
                entity.Property(e => e.MaxStamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_stamina");
                entity.Property(e => e.MaxWiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_wiz");
                entity.Property(e => e.PrologueId)
                    .HasColumnType("int(11)")
                    .HasColumnName("prologue_id");
                entity.Property(e => e.ScenarioImageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_image_id");
                entity.Property(e => e.SecBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sec_bg_id");
                entity.Property(e => e.SecBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sec_bg_sub_id");
                entity.Property(e => e.SkillUpgradeNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_upgrade_num");
                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TurnSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_set_id");
            });

            modelBuilder.Entity<SingleModeScenarioGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_scenario_group");

                entity.HasIndex(e => e.ScenarioId, "single_mode_scenario_group_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeScenarioRecord>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_scenario_record");

                entity.HasIndex(e => e.ScenarioId, "single_mode_scenario_record_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.NeedRecordMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_record_min");
                entity.Property(e => e.RewardItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_category");
                entity.Property(e => e.RewardItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_id");
                entity.Property(e => e.RewardNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_num");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeScenarioUpdate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_scenario_update");

                entity.HasIndex(e => e.ScenarioId, "single_mode_scenario_update_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.PageIndexFrom)
                    .HasColumnType("int(11)")
                    .HasColumnName("page_index_from");
                entity.Property(e => e.PageIndexTo)
                    .HasColumnType("int(11)")
                    .HasColumnName("page_index_to");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TipsGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tips_group_id");
            });

            modelBuilder.Entity<SingleModeScoutChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_scout_chara");

                entity.HasIndex(e => e.CharaId, "single_mode_scout_chara_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.GutsLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts_limit");
                entity.Property(e => e.LiveDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("live_dress_id");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.PowLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow_limit");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.SpeedLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed_limit");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.StaminaLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina_limit");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.TagSupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tag_support_card_id");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
                entity.Property(e => e.WizLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz_limit");
            });

            modelBuilder.Entity<SingleModeSkillNeedPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_skill_need_point");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.NeedSkillPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_skill_point");
                entity.Property(e => e.SolvableType)
                    .HasColumnType("int(11)")
                    .HasColumnName("solvable_type");
                entity.Property(e => e.StatusType)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_type");
                entity.Property(e => e.StatusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_value");
            });

            modelBuilder.Entity<SingleModeSpecialChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_special_chara");

                entity.HasIndex(e => e.ScenarioId, "single_mode_special_chara_0_scenario_id");

                entity.HasIndex(e => new { e.ScenarioId, e.CharaId }, "single_mode_special_chara_0_scenario_id_1_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeSportCompeEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_compe_effect");

                entity.HasIndex(e => e.SportType, "single_mode_sport_compe_effect_0_sport_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
                entity.Property(e => e.MaxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_num");
                entity.Property(e => e.MinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_num");
                entity.Property(e => e.SportType)
                    .HasColumnType("int(11)")
                    .HasColumnName("sport_type");
            });

            modelBuilder.Entity<SingleModeSportCompeSe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_compe_se");

                entity.HasIndex(e => e.SheetId, "single_mode_sport_compe_se_0_sheet_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name");
                entity.Property(e => e.SeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cuesheet_name");
                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasMaxLength(750)
                    .HasColumnName("sheet_id");
            });

            modelBuilder.Entity<SingleModeSportCompetition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_competition");

                entity.HasIndex(e => e.CompeType, "single_mode_sport_competition_0_compe_type");

                entity.HasIndex(e => e.Turn, "single_mode_sport_competition_0_turn");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CompeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("compe_type");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
                entity.Property(e => e.WinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_num");
                entity.Property(e => e.WinSportRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_sport_rank");
            });

            modelBuilder.Entity<SingleModeSportItemEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_item_effect");

                entity.HasIndex(e => e.ItemId, "single_mode_sport_item_effect_0_item_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.MotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id");
            });

            modelBuilder.Entity<SingleModeSportLink>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_link");

                entity.HasIndex(e => e.CommandId, "single_mode_sport_link_0_command_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.TrainingLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_level");
            });

            modelBuilder.Entity<SingleModeSportMob>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_mob");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
            });

            modelBuilder.Entity<SingleModeSportSportType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_sport_type");

                entity.HasIndex(e => e.CommandId, "single_mode_sport_sport_type_0_command_id");

                entity.HasIndex(e => e.SportType, "single_mode_sport_sport_type_0_sport_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.SportType)
                    .HasColumnType("int(11)")
                    .HasColumnName("sport_type");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.TrainingSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_set_id");
            });

            modelBuilder.Entity<SingleModeSportStance>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_stance");

                entity.HasIndex(e => e.SportType, "single_mode_sport_stance_0_sport_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_turn");
                entity.Property(e => e.SportType)
                    .HasColumnType("int(11)")
                    .HasColumnName("sport_type");
                entity.Property(e => e.StanceEffectId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("stance_effect_id_1");
                entity.Property(e => e.StanceEffectId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("stance_effect_id_2");
                entity.Property(e => e.StanceEffectId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("stance_effect_id_3");
                entity.Property(e => e.StanceEffectId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("stance_effect_id_4");
                entity.Property(e => e.StanceEffectId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("stance_effect_id_5");
                entity.Property(e => e.TotalSportRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_sport_rank");
            });

            modelBuilder.Entity<SingleModeSportStanceEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_stance_effect");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
            });

            modelBuilder.Entity<SingleModeSportTrainingCut>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_sport_training_cut");

                entity.HasIndex(e => new { e.CommandId, e.TrainingLevel }, "single_mode_sport_training_cut_0_command_id_1_training_level");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.FailureCutinName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("failure_cutin_name");
                entity.Property(e => e.SuccessCutinName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("success_cutin_name");
                entity.Property(e => e.TrainingLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_level");
            });

            modelBuilder.Entity<SingleModeStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_story_data");

                entity.HasIndex(e => e.CardCharaId, "single_mode_story_data_0_card_chara_id");

                entity.HasIndex(e => e.CardId, "single_mode_story_data_0_card_id");

                entity.HasIndex(e => e.GalleryMainScenario, "single_mode_story_data_0_gallery_main_scenario");

                entity.HasIndex(e => e.ShortStoryId, "single_mode_story_data_0_short_story_id");

                entity.HasIndex(e => e.StoryId, "single_mode_story_data_0_story_id");

                entity.HasIndex(e => e.SupportCardId, "single_mode_story_data_0_support_card_id");

                entity.HasIndex(e => e.SupportCharaId, "single_mode_story_data_0_support_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AvailableGalleryKey)
                    .HasColumnType("int(11)")
                    .HasColumnName("available_gallery_key");
                entity.Property(e => e.CardCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_chara_id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.EndingType)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_type");
                entity.Property(e => e.EventCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_category");
                entity.Property(e => e.EventTitleCharaIcon)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_title_chara_icon");
                entity.Property(e => e.EventTitleDressIcon)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_title_dress_icon");
                entity.Property(e => e.EventTitleStyle)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_title_style");
                entity.Property(e => e.ForceUseRaceDress)
                    .HasColumnType("int(11)")
                    .HasColumnName("force_use_race_dress");
                entity.Property(e => e.GalleryFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("gallery_flag");
                entity.Property(e => e.GalleryListId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gallery_list_id");
                entity.Property(e => e.GalleryMainScenario)
                    .HasColumnType("int(11)")
                    .HasColumnName("gallery_main_scenario");
                entity.Property(e => e.MiniGameResult)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_game_result");
                entity.Property(e => e.PastRaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("past_race_id");
                entity.Property(e => e.PastRaceId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("past_race_id_2");
                entity.Property(e => e.PastRaceId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("past_race_id_3");
                entity.Property(e => e.PastRaceId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("past_race_id_4");
                entity.Property(e => e.RaceEventFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_event_flag");
                entity.Property(e => e.SeChange)
                    .HasColumnType("int(11)")
                    .HasColumnName("se_change");
                entity.Property(e => e.ShortStoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("short_story_id");
                entity.Property(e => e.ShowClear)
                    .HasColumnType("int(11)")
                    .HasColumnName("show_clear");
                entity.Property(e => e.ShowProgress1)
                    .HasColumnType("int(11)")
                    .HasColumnName("show_progress_1");
                entity.Property(e => e.ShowProgress2)
                    .HasColumnType("int(11)")
                    .HasColumnName("show_progress_2");
                entity.Property(e => e.ShowProgress3)
                    .HasColumnType("int(11)")
                    .HasColumnName("show_progress_3");
                entity.Property(e => e.ShowSuccession)
                    .HasColumnType("int(11)")
                    .HasColumnName("show_succession");
                entity.Property(e => e.StoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
                entity.Property(e => e.SupportCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_chara_id");
            });

            modelBuilder.Entity<SingleModeStoryGuide>(entity =>
            {
                entity.HasKey(e => e.StoryId).HasName("PRIMARY");

                entity.ToTable("single_mode_story_guide");

                entity.Property(e => e.StoryId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id");
                entity.Property(e => e.GuideId)
                    .HasColumnType("int(11)")
                    .HasColumnName("guide_id");
            });

            modelBuilder.Entity<SingleModeTagCardPos>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_tag_card_pos");

                entity.HasIndex(e => e.SupportCardId, "single_mode_tag_card_pos_0_support_card_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Pattern)
                    .HasColumnType("int(11)")
                    .HasColumnName("pattern");
                entity.Property(e => e.PosIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_index");
                entity.Property(e => e.PosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_x");
                entity.Property(e => e.PosY)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_y");
                entity.Property(e => e.RotZ)
                    .HasColumnType("int(11)")
                    .HasColumnName("rot_z");
                entity.Property(e => e.ScaleX)
                    .HasColumnType("int(11)")
                    .HasColumnName("scale_x");
                entity.Property(e => e.ScaleY)
                    .HasColumnType("int(11)")
                    .HasColumnName("scale_y");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SingleModeTeamName>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_team_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
            });

            modelBuilder.Entity<SingleModeTeamRaceSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_team_race_set");

                entity.HasIndex(e => e.SuperTeamCharaId, "single_mode_team_race_set_0_super_team_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id");
                entity.Property(e => e.RaceInstanceId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_1");
                entity.Property(e => e.RaceInstanceId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_2");
                entity.Property(e => e.RaceInstanceId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_3");
                entity.Property(e => e.RaceInstanceId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_4");
                entity.Property(e => e.RaceInstanceId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_5");
                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank");
                entity.Property(e => e.StatusCorrection)
                    .HasColumnType("int(11)")
                    .HasColumnName("status_correction");
                entity.Property(e => e.SuperTeamCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("super_team_chara_id");
            });

            modelBuilder.Entity<SingleModeTopBg>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_top_bg");

                entity.HasIndex(e => new { e.Month, e.ScenarioId }, "single_mode_top_bg_0_month_1_scenario_id");

                entity.HasIndex(e => e.ScenarioId, "single_mode_top_bg_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgEffect)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bg_effect");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgProgress)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_progress");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheet)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.HalfType)
                    .HasColumnType("int(11)")
                    .HasColumnName("half_type");
                entity.Property(e => e.MaxPlacement)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_placement");
                entity.Property(e => e.Month)
                    .HasColumnType("int(11)")
                    .HasColumnName("month");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeTopBgChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_top_bg_chara");

                entity.HasIndex(e => new { e.BgId, e.ScenarioId }, "single_mode_top_bg_chara_0_bg_id_1_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.MotionSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_set_id");
                entity.Property(e => e.PosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_x");
                entity.Property(e => e.PosZ)
                    .HasColumnType("int(11)")
                    .HasColumnName("pos_z");
                entity.Property(e => e.RotationY)
                    .HasColumnType("int(11)")
                    .HasColumnName("rotation_y");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeTraining>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_training");

                entity.HasIndex(e => e.CommandId, "single_mode_training_0_command_id");

                entity.HasIndex(e => new { e.CommandId, e.CommandLevel }, "single_mode_training_0_command_id_1_command_level").IsUnique();

                entity.HasIndex(e => e.CommandType, "single_mode_training_0_command_type");

                entity.HasIndex(e => e.CutinFileId, "single_mode_training_0_cutin_file_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseCommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_command_id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.CommandLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_level");
                entity.Property(e => e.CommandType)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_type");
                entity.Property(e => e.CutinFileId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cutin_file_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.DressType)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_type");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.FailureRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("failure_rate");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.MaxCharaNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_chara_num");
                entity.Property(e => e.MenuBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_id");
                entity.Property(e => e.MenuBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_sub_id");
                entity.Property(e => e.MotionSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_set");
                entity.Property(e => e.SaboriType)
                    .HasColumnType("int(11)")
                    .HasColumnName("sabori_type");
            });

            modelBuilder.Entity<SingleModeTrainingBgChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_training_bg_chara");

                entity.HasIndex(e => new { e.CommandId, e.CommandLevel }, "single_mode_training_bg_chara_0_command_id_1_command_level");

                entity.HasIndex(e => e.ScenarioId, "single_mode_training_bg_chara_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.CommandLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_level");
                entity.Property(e => e.CutId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cut_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
            });

            modelBuilder.Entity<SingleModeTrainingEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_training_effect");

                entity.HasIndex(e => new { e.CommandId, e.ResultState }, "single_mode_training_effect_0_command_id_1_result_state");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.EffectValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value");
                entity.Property(e => e.ResultState)
                    .HasColumnType("int(11)")
                    .HasColumnName("result_state");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.SubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_id");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
            });

            modelBuilder.Entity<SingleModeTrainingPlate>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_training_plate");

                entity.HasIndex(e => e.ScenarioId, "single_mode_training_plate_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.ValueMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_max");
                entity.Property(e => e.ValueMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_min");
            });

            modelBuilder.Entity<SingleModeTrainingSe>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_training_se");

                entity.HasIndex(e => e.SheetId, "single_mode_training_se_0_sheet_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_index");
                entity.Property(e => e.SeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cue_name");
                entity.Property(e => e.SeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_cuesheet_name");
                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasMaxLength(750)
                    .HasColumnName("sheet_id");
                entity.Property(e => e.SkipSeCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skip_se_cue_name");
                entity.Property(e => e.SkipSeCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skip_se_cuesheet_name");
                entity.Property(e => e.VoiceTriggerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("voice_trigger_id");
            });

            modelBuilder.Entity<SingleModeTurn>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_turn");

                entity.HasIndex(e => e.TurnSetId, "single_mode_turn_0_turn_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.BgmUniqueCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_unique_cue_name");
                entity.Property(e => e.BgmUniqueCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_unique_cuesheet_name");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.Half)
                    .HasColumnType("int(11)")
                    .HasColumnName("half");
                entity.Property(e => e.HealthRoomType)
                    .HasColumnType("int(11)")
                    .HasColumnName("health_room_type");
                entity.Property(e => e.Month)
                    .HasColumnType("int(11)")
                    .HasColumnName("month");
                entity.Property(e => e.OutingSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("outing_set_id");
                entity.Property(e => e.Period)
                    .HasColumnType("int(11)")
                    .HasColumnName("period");
                entity.Property(e => e.RaceEntryType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_entry_type");
                entity.Property(e => e.RestType)
                    .HasColumnType("int(11)")
                    .HasColumnName("rest_type");
                entity.Property(e => e.StoryBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_bg_id");
                entity.Property(e => e.StoryBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_bg_sub_id");
                entity.Property(e => e.StoryClothId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_cloth_id");
                entity.Property(e => e.TopBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("top_bg_id");
                entity.Property(e => e.TopClothId)
                    .HasColumnType("int(11)")
                    .HasColumnName("top_cloth_id");
                entity.Property(e => e.TrainingSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_set_id");
                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
                entity.Property(e => e.TurnSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_set_id");
                entity.Property(e => e.UniqueCommand)
                    .HasColumnType("int(11)")
                    .HasColumnName("unique_command");
                entity.Property(e => e.Year)
                    .HasColumnType("int(11)")
                    .HasColumnName("year");
            });

            modelBuilder.Entity<SingleModeUniqueChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_unique_chara");

                entity.HasIndex(e => new { e.PartnerId, e.ScenarioId }, "single_mode_unique_chara_0_partner_id_1_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.GainFlagId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_flag_id");
                entity.Property(e => e.GainRoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("gain_role_id");
                entity.Property(e => e.IsSupportFeaturedStock)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_support_featured_stock");
                entity.Property(e => e.PartnerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("partner_id");
                entity.Property(e => e.Period)
                    .HasColumnType("int(11)")
                    .HasColumnName("period");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.TrainingPlacement)
                    .HasColumnType("int(11)")
                    .HasColumnName("training_placement");
            });

            modelBuilder.Entity<SingleModeVenusCrystalGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_venus_crystal_group");

                entity.HasIndex(e => e.CharaId, "single_mode_venus_crystal_group_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ActiveEffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("active_effect_group_id");
                entity.Property(e => e.ActiveEffectTurn)
                    .HasColumnType("int(11)")
                    .HasColumnName("active_effect_turn");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.PassiveEffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("passive_effect_group_id");
                entity.Property(e => e.VenusLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("venus_level");
            });

            modelBuilder.Entity<SingleModeVenusSpiritEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_venus_spirit_effect");

                entity.HasIndex(e => e.SpiritEffectGroupId, "single_mode_venus_spirit_effect_0_spirit_effect_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectType)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EffectValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_2");
                entity.Property(e => e.EffectValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_3");
                entity.Property(e => e.EffectValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_4");
                entity.Property(e => e.SpiritEffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("spirit_effect_group_id");
            });

            modelBuilder.Entity<SingleModeVenusSpiritGroup>(entity =>
            {
                entity.HasKey(e => e.SpiritId).HasName("PRIMARY");

                entity.ToTable("single_mode_venus_spirit_group");

                entity.Property(e => e.SpiritId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("spirit_id");
                entity.Property(e => e.BonusGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_group");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.SpiritEffectGroupId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("spirit_effect_group_id_1");
                entity.Property(e => e.SpiritEffectGroupId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("spirit_effect_group_id_2");
                entity.Property(e => e.SpiritEffectGroupId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("spirit_effect_group_id_3");
                entity.Property(e => e.SpiritEffectGroupId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("spirit_effect_group_id_4");
                entity.Property(e => e.SpiritEffectGroupId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("spirit_effect_group_id_5");
            });

            modelBuilder.Entity<SingleModeVenusSpraceData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_venus_sprace_data");

                entity.HasIndex(e => e.RaceGroupId, "single_mode_venus_sprace_data_0_race_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_group_id");
                entity.Property(e => e.TurnNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn_num");
            });

            modelBuilder.Entity<SingleModeWinsSaddle>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("single_mode_wins_saddle");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Condition)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.RaceInstanceId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_1");
                entity.Property(e => e.RaceInstanceId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_2");
                entity.Property(e => e.RaceInstanceId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_3");
                entity.Property(e => e.RaceInstanceId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_4");
                entity.Property(e => e.RaceInstanceId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_5");
                entity.Property(e => e.RaceInstanceId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_6");
                entity.Property(e => e.RaceInstanceId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_7");
                entity.Property(e => e.RaceInstanceId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id_8");
                entity.Property(e => e.WinSaddleType)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_saddle_type");
            });

            modelBuilder.Entity<SkillData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_data");

                entity.HasIndex(e => e.GroupId, "skill_data_0_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AbilityTimeUsage1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_time_usage_1");
                entity.Property(e => e.AbilityTimeUsage2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_time_usage_2");
                entity.Property(e => e.AbilityType11)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_1");
                entity.Property(e => e.AbilityType12)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_2");
                entity.Property(e => e.AbilityType13)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_3");
                entity.Property(e => e.AbilityType21)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_1");
                entity.Property(e => e.AbilityType22)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_2");
                entity.Property(e => e.AbilityType23)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_3");
                entity.Property(e => e.AbilityValueLevelUsage11)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_level_usage_1_1");
                entity.Property(e => e.AbilityValueLevelUsage12)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_level_usage_1_2");
                entity.Property(e => e.AbilityValueLevelUsage13)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_level_usage_1_3");
                entity.Property(e => e.AbilityValueLevelUsage21)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_level_usage_2_1");
                entity.Property(e => e.AbilityValueLevelUsage22)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_level_usage_2_2");
                entity.Property(e => e.AbilityValueLevelUsage23)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_level_usage_2_3");
                entity.Property(e => e.AbilityValueUsage11)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_usage_1_1");
                entity.Property(e => e.AbilityValueUsage12)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_usage_1_2");
                entity.Property(e => e.AbilityValueUsage13)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_usage_1_3");
                entity.Property(e => e.AbilityValueUsage21)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_usage_2_1");
                entity.Property(e => e.AbilityValueUsage22)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_usage_2_2");
                entity.Property(e => e.AbilityValueUsage23)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_value_usage_2_3");
                entity.Property(e => e.ActivateLot)
                    .HasColumnType("int(11)")
                    .HasColumnName("activate_lot");
                entity.Property(e => e.AdditionalActivateType11)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_activate_type_1_1");
                entity.Property(e => e.AdditionalActivateType12)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_activate_type_1_2");
                entity.Property(e => e.AdditionalActivateType13)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_activate_type_1_3");
                entity.Property(e => e.AdditionalActivateType21)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_activate_type_2_1");
                entity.Property(e => e.AdditionalActivateType22)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_activate_type_2_2");
                entity.Property(e => e.AdditionalActivateType23)
                    .HasColumnType("int(11)")
                    .HasColumnName("additional_activate_type_2_3");
                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1");
                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2");
                entity.Property(e => e.DisableCountCondition)
                    .HasColumnType("int(11)")
                    .HasColumnName("disable_count_condition");
                entity.Property(e => e.DisableSinglemode)
                    .HasColumnType("int(11)")
                    .HasColumnName("disable_singlemode");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.ExpType)
                    .HasColumnType("int(11)")
                    .HasColumnName("exp_type");
                entity.Property(e => e.FilterSwitch)
                    .HasColumnType("int(11)")
                    .HasColumnName("filter_switch");
                entity.Property(e => e.FloatAbilityTime1)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_time_1");
                entity.Property(e => e.FloatAbilityTime2)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_time_2");
                entity.Property(e => e.FloatAbilityValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_1");
                entity.Property(e => e.FloatAbilityValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_2");
                entity.Property(e => e.FloatAbilityValue13)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_3");
                entity.Property(e => e.FloatAbilityValue21)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_1");
                entity.Property(e => e.FloatAbilityValue22)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_2");
                entity.Property(e => e.FloatAbilityValue23)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_3");
                entity.Property(e => e.FloatCooldownTime1)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_cooldown_time_1");
                entity.Property(e => e.FloatCooldownTime2)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_cooldown_time_2");
                entity.Property(e => e.GradeValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade_value");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.GroupRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_rate");
                entity.Property(e => e.IconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id");
                entity.Property(e => e.IsGeneralSkill)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_general_skill");
                entity.Property(e => e.PlateType)
                    .HasColumnType("int(11)")
                    .HasColumnName("plate_type");
                entity.Property(e => e.PopularityAddParam1)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_param_1");
                entity.Property(e => e.PopularityAddParam2)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_param_2");
                entity.Property(e => e.PopularityAddValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_value_1");
                entity.Property(e => e.PopularityAddValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_value_2");
                entity.Property(e => e.PotentialPerDefault)
                    .HasColumnType("int(11)")
                    .HasColumnName("potential_per_default");
                entity.Property(e => e.Precondition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("precondition_1");
                entity.Property(e => e.Precondition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("precondition_2");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.SkillCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_category");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tag_id");
                entity.Property(e => e.TargetType11)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type_1_1");
                entity.Property(e => e.TargetType12)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type_1_2");
                entity.Property(e => e.TargetType13)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type_1_3");
                entity.Property(e => e.TargetType21)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type_2_1");
                entity.Property(e => e.TargetType22)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type_2_2");
                entity.Property(e => e.TargetType23)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type_2_3");
                entity.Property(e => e.TargetValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value_1_1");
                entity.Property(e => e.TargetValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value_1_2");
                entity.Property(e => e.TargetValue13)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value_1_3");
                entity.Property(e => e.TargetValue21)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value_2_1");
                entity.Property(e => e.TargetValue22)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value_2_2");
                entity.Property(e => e.TargetValue23)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value_2_3");
                entity.Property(e => e.UniqueSkillId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("unique_skill_id_1");
                entity.Property(e => e.UniqueSkillId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("unique_skill_id_2");
            });

            modelBuilder.Entity<SkillExp>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_exp");

                entity.HasIndex(e => e.Type, "skill_exp_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
                entity.Property(e => e.Scale)
                    .HasColumnType("int(11)")
                    .HasColumnName("scale");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SkillLevelValue>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_level_value");

                entity.HasIndex(e => e.AbilityType, "skill_level_value_0_ability_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AbilityType)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type");
                entity.Property(e => e.FloatAbilityValueCoef)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_coef");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
            });

            modelBuilder.Entity<SkillSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.SkillId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id1");
                entity.Property(e => e.SkillId10)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id10");
                entity.Property(e => e.SkillId11)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id11");
                entity.Property(e => e.SkillId12)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id12");
                entity.Property(e => e.SkillId13)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id13");
                entity.Property(e => e.SkillId14)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id14");
                entity.Property(e => e.SkillId15)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id15");
                entity.Property(e => e.SkillId16)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id16");
                entity.Property(e => e.SkillId17)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id17");
                entity.Property(e => e.SkillId18)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id18");
                entity.Property(e => e.SkillId19)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id19");
                entity.Property(e => e.SkillId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id2");
                entity.Property(e => e.SkillId20)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id20");
                entity.Property(e => e.SkillId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id3");
                entity.Property(e => e.SkillId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id4");
                entity.Property(e => e.SkillId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id5");
                entity.Property(e => e.SkillId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id6");
                entity.Property(e => e.SkillId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id7");
                entity.Property(e => e.SkillId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id8");
                entity.Property(e => e.SkillId9)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id9");
                entity.Property(e => e.SkillLevel1)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level1");
                entity.Property(e => e.SkillLevel10)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level10");
                entity.Property(e => e.SkillLevel11)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level11");
                entity.Property(e => e.SkillLevel12)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level12");
                entity.Property(e => e.SkillLevel13)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level13");
                entity.Property(e => e.SkillLevel14)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level14");
                entity.Property(e => e.SkillLevel15)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level15");
                entity.Property(e => e.SkillLevel16)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level16");
                entity.Property(e => e.SkillLevel17)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level17");
                entity.Property(e => e.SkillLevel18)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level18");
                entity.Property(e => e.SkillLevel19)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level19");
                entity.Property(e => e.SkillLevel2)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level2");
                entity.Property(e => e.SkillLevel20)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level20");
                entity.Property(e => e.SkillLevel3)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level3");
                entity.Property(e => e.SkillLevel4)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level4");
                entity.Property(e => e.SkillLevel5)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level5");
                entity.Property(e => e.SkillLevel6)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level6");
                entity.Property(e => e.SkillLevel7)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level7");
                entity.Property(e => e.SkillLevel8)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level8");
                entity.Property(e => e.SkillLevel9)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_level9");
            });

            modelBuilder.Entity<SkillUpScenarioCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_up_scenario_condition");

                entity.HasIndex(e => e.ScenarioId, "skill_up_scenario_condition_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_id");
                entity.Property(e => e.CountType)
                    .HasColumnType("int(11)")
                    .HasColumnName("count_type");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.SubNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_num");
                entity.Property(e => e.TimingType)
                    .HasColumnType("int(11)")
                    .HasColumnName("timing_type");
            });

            modelBuilder.Entity<SkillUpgradeCondition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_upgrade_condition");

                entity.HasIndex(e => new { e.DescriptionId, e.Num, e.SubNum }, "description_id").IsUnique();

                entity.HasIndex(e => e.DescriptionId, "skill_upgrade_condition_0_description_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CountType)
                    .HasColumnType("int(11)")
                    .HasColumnName("count_type");
                entity.Property(e => e.DescriptionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("description_id");
                entity.Property(e => e.Num)
                    .HasColumnType("int(11)")
                    .HasColumnName("num");
                entity.Property(e => e.SubNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_num");
                entity.Property(e => e.TimingType)
                    .HasColumnType("int(11)")
                    .HasColumnName("timing_type");
                entity.Property(e => e.UpgradeType)
                    .HasColumnType("int(11)")
                    .HasColumnName("upgrade_type");
            });

            modelBuilder.Entity<SkillUpgradeDescription>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_upgrade_description");

                entity.HasIndex(e => new { e.CardId, e.SkillId }, "card_id").IsUnique();

                entity.HasIndex(e => e.CardId, "skill_upgrade_description_0_card_id");

                entity.HasIndex(e => new { e.CardId, e.Rank }, "skill_upgrade_description_0_card_id_1_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.Rank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<SkillUpgradeSpeciality>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("skill_upgrade_speciality");

                entity.HasIndex(e => new { e.ScenarioId, e.SkillId }, "scenario_id").IsUnique();

                entity.HasIndex(e => e.BaseSkillId, "skill_upgrade_speciality_0_base_skill_id");

                entity.HasIndex(e => e.ScenarioId, "skill_upgrade_speciality_0_scenario_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseSkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_skill_id");
                entity.Property(e => e.ScenarioId)
                    .HasColumnType("int(11)")
                    .HasColumnName("scenario_id");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<StoryEventBingoReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_bingo_reward");

                entity.HasIndex(e => e.RewardSetId, "story_event_bingo_reward_0_reward_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.LineNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("line_num");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
            });

            modelBuilder.Entity<StoryEventBonusCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_bonus_card");

                entity.HasIndex(e => e.StoryEventId, "story_event_bonus_card_0_story_event_id");

                entity.HasIndex(e => new { e.StoryEventId, e.CharaId, e.CardId }, "story_event_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.Rarity1)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity_1");
                entity.Property(e => e.Rarity2)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity_2");
                entity.Property(e => e.Rarity3)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity_3");
                entity.Property(e => e.Rarity4)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity_4");
                entity.Property(e => e.Rarity5)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity_5");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventBonusGroupSupportCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_bonus_group_support_card");

                entity.HasIndex(e => e.StoryEventId, "story_event_bonus_group_support_card_0_story_event_id");

                entity.HasIndex(e => e.SupportCardId, "story_event_bonus_group_support_card_0_support_card_id");

                entity.HasIndex(e => new { e.StoryEventId, e.CharaId, e.SupportCardId }, "story_event_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.Limit0)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_0");
                entity.Property(e => e.Limit1)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_1");
                entity.Property(e => e.Limit2)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_2");
                entity.Property(e => e.Limit3)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_3");
                entity.Property(e => e.Limit4)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_4");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<StoryEventBonusSupportCard>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_bonus_support_card");

                entity.HasIndex(e => e.StoryEventId, "story_event_bonus_support_card_0_story_event_id");

                entity.HasIndex(e => new { e.StoryEventId, e.CharaId, e.Rarity, e.SupportCardId }, "story_event_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.Limit0)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_0");
                entity.Property(e => e.Limit1)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_1");
                entity.Property(e => e.Limit2)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_2");
                entity.Property(e => e.Limit3)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_3");
                entity.Property(e => e.Limit4)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_4");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<StoryEventData>(entity =>
            {
                entity.HasKey(e => e.StoryEventId).HasName("PRIMARY");

                entity.ToTable("story_event_data");

                entity.Property(e => e.StoryEventId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
                entity.Property(e => e.AnnounceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("announce_id");
                entity.Property(e => e.BonusRewardRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_reward_ratio");
                entity.Property(e => e.ConsumeTpRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("consume_tp_ratio");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EndingDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_date");
                entity.Property(e => e.MiddleDate01)
                    .HasColumnType("int(11)")
                    .HasColumnName("middle_date_01");
                entity.Property(e => e.MiddleDate02)
                    .HasColumnType("int(11)")
                    .HasColumnName("middle_date_02");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<StoryEventMission>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_mission");

                entity.HasIndex(e => e.StoryEventId, "story_event_mission_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_num");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_3");
                entity.Property(e => e.ConditionValue4)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_4");
                entity.Property(e => e.DateCheckFlg)
                    .HasColumnType("int(11)")
                    .HasColumnName("date_check_flg");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.MissionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mission_type");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StepGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("step_group_id");
                entity.Property(e => e.StepOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("step_order");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
                entity.Property(e => e.TransitionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition_type");
            });

            modelBuilder.Entity<StoryEventMissionTopChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_mission_top_chara");

                entity.HasIndex(e => e.StoryEventId, "story_event_mission_top_chara_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EndingFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_flag");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.MenuBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_id");
                entity.Property(e => e.MenuBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_sub_id");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventNicknameBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_nickname_bonus");

                entity.HasIndex(e => new { e.StoryEventId, e.NicknameRank }, "story_event_id").IsUnique();

                entity.HasIndex(e => e.StoryEventId, "story_event_nickname_bonus_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_point");
                entity.Property(e => e.NicknameRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("nickname_rank");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventPointReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_point_reward");

                entity.HasIndex(e => e.StoryEventId, "story_event_point_reward_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.Point)
                    .HasColumnType("int(11)")
                    .HasColumnName("point");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryEventRouletteBingo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_roulette_bingo");

                entity.HasIndex(e => new { e.RouletteId, e.StoryEventId, e.SheetNum }, "roulette_id").IsUnique();

                entity.HasIndex(e => e.StoryEventId, "story_event_roulette_bingo_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CanLoop)
                    .HasColumnType("int(11)")
                    .HasColumnName("can_loop");
                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.ResetLine)
                    .HasColumnType("int(11)")
                    .HasColumnName("reset_line");
                entity.Property(e => e.RewardSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set_id");
                entity.Property(e => e.RouletteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("roulette_id");
                entity.Property(e => e.RouletteMaxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("roulette_max_num");
                entity.Property(e => e.SheetNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("sheet_num");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
                entity.Property(e => e.UseItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_item_category");
                entity.Property(e => e.UseItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_item_id");
                entity.Property(e => e.UseItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_item_num");
            });

            modelBuilder.Entity<StoryEventStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_story_data");

                entity.HasIndex(e => e.StoryEventId, "story_event_story_data_0_story_event_id");

                entity.HasIndex(e => new { e.StoryEventId, e.EpisodeIndexId }, "story_event_story_data_0_story_event_id_1_episode_index_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_category_1");
                entity.Property(e => e.AddRewardCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_category_2");
                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_id_1");
                entity.Property(e => e.AddRewardId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_id_2");
                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_num_1");
                entity.Property(e => e.AddRewardNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_num_2");
                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index_id");
                entity.Property(e => e.NeedPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_point");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_condition_type");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
                entity.Property(e => e.StoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_1");
                entity.Property(e => e.StoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_2");
                entity.Property(e => e.StoryId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_3");
                entity.Property(e => e.StoryId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_4");
                entity.Property(e => e.StoryId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_5");
                entity.Property(e => e.StoryType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_1");
                entity.Property(e => e.StoryType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_2");
                entity.Property(e => e.StoryType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_3");
                entity.Property(e => e.StoryType4)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_4");
                entity.Property(e => e.StoryType5)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_5");
            });

            modelBuilder.Entity<StoryEventTopChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_event_top_chara");

                entity.HasIndex(e => e.StoryEventId, "story_event_top_chara_0_story_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.EndingFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_flag");
                entity.Property(e => e.EnvCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cue_name");
                entity.Property(e => e.EnvCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("env_cuesheet_name");
                entity.Property(e => e.MaxEpisodeIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_episode_index");
                entity.Property(e => e.MenuBgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_id");
                entity.Property(e => e.MenuBgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_bg_sub_id");
                entity.Property(e => e.MinEpisodeIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_episode_index");
                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");
            });

            modelBuilder.Entity<StoryExtraData>(entity =>
            {
                entity.HasKey(e => e.StoryExtraId).HasName("PRIMARY");

                entity.ToTable("story_extra_data");

                entity.Property(e => e.StoryExtraId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("story_extra_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<StoryExtraMovieData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_extra_movie_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.MoviePath)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("movie_path");
                entity.Property(e => e.Sort)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<StoryExtraStoryData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_extra_story_data");

                entity.HasIndex(e => e.StoryExtraId, "story_extra_story_data_0_story_extra_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddRewardCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_category_1");
                entity.Property(e => e.AddRewardCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_category_2");
                entity.Property(e => e.AddRewardId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_id_1");
                entity.Property(e => e.AddRewardId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_id_2");
                entity.Property(e => e.AddRewardNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_num_1");
                entity.Property(e => e.AddRewardNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_reward_num_2");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index_id");
                entity.Property(e => e.NoticeEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_end_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StoryExtraId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_extra_id");
                entity.Property(e => e.StoryId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_1");
                entity.Property(e => e.StoryId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_2");
                entity.Property(e => e.StoryId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_3");
                entity.Property(e => e.StoryId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_4");
                entity.Property(e => e.StoryId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_id_5");
                entity.Property(e => e.StoryType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_1");
                entity.Property(e => e.StoryType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_2");
                entity.Property(e => e.StoryType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_3");
                entity.Property(e => e.StoryType4)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_4");
                entity.Property(e => e.StoryType5)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_type_5");
            });

            modelBuilder.Entity<StoryHipOffset>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.CharaId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("story_hip_offset");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Offset)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset");
            });

            modelBuilder.Entity<StoryLivePosition>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_live_position");

                entity.HasIndex(e => e.MusicId, "story_live_position_0_music_id");

                entity.HasIndex(e => e.SetId, "story_live_position_0_set_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CharaType)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_type");
                entity.Property(e => e.DressColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_color");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.MusicId)
                    .HasColumnType("int(11)")
                    .HasColumnName("music_id");
                entity.Property(e => e.PositionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("position_id");
                entity.Property(e => e.SecondDressColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("second_dress_color");
                entity.Property(e => e.SecondDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("second_dress_id");
                entity.Property(e => e.SetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("set_id");
                entity.Property(e => e.VocalCharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("vocal_chara_id");
            });

            modelBuilder.Entity<StoryStill>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_still");

                entity.HasIndex(e => e.StillId, "story_still_0_still_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_id");
                entity.Property(e => e.PageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("page_id");
                entity.Property(e => e.StillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("still_id");
            });

            modelBuilder.Entity<StoryWipeDictionary>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("story_wipe_dictionary");

                entity.HasIndex(e => new { e.WipeId, e.SubId }, "story_wipe_dictionary_0_wipe_id_1_sub_id");

                entity.HasIndex(e => new { e.WipeId, e.SubId, e.Type, e.UseMini, e.MiniMotionName }, "wipe_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DefaultLength)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_length");
                entity.Property(e => e.EmotionIcon)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("emotion_icon");
                entity.Property(e => e.EmotionIconEnd)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("emotion_icon_end");
                entity.Property(e => e.EmotionIconStart)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("emotion_icon_start");
                entity.Property(e => e.EmotionLabel)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("emotion_label");
                entity.Property(e => e.EmotionLabelEnd)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("emotion_label_end");
                entity.Property(e => e.EmotionLabelStart)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("emotion_label_start");
                entity.Property(e => e.IgnoreTapLength)
                    .HasColumnType("int(11)")
                    .HasColumnName("ignore_tap_length");
                entity.Property(e => e.MiniMotionEnd)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_end");
                entity.Property(e => e.MiniMotionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mini_motion_name");
                entity.Property(e => e.MiniMotionStart)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_motion_start");
                entity.Property(e => e.MotionRoot)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("motion_root");
                entity.Property(e => e.OffsetLength)
                    .HasColumnType("int(11)")
                    .HasColumnName("offset_length");
                entity.Property(e => e.SeName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("se_name");
                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sheet_name");
                entity.Property(e => e.SubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_id");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
                entity.Property(e => e.UseMini)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_mini");
                entity.Property(e => e.VerticalExtendLength)
                    .HasColumnType("int(11)")
                    .HasColumnName("vertical_extend_length");
                entity.Property(e => e.WipeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("wipe_id");
            });

            modelBuilder.Entity<SubscriptionEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("subscription_effect");

                entity.HasIndex(e => e.TargetType, "subscription_effect_0_target_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_type_1");
                entity.Property(e => e.EffectValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_value_1");
                entity.Property(e => e.EndTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_time");
                entity.Property(e => e.ImageIconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("image_icon_id");
                entity.Property(e => e.StartTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_time");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.TransitionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("transition_type");
                entity.Property(e => e.UserShow)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_show");
            });

            modelBuilder.Entity<SuccessionFactor>(entity =>
            {
                entity.HasKey(e => e.FactorId).HasName("PRIMARY");

                entity.ToTable("succession_factor");

                entity.HasIndex(e => new { e.FactorGroupId, e.Rarity }, "succession_factor_0_factor_group_id_1_rarity").IsUnique();

                entity.Property(e => e.FactorId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_id");
                entity.Property(e => e.EffectGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_group_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.FactorGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_group_id");
                entity.Property(e => e.FactorType)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_type");
                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.SuccessionSearchHidden)
                    .HasColumnType("int(11)")
                    .HasColumnName("succession_search_hidden");
            });

            modelBuilder.Entity<SuccessionFactorEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("succession_factor_effect");

                entity.HasIndex(e => e.FactorGroupId, "succession_factor_effect_0_factor_group_id");

                entity.HasIndex(e => new { e.FactorGroupId, e.EffectId }, "succession_factor_effect_0_factor_group_id_1_effect_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_id");
                entity.Property(e => e.FactorGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_group_id");
                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");
                entity.Property(e => e.Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1");
                entity.Property(e => e.Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_2");
            });

            modelBuilder.Entity<SuccessionInitialFactor>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("succession_initial_factor");

                entity.HasIndex(e => e.FactorType, "succession_initial_factor_0_factor_type");

                entity.HasIndex(e => new { e.FactorType, e.Value1 }, "succession_initial_factor_0_factor_type_1_value_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AddPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_point");
                entity.Property(e => e.FactorType)
                    .HasColumnType("int(11)")
                    .HasColumnName("factor_type");
                entity.Property(e => e.Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1");
                entity.Property(e => e.Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_2");
            });

            modelBuilder.Entity<SuccessionRelation>(entity =>
            {
                entity.HasKey(e => e.RelationType).HasName("PRIMARY");

                entity.ToTable("succession_relation");

                entity.Property(e => e.RelationType)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("relation_type");
                entity.Property(e => e.RelationPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("relation_point");
            });

            modelBuilder.Entity<SuccessionRelationMember>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("succession_relation_member");

                entity.HasIndex(e => e.CharaId, "succession_relation_member_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.RelationType)
                    .HasColumnType("int(11)")
                    .HasColumnName("relation_type");
            });

            modelBuilder.Entity<SuccessionRelationRank>(entity =>
            {
                entity.HasKey(e => e.RelationRank).HasName("PRIMARY");

                entity.ToTable("succession_relation_rank");

                entity.Property(e => e.RelationRank)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("relation_rank");
                entity.Property(e => e.RankValueMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_value_max");
                entity.Property(e => e.RankValueMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("rank_value_min");
            });

            modelBuilder.Entity<SuccessionRental>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("succession_rental");

                entity.HasIndex(e => new { e.RentalRank, e.RentalNum }, "succession_rental_0_rental_rank_1_rental_num");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RentalNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("rental_num");
                entity.Property(e => e.RentalRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("rental_rank");
                entity.Property(e => e.UseValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_value1");
                entity.Property(e => e.UseValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_value2");
            });

            modelBuilder.Entity<SupportCardData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("support_card_data");

                entity.HasIndex(e => e.CharaId, "support_card_data_0_chara_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.CommandType)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_type");
                entity.Property(e => e.DetailPosX)
                    .HasColumnType("int(11)")
                    .HasColumnName("detail_pos_x");
                entity.Property(e => e.DetailPosY)
                    .HasColumnType("int(11)")
                    .HasColumnName("detail_pos_y");
                entity.Property(e => e.DetailRotZ)
                    .HasColumnType("int(11)")
                    .HasColumnName("detail_rot_z");
                entity.Property(e => e.DetailScale)
                    .HasColumnType("int(11)")
                    .HasColumnName("detail_scale");
                entity.Property(e => e.EffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_id");
                entity.Property(e => e.EffectTableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("effect_table_id");
                entity.Property(e => e.ExchangeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("exchange_item_id");
                entity.Property(e => e.OutingMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("outing_max");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.SupportCardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_type");
                entity.Property(e => e.UniqueEffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("unique_effect_id");
            });

            modelBuilder.Entity<SupportCardEffectFilter>(entity =>
            {
                entity.HasKey(e => e.Type).HasName("PRIMARY");

                entity.ToTable("support_card_effect_filter");

                entity.HasIndex(e => e.GroupId, "support_card_effect_filter_0_group_id");

                entity.Property(e => e.Type)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<SupportCardEffectFilterGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId).HasName("PRIMARY");

                entity.ToTable("support_card_effect_filter_group");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
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
                    .HasColumnType("int(11)")
                    .HasColumnName("init");
                entity.Property(e => e.LimitLv10)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv10");
                entity.Property(e => e.LimitLv15)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv15");
                entity.Property(e => e.LimitLv20)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv20");
                entity.Property(e => e.LimitLv25)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv25");
                entity.Property(e => e.LimitLv30)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv30");
                entity.Property(e => e.LimitLv35)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv35");
                entity.Property(e => e.LimitLv40)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv40");
                entity.Property(e => e.LimitLv45)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv45");
                entity.Property(e => e.LimitLv5)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv5");
                entity.Property(e => e.LimitLv50)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_lv50");
            });

            modelBuilder.Entity<SupportCardGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("support_card_group");

                entity.HasIndex(e => e.CharaId, "support_card_group_0_chara_id");

                entity.HasIndex(e => e.SupportCardId, "support_card_group_0_support_card_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.OutingMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("outing_max");
                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");
            });

            modelBuilder.Entity<SupportCardLevel>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("support_card_level");

                entity.HasIndex(e => new { e.Rarity, e.Level }, "rarity").IsUnique();

                entity.HasIndex(e => e.Rarity, "support_card_level_0_rarity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.TotalExp)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_exp");
            });

            modelBuilder.Entity<SupportCardLimit>(entity =>
            {
                entity.HasKey(e => e.Rarity).HasName("PRIMARY");

                entity.ToTable("support_card_limit");

                entity.Property(e => e.Rarity)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
                entity.Property(e => e.Limit0)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_0");
                entity.Property(e => e.Limit1)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_1");
                entity.Property(e => e.Limit2)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_2");
                entity.Property(e => e.Limit3)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_3");
                entity.Property(e => e.Limit4)
                    .HasColumnType("int(11)")
                    .HasColumnName("limit_4");
            });

            modelBuilder.Entity<SupportCardLimitBreak>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("support_card_limit_break");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");
            });

            modelBuilder.Entity<SupportCardTeamScoreBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("support_card_team_score_bonus");

                entity.HasIndex(e => e.Level, "support_card_team_score_bonus_0_level");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .HasColumnName("level");
                entity.Property(e => e.ScoreRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("score_rate");
            });

            modelBuilder.Entity<SupportCardUniqueEffect>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("support_card_unique_effect");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Lv)
                    .HasColumnType("int(11)")
                    .HasColumnName("lv");
                entity.Property(e => e.Type0)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_0");
                entity.Property(e => e.Type1)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_1");
                entity.Property(e => e.Value0)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_0");
                entity.Property(e => e.Value01)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_0_1");
                entity.Property(e => e.Value02)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_0_2");
                entity.Property(e => e.Value03)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_0_3");
                entity.Property(e => e.Value04)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_0_4");
                entity.Property(e => e.Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1");
                entity.Property(e => e.Value11)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1_1");
                entity.Property(e => e.Value12)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1_2");
                entity.Property(e => e.Value13)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1_3");
                entity.Property(e => e.Value14)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1_4");
            });

            modelBuilder.Entity<TeamBuildingCharaCount>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_chara_count");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value");
                entity.Property(e => e.CollectionCharaMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("collection_chara_max");
                entity.Property(e => e.CollectionCharaMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("collection_chara_min");
            });

            modelBuilder.Entity<TeamBuildingCharaGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_chara_group");

                entity.HasIndex(e => e.CharaGroupId, "team_building_chara_group_0_chara_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_group_id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
            });

            modelBuilder.Entity<TeamBuildingCollectionChara>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_collection_chara");

                entity.HasIndex(e => e.CharaId, "team_building_collection_chara_0_chara_id");

                entity.HasIndex(e => e.TeamBuildingEventId, "team_building_collection_chara_0_team_building_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_type_1");
                entity.Property(e => e.BonusType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_type_2");
                entity.Property(e => e.BonusValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value_1");
                entity.Property(e => e.BonusValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value_2");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ConditionType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_1");
                entity.Property(e => e.ConditionType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type_2");
                entity.Property(e => e.TeamBuildingEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_building_event_id");
            });

            modelBuilder.Entity<TeamBuildingCollectionSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_collection_set");

                entity.HasIndex(e => e.TeamBuildingEventId, "team_building_collection_set_0_team_building_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_group_id");
                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");
                entity.Property(e => e.TeamBuildingEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_building_event_id");
            });

            modelBuilder.Entity<TeamBuildingConsecutiveWin>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_consecutive_wins");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_value");
                entity.Property(e => e.ConsecutiveWinsNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("consecutive_wins_num");
            });

            modelBuilder.Entity<TeamBuildingData>(entity =>
            {
                entity.HasKey(e => e.TeamBuildingEventId).HasName("PRIMARY");

                entity.ToTable("team_building_data");

                entity.Property(e => e.TeamBuildingEventId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("team_building_event_id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EndingDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("ending_date");
                entity.Property(e => e.MiddleDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("middle_date");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.RequiredRaceCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("required_race_count");
                entity.Property(e => e.SpecialRaceCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_race_count");
                entity.Property(e => e.StaminaAdd)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina_add");
                entity.Property(e => e.StaminaAddTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("stamina_add_time");
                entity.Property(e => e.StaminaDefault)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina_default");
                entity.Property(e => e.StaminaMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina_max");
                entity.Property(e => e.StartAddScoutPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_add_scout_point");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<TeamBuildingDiscountPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_discount_point");

                entity.HasIndex(e => e.TeamRank, "team_building_discount_point_0_team_rank").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.DiscountValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("discount_value");
                entity.Property(e => e.TeamRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_rank");
            });

            modelBuilder.Entity<TeamBuildingRaceNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_race_npc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<TeamBuildingRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_rank");

                entity.HasIndex(e => e.TeamRank, "team_building_rank_0_team_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
                entity.Property(e => e.TeamMaxValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_max_value");
                entity.Property(e => e.TeamMinValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_min_value");
                entity.Property(e => e.TeamRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_rank");
            });

            modelBuilder.Entity<TeamBuildingRankRewardGroup>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_rank_reward_group");

                entity.HasIndex(e => e.RewardGroupId, "team_building_rank_reward_group_0_reward_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.RewardGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_group_id");
            });

            modelBuilder.Entity<TeamBuildingRetryBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_retry_bonus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_rate");
                entity.Property(e => e.DownRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("down_rate");
                entity.Property(e => e.ResimulateNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("resimulate_num");
                entity.Property(e => e.RetryMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("retry_max");
                entity.Property(e => e.RetryMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("retry_min");
            });

            modelBuilder.Entity<TeamBuildingScoutPoint>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_scout_point");

                entity.HasIndex(e => e.CharaRank, "team_building_scout_point_0_chara_rank").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_rank");
                entity.Property(e => e.ScoutValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("scout_value");
            });

            modelBuilder.Entity<TeamBuildingSpRaceSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_sp_race_schedule");

                entity.HasIndex(e => e.EventId, "team_building_sp_race_schedule_0_event_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.RaceConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_condition_id");
                entity.Property(e => e.SpecialRaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_race_instance_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<TeamBuildingTeamRaceSet>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_team_race_set");

                entity.HasIndex(e => e.NpcGroupId, "team_building_team_race_set_0_npc_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MotionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_id");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
            });

            modelBuilder.Entity<TeamBuildingWinReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_building_win_reward");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.WinLoopNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_loop_num");
            });

            modelBuilder.Entity<TeamStadium>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CalcEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("calc_end_date");
                entity.Property(e => e.CalcEndTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("calc_end_time");
                entity.Property(e => e.CalcStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("calc_start_date");
                entity.Property(e => e.CalcStartTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("calc_start_time");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.IntervalEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("interval_end_date");
                entity.Property(e => e.IntervalEndTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("interval_end_time");
                entity.Property(e => e.IntervalStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("interval_start_date");
                entity.Property(e => e.IntervalStartTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("interval_start_time");
                entity.Property(e => e.RaceEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_end_date");
                entity.Property(e => e.RaceEndTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_end_time");
                entity.Property(e => e.RaceStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_start_date");
                entity.Property(e => e.RaceStartTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_start_time");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<TeamStadiumBgm>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium_bgm");

                entity.HasIndex(e => e.SceneType, "team_stadium_bgm_0_scene_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cue_name");
                entity.Property(e => e.CuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("cuesheet_name");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.SceneType)
                    .HasColumnType("int(11)")
                    .HasColumnName("scene_type");
            });

            modelBuilder.Entity<TeamStadiumClass>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium_class");

                entity.HasIndex(e => e.TeamStadiumId, "team_stadium_class_0_team_stadium_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ClassDownRange)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_down_range");
                entity.Property(e => e.ClassUpRange)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_up_range");
                entity.Property(e => e.TeamClass)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_class");
                entity.Property(e => e.TeamStadiumId)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_stadium_id");
                entity.Property(e => e.UnitMaxNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("unit_max_num");
            });

            modelBuilder.Entity<TeamStadiumClassReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium_class_reward");

                entity.HasIndex(e => new { e.TeamStadiumId, e.ClassRewardType }, "team_stadium_class_reward_0_team_stadium_id_1_class_reward_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ClassRewardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("class_reward_type");
                entity.Property(e => e.DispEndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_end_date");
                entity.Property(e => e.DispStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_start_date");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_3");
                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_4");
                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_5");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_3");
                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_4");
                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_5");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
                entity.Property(e => e.ItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_3");
                entity.Property(e => e.ItemNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_4");
                entity.Property(e => e.ItemNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_5");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TeamClass)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_class");
                entity.Property(e => e.TeamStadiumId)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<TeamStadiumRaceResultMotion>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("team_stadium_race_result_motion");

                entity.HasIndex(e => e.CharacterId, "team_stadium_race_result_motion_0_character_id");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.Draw1)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_1");
                entity.Property(e => e.Draw2)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_2");
                entity.Property(e => e.Draw3)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_3");
                entity.Property(e => e.Draw4)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_4");
                entity.Property(e => e.Draw5)
                    .HasColumnType("int(11)")
                    .HasColumnName("draw_5");
                entity.Property(e => e.Lose1)
                    .HasColumnType("int(11)")
                    .HasColumnName("lose_1");
                entity.Property(e => e.Lose2)
                    .HasColumnType("int(11)")
                    .HasColumnName("lose_2");
                entity.Property(e => e.Lose3)
                    .HasColumnType("int(11)")
                    .HasColumnName("lose_3");
                entity.Property(e => e.Lose4)
                    .HasColumnType("int(11)")
                    .HasColumnName("lose_4");
                entity.Property(e => e.Lose5)
                    .HasColumnType("int(11)")
                    .HasColumnName("lose_5");
                entity.Property(e => e.PositionY)
                    .HasColumnType("int(11)")
                    .HasColumnName("position_y");
                entity.Property(e => e.Win1)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_1");
                entity.Property(e => e.Win2)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_2");
                entity.Property(e => e.Win2PositionY)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_2_position_y");
                entity.Property(e => e.Win3)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_3");
                entity.Property(e => e.Win3PositionY)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_3_position_y");
                entity.Property(e => e.Win4)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_4");
                entity.Property(e => e.Win4PositionY)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_4_position_y");
                entity.Property(e => e.Win5)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_5");
            });

            modelBuilder.Entity<TeamStadiumRank>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.TeamMaxValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_max_value");
                entity.Property(e => e.TeamMinValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_min_value");
                entity.Property(e => e.TeamRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_rank");
                entity.Property(e => e.TeamRankGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_rank_group");
            });

            modelBuilder.Entity<TeamStadiumRawScore>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium_raw_score");

                entity.HasIndex(e => e.ConditionType, "team_stadium_raw_score_0_condition_type");

                entity.HasIndex(e => e.RaceScoreNameId, "team_stadium_raw_score_0_race_score_name_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.RaceScoreNameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_score_name_id");
                entity.Property(e => e.Score)
                    .HasColumnType("int(11)")
                    .HasColumnName("score");
                entity.Property(e => e.SortOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_order");
            });

            modelBuilder.Entity<TeamStadiumScoreBonus>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium_score_bonus");

                entity.HasIndex(e => e.ConditionType, "team_stadium_score_bonus_0_condition_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");
                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");
                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.ScoreRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("score_rate");
            });

            modelBuilder.Entity<TeamStadiumStandMotion>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("team_stadium_stand_motion");

                entity.HasIndex(e => new { e.CharacterId, e.Type }, "team_stadium_stand_motion_0_character_id_1_type");

                entity.Property(e => e.CharacterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("character_id");
                entity.Property(e => e.MotionSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("motion_set");
                entity.Property(e => e.Position)
                    .HasColumnType("int(11)")
                    .HasColumnName("position");
                entity.Property(e => e.PositionX)
                    .HasColumnType("int(11)")
                    .HasColumnName("position_x");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.Rotation)
                    .HasColumnType("int(11)")
                    .HasColumnName("rotation");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<TeamStadiumSupportText>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("team_stadium_support_text");

                entity.HasIndex(e => e.Type, "team_stadium_support_text_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.MaxBonus)
                    .HasColumnType("int(11)")
                    .HasColumnName("max_bonus");
                entity.Property(e => e.MinBonus)
                    .HasColumnType("int(11)")
                    .HasColumnName("min_bonus");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<TimezoneData>(entity =>
            {
                entity.HasKey(e => e.Timezone).HasName("PRIMARY");

                entity.ToTable("timezone_data");

                entity.Property(e => e.Timezone)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("timezone");
                entity.Property(e => e.EndHour)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_hour");
                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");
                entity.Property(e => e.StartHour)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_hour");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("topics");

                entity.HasIndex(e => e.Type, "topics_0_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Index)
                    .HasColumnType("int(11)")
                    .HasColumnName("index");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
                entity.Property(e => e.Value)
                    .HasColumnType("int(11)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TrainedCharaTradeItem>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("trained_chara_trade_item");

                entity.HasIndex(e => e.TrainedCharaRank, "trained_chara_trade_item_0_trained_chara_rank").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.TradeItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("trade_item_category");
                entity.Property(e => e.TradeItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("trade_item_id");
                entity.Property(e => e.TradeItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("trade_item_num");
                entity.Property(e => e.TrainedCharaRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("trained_chara_rank");
            });

            modelBuilder.Entity<TrainingChallengeExam>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_challenge_exam");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ExellentScore)
                    .HasColumnType("int(11)")
                    .HasColumnName("exellent_score");
                entity.Property(e => e.ExellentScoreRewardCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("exellent_score_reward_coin");
                entity.Property(e => e.FeatureType)
                    .HasColumnType("int(11)")
                    .HasColumnName("feature_type");
                entity.Property(e => e.GoodScore)
                    .HasColumnType("int(11)")
                    .HasColumnName("good_score");
                entity.Property(e => e.GoodScoreRewardCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("good_score_reward_coin");
                entity.Property(e => e.GreatScore)
                    .HasColumnType("int(11)")
                    .HasColumnName("great_score");
                entity.Property(e => e.GreatScoreRewardCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("great_score_reward_coin");
                entity.Property(e => e.ItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_1");
                entity.Property(e => e.ItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_2");
                entity.Property(e => e.ItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_3");
                entity.Property(e => e.ItemCategory4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_4");
                entity.Property(e => e.ItemCategory5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category_5");
                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_1");
                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_2");
                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_3");
                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_4");
                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id_5");
                entity.Property(e => e.ItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_1");
                entity.Property(e => e.ItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_2");
                entity.Property(e => e.ItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_3");
                entity.Property(e => e.ItemNum4)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_4");
                entity.Property(e => e.ItemNum5)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num_5");
                entity.Property(e => e.ScoreGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("score_group_id");
            });

            modelBuilder.Entity<TrainingChallengeMaster>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_challenge_master");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusRewardRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_reward_ratio");
                entity.Property(e => e.ConsumeTpRatio)
                    .HasColumnType("int(11)")
                    .HasColumnName("consume_tp_ratio");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.EndResultDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_result_date");
                entity.Property(e => e.ExExamId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ex_exam_id");
                entity.Property(e => e.ExamId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("exam_id_1");
                entity.Property(e => e.ExamId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("exam_id_2");
                entity.Property(e => e.ExamId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("exam_id_3");
                entity.Property(e => e.ExamId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("exam_id_4");
                entity.Property(e => e.ExamId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("exam_id_5");
                entity.Property(e => e.FreeExamId)
                    .HasColumnType("int(11)")
                    .HasColumnName("free_exam_id");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.RentalValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("rental_value");
                entity.Property(e => e.ShopId)
                    .HasColumnType("int(11)")
                    .HasColumnName("shop_id");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.StartResultDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_result_date");
                entity.Property(e => e.TargetMainScenario)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_main_scenario");
            });

            modelBuilder.Entity<TrainingChallengeScore>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_challenge_score");

                entity.HasIndex(e => e.ScoreGroupId, "training_challenge_score_0_score_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BonusScore)
                    .HasColumnType("int(11)")
                    .HasColumnName("bonus_score");
                entity.Property(e => e.Data)
                    .HasColumnType("int(11)")
                    .HasColumnName("data");
                entity.Property(e => e.DispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("disp_order");
                entity.Property(e => e.RewardCoin)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_coin");
                entity.Property(e => e.ScoreGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("score_group_id");
                entity.Property(e => e.ScoreType)
                    .HasColumnType("int(11)")
                    .HasColumnName("score_type");
            });

            modelBuilder.Entity<TrainingCuttCharaData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_cutt_chara_data");

                entity.HasIndex(e => new { e.CommandId, e.SubId }, "training_cutt_chara_data_0_command_id_1_sub_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CharaNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_num");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.PropTarget)
                    .HasColumnType("int(11)")
                    .HasColumnName("prop_target");
                entity.Property(e => e.SelectorLabel)
                    .HasColumnType("int(11)")
                    .HasColumnName("selector_label");
                entity.Property(e => e.SubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_id");
                entity.Property(e => e.TargetListIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_list_index");
                entity.Property(e => e.TargetTimeline)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_timeline");
            });

            modelBuilder.Entity<TrainingCuttData>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("training_cutt_data");

                entity.HasIndex(e => new { e.CommandId, e.SubId }, "training_cutt_data_0_command_id_1_sub_id");

                entity.Property(e => e.CharaNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_num");
                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.CuttIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("cutt_index");
                entity.Property(e => e.SubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_id");
                entity.Property(e => e.SuccessFlg)
                    .HasColumnType("int(11)")
                    .HasColumnName("success_flg");
                entity.Property(e => e.TargetCharaIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_chara_index");
                entity.Property(e => e.TargetValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_value");
            });

            modelBuilder.Entity<TrainingCuttFlash>(entity =>
            {
                entity.HasKey(e => e.CommandId).HasName("PRIMARY");

                entity.ToTable("training_cutt_flash");

                entity.Property(e => e.CommandId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.ControlType)
                    .HasColumnType("int(11)")
                    .HasColumnName("control_type");
                entity.Property(e => e.FileFormat)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("file_format");
                entity.Property(e => e.SubFolder)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("sub_folder");
            });

            modelBuilder.Entity<TrainingCuttGroupData>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("training_cutt_group_data");

                entity.HasIndex(e => new { e.GroupId, e.Order }, "group_id").IsUnique();

                entity.HasIndex(e => e.GroupId, "training_cutt_group_data_0_group_id");

                entity.Property(e => e.CommandId)
                    .HasColumnType("int(11)")
                    .HasColumnName("command_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");
                entity.Property(e => e.SubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sub_id");
            });

            modelBuilder.Entity<TrainingReportInflation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_report_inflation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.PointThreshold)
                    .HasColumnType("int(11)")
                    .HasColumnName("point_threshold");
                entity.Property(e => e.Value)
                    .HasColumnType("int(11)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TrainingReportNormalReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_report_normal_reward");

                entity.HasIndex(e => e.RewardSet, "training_report_normal_reward_0_reward_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BasePoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_point");
                entity.Property(e => e.IsPickup)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_pickup");
                entity.Property(e => e.RewardItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_category");
                entity.Property(e => e.RewardItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_id");
                entity.Property(e => e.RewardItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_num");
                entity.Property(e => e.RewardSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set");
            });

            modelBuilder.Entity<TrainingReportPass>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_report_pass");

                entity.HasIndex(e => e.SeasonId, "training_report_pass_0_season_id").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgImage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bg_image");
                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("end_date");
                entity.Property(e => e.InflationCoef)
                    .HasColumnType("int(11)")
                    .HasColumnName("inflation_coef");
                entity.Property(e => e.JobsTrainingReportPointLimit)
                    .HasColumnType("int(11)")
                    .HasColumnName("jobs_training_report_point_limit");
                entity.Property(e => e.NormalRewardSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("normal_reward_set");
                entity.Property(e => e.ProductMasterId)
                    .HasColumnType("int(11)")
                    .HasColumnName("product_master_id");
                entity.Property(e => e.RemindDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("remind_date");
                entity.Property(e => e.SeasonId)
                    .HasColumnType("int(11)")
                    .HasColumnName("season_id");
                entity.Property(e => e.SpecialRewardSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("special_reward_set");
                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<TrainingReportRatio>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_report_ratio");

                entity.HasIndex(e => e.Type, "training_report_ratio_0_type").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
                entity.Property(e => e.Value)
                    .HasColumnType("int(11)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<TrainingReportSpecialReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("training_report_special_reward");

                entity.HasIndex(e => e.RewardSet, "training_report_special_reward_0_reward_set");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BasePoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_point");
                entity.Property(e => e.IsPickup)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_pickup");
                entity.Property(e => e.RewardItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_category");
                entity.Property(e => e.RewardItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_id");
                entity.Property(e => e.RewardItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_item_num");
                entity.Property(e => e.RewardSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_set");
            });

            modelBuilder.Entity<TransferEventData>(entity =>
            {
                entity.HasKey(e => e.TransferEventId).HasName("PRIMARY");

                entity.ToTable("transfer_event_data");

                entity.Property(e => e.TransferEventId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("transfer_event_id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.ClearTrigger)
                    .HasColumnType("int(11)")
                    .HasColumnName("clear_trigger");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.FinishTrigger)
                    .HasColumnType("int(11)")
                    .HasColumnName("finish_trigger");
                entity.Property(e => e.LogoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("logo_id");
                entity.Property(e => e.PreStartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("pre_start_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TopTrigger)
                    .HasColumnType("int(11)")
                    .HasColumnName("top_trigger");
                entity.Property(e => e.TutorialGuideId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tutorial_guide_id");
            });

            modelBuilder.Entity<TransferEventDetail>(entity =>
            {
                entity.HasKey(e => e.TransferDetailId).HasName("PRIMARY");

                entity.ToTable("transfer_event_detail");

                entity.HasIndex(e => e.TransferEventId, "transfer_event_detail_0_transfer_event_id");

                entity.Property(e => e.TransferDetailId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("transfer_detail_id");
                entity.Property(e => e.Condition1Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_type");
                entity.Property(e => e.Condition1Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value1");
                entity.Property(e => e.Condition1Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value2");
                entity.Property(e => e.Condition2Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_type");
                entity.Property(e => e.Condition2Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value1");
                entity.Property(e => e.Condition2Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value2");
                entity.Property(e => e.Condition3Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_type");
                entity.Property(e => e.Condition3Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value1");
                entity.Property(e => e.Condition3Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value2");
                entity.Property(e => e.Condition4Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_type");
                entity.Property(e => e.Condition4Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value1");
                entity.Property(e => e.Condition4Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value2");
                entity.Property(e => e.Condition5Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_type");
                entity.Property(e => e.Condition5Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value1");
                entity.Property(e => e.Condition5Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value2");
                entity.Property(e => e.CoolTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("cool_time");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.LimitedType)
                    .HasColumnType("int(11)")
                    .HasColumnName("limited_type");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.TrainerType)
                    .HasColumnType("int(11)")
                    .HasColumnName("trainer_type");
                entity.Property(e => e.TransferEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("transfer_event_id");
            });

            modelBuilder.Entity<TransferEventReward>(entity =>
            {
                entity.HasKey(e => e.TransferRewardId).HasName("PRIMARY");

                entity.ToTable("transfer_event_reward");

                entity.HasIndex(e => e.TransferDetailId, "transfer_event_reward_0_transfer_detail_id");

                entity.Property(e => e.TransferRewardId)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("transfer_reward_id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.RewardRank)
                    .HasColumnType("int(11)")
                    .HasColumnName("reward_rank");
                entity.Property(e => e.TransferDetailId)
                    .HasColumnType("int(11)")
                    .HasColumnName("transfer_detail_id");
            });

            modelBuilder.Entity<TransferRotationData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("transfer_rotation_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ScheduleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("schedule_id");
            });

            modelBuilder.Entity<TransferRotationDetail>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("transfer_rotation_detail");

                entity.HasIndex(e => e.RotationId, "transfer_rotation_detail_0_rotation_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Condition1Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_type");
                entity.Property(e => e.Condition1Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value1");
                entity.Property(e => e.Condition1Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition1_value2");
                entity.Property(e => e.Condition2Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_type");
                entity.Property(e => e.Condition2Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value1");
                entity.Property(e => e.Condition2Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition2_value2");
                entity.Property(e => e.Condition3Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_type");
                entity.Property(e => e.Condition3Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value1");
                entity.Property(e => e.Condition3Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition3_value2");
                entity.Property(e => e.Condition4Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_type");
                entity.Property(e => e.Condition4Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value1");
                entity.Property(e => e.Condition4Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition4_value2");
                entity.Property(e => e.Condition5Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_type");
                entity.Property(e => e.Condition5Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value1");
                entity.Property(e => e.Condition5Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition5_value2");
                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.LimitedType)
                    .HasColumnType("int(11)")
                    .HasColumnName("limited_type");
                entity.Property(e => e.RotationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rotation_id");
                entity.Property(e => e.TrainerType)
                    .HasColumnType("int(11)")
                    .HasColumnName("trainer_type");
            });

            modelBuilder.Entity<TransferRotationReward>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("transfer_rotation_reward");

                entity.HasIndex(e => e.RotationId, "transfer_rotation_reward_0_rotation_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");
                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");
                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");
                entity.Property(e => e.Odds)
                    .HasColumnType("int(11)")
                    .HasColumnName("odds");
                entity.Property(e => e.RotationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("rotation_id");
            });

            modelBuilder.Entity<TransferRotationSchedule>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("transfer_rotation_schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BaseDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_date");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.RotationStartDay)
                    .HasColumnType("int(11)")
                    .HasColumnName("rotation_start_day");
                entity.Property(e => e.RotationStartTime)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("rotation_start_time");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<TutorialGuideData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("tutorial_guide_data");

                entity.HasIndex(e => e.GroupId, "tutorial_guide_data_0_group_id");

                entity.HasIndex(e => new { e.GroupId, e.PageIndex }, "tutorial_guide_data_0_group_id_1_page_index").IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.ImageIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("image_index");
                entity.Property(e => e.PageIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("page_index");
            });

            modelBuilder.Entity<UltimateRaceContent>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("ultimate_race_contents");

                entity.HasIndex(e => e.EventId, "ultimate_race_contents_0_event_id");

                entity.HasIndex(e => new { e.EventId, e.GroupId, e.Difficulty }, "ultimate_race_contents_0_event_id_1_group_id_2_difficulty");

                entity.HasIndex(e => e.Id, "ultimate_race_contents_0_id");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("int(11)")
                    .HasColumnName("difficulty");
                entity.Property(e => e.EventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_id");
                entity.Property(e => e.FirstClearItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_1");
                entity.Property(e => e.FirstClearItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_2");
                entity.Property(e => e.FirstClearItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_category_3");
                entity.Property(e => e.FirstClearItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_1");
                entity.Property(e => e.FirstClearItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_2");
                entity.Property(e => e.FirstClearItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_id_3");
                entity.Property(e => e.FirstClearItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_1");
                entity.Property(e => e.FirstClearItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_2");
                entity.Property(e => e.FirstClearItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("first_clear_item_num_3");
                entity.Property(e => e.Ground)
                    .HasColumnType("int(11)")
                    .HasColumnName("ground");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
                entity.Property(e => e.Season)
                    .HasColumnType("int(11)")
                    .HasColumnName("season");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
                entity.Property(e => e.Weather)
                    .HasColumnType("int(11)")
                    .HasColumnName("weather");
            });

            modelBuilder.Entity<UltimateRaceContentsChange>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("ultimate_race_contents_change");

                entity.HasIndex(e => e.RaceInstanceId, "ultimate_race_contents_change_0_race_instance_id");

                entity.Property(e => e.AddClearItemCategory1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_category_1");
                entity.Property(e => e.AddClearItemCategory2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_category_2");
                entity.Property(e => e.AddClearItemCategory3)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_category_3");
                entity.Property(e => e.AddClearItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_id_1");
                entity.Property(e => e.AddClearItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_id_2");
                entity.Property(e => e.AddClearItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_id_3");
                entity.Property(e => e.AddClearItemNum1)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_num_1");
                entity.Property(e => e.AddClearItemNum2)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_num_2");
                entity.Property(e => e.AddClearItemNum3)
                    .HasColumnType("int(11)")
                    .HasColumnName("add_clear_item_num_3");
                entity.Property(e => e.ChangeRaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("change_race_instance_id");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.NpcId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_id");
                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");
            });

            modelBuilder.Entity<UltimateRaceData>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("ultimate_race_data");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BgId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_id");
                entity.Property(e => e.BgSubId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bg_sub_id");
                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cue_name");
                entity.Property(e => e.BgmCuesheetName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("bgm_cuesheet_name");
                entity.Property(e => e.EndDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("end_date");
                entity.Property(e => e.NoticeDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("notice_date");
                entity.Property(e => e.StartDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<UltimateRaceNpc>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("ultimate_race_npc");

                entity.HasIndex(e => e.NpcGroupId, "ultimate_race_npc_0_npc_group_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.CutinFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("cutin_flag");
                entity.Property(e => e.Guts)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts");
                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");
                entity.Property(e => e.NpcGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("npc_group_id");
                entity.Property(e => e.Pow)
                    .HasColumnType("int(11)")
                    .HasColumnName("pow");
                entity.Property(e => e.ProperDistanceLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_long");
                entity.Property(e => e.ProperDistanceMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_middle");
                entity.Property(e => e.ProperDistanceMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_mile");
                entity.Property(e => e.ProperDistanceShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_distance_short");
                entity.Property(e => e.ProperGroundDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_dirt");
                entity.Property(e => e.ProperGroundTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_ground_turf");
                entity.Property(e => e.ProperRunningStyleNige)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_nige");
                entity.Property(e => e.ProperRunningStyleOikomi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_oikomi");
                entity.Property(e => e.ProperRunningStyleSashi)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_sashi");
                entity.Property(e => e.ProperRunningStyleSenko)
                    .HasColumnType("int(11)")
                    .HasColumnName("proper_running_style_senko");
                entity.Property(e => e.RaceDressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_dress_id");
                entity.Property(e => e.ReplaceBossId)
                    .HasColumnType("int(11)")
                    .HasColumnName("replace_boss_id");
                entity.Property(e => e.ReplaceMidBossId)
                    .HasColumnType("int(11)")
                    .HasColumnName("replace_midboss_id");
                entity.Property(e => e.ReplaceNpcId)
                    .HasColumnType("int(11)")
                    .HasColumnName("replace_npc_id");
                entity.Property(e => e.SkillSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id");
                entity.Property(e => e.SkillSetId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id_1");
                entity.Property(e => e.SkillSetId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_set_id_2");
                entity.Property(e => e.Speed)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed");
                entity.Property(e => e.Stamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina");
                entity.Property(e => e.UseReplacing)
                    .HasColumnType("int(11)")
                    .HasColumnName("use_replacing");
                entity.Property(e => e.Wiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("wiz");
            });

            modelBuilder.Entity<UltimateRaceSelectTop>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("ultimate_race_select_top");

                entity.HasIndex(e => e.GroupId, "ultimate_race_select_top_0_group_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");
                entity.Property(e => e.ClearHistoryRaceTitle)
                    .HasColumnType("int(11)")
                    .HasColumnName("clear_history_racetitle");
                entity.Property(e => e.ClearHistoryRaceTitleSub)
                    .HasColumnType("int(11)")
                    .HasColumnName("clear_history_racetitle_sub");
                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");
                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
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

                entity.Property(e => e.CardTitle)
                    .HasColumnType("text")
                    .HasColumnName("card_title");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DefaultRarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_rarity");

                entity.Property(e => e.LimitedChara)
                    .HasColumnType("int(11)")
                    .HasColumnName("limited_chara");

                entity.Property(e => e.TalentGuts)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_guts");

                entity.Property(e => e.TalentPow)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_pow");

                entity.Property(e => e.TalentSpeed)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_speed");

                entity.Property(e => e.TalentStamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_stamina");

                entity.Property(e => e.TalentWiz)
                    .HasColumnType("int(11)")
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

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.CharaName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("chara_name");

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
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DressColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_main");

                entity.Property(e => e.DressColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("dress_color_sub");

                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<BasicGachaDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_gacha_data_info");

                entity.Property(e => e.CardType)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_type");

                entity.Property(e => e.CostSingle)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_single");

                entity.Property(e => e.CostType)
                    .HasColumnType("int(11)")
                    .HasColumnName("cost_type");

                entity.Property(e => e.DailyPayCost)
                    .HasColumnType("int(11)")
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

                entity.Property(e => e.OnlyOnceFlag)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("int(11)")
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

                entity.Property(e => e.ItemExchangeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_id");

                entity.Property(e => e.ItemExchangeTopId)
                    .HasColumnType("int(11)")
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

                entity.Property(e => e.ItemExchangeDispOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_exchange_disp_order");

                entity.Property(e => e.ItemExchangeName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_exchange_name");

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

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<BasicLoginBonusDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_login_bonus_data_info");

                entity.Property(e => e.CountNum)
                    .HasColumnType("int(11)")
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

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<BasicMainStoryDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_main_story_data_info");

                entity.Property(e => e.EpisodeIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index");

                entity.Property(e => e.MainStoryEpisodeTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("main_story_episode_title");

                entity.Property(e => e.MainStoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("main_story_id");

                entity.Property(e => e.PartId)
                    .HasColumnType("int(11)")
                    .HasColumnName("part_id");

                entity.Property(e => e.StoryNumber)
                    .HasColumnType("int(11)")
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

                entity.Property(e => e.MissionType)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_face_model");

                entity.Property(e => e.CharaHairColor)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_hair_color");

                entity.Property(e => e.CharaHairModel)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_hair_model");

                entity.Property(e => e.DressColorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_color_id");

                entity.Property(e => e.DressId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dress_id");

                entity.Property(e => e.MobId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mob_id");

                entity.Property(e => e.MobName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("mob_name");
            });

            modelBuilder.Entity<BasicPieceDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_piece_data_info");

                entity.Property(e => e.CharacterPieceName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("character_piece_name");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.ItemPlaceId)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("race_course_set");

                entity.Property(e => e.RaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_id");

                entity.Property(e => e.RaceName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_name");
            });

            modelBuilder.Entity<BasicRaceInstanceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_race_instance_info");

                entity.Property(e => e.RaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceInstanceName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("race_instance_name");
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
            });

            modelBuilder.Entity<BasicSingleModeCharaGradeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_single_mode_chara_grade_info");

                entity.Property(e => e.NeedFanCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_fan_count");

                entity.Property(e => e.RunNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("run_num");

                entity.Property(e => e.SingleModeCharaGradeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("single_mode_chara_grade_id");

                entity.Property(e => e.SingleModeCharaGradeName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("single_mode_chara_grade_name");

                entity.Property(e => e.WinNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("win_num");
            });

            modelBuilder.Entity<BasicSkillDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_skill_data_info");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_id");

                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_category");

                entity.Property(e => e.SkillDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_desc");

                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_name");
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
            });

            modelBuilder.Entity<BasicStoryEventMissionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_story_event_mission_info");

                entity.Property(e => e.ItemCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_category");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_num");

                entity.Property(e => e.MissionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mission_type");

                entity.Property(e => e.StepGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("step_group_id");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_id");

                entity.Property(e => e.StoryEventMissionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_event_mission_id");

                entity.Property(e => e.StoryEventMissionName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("story_event_mission_name");
            });

            modelBuilder.Entity<BasicStoryEventStoryDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_story_event_story_data_info");

                entity.Property(e => e.EpisodeIndexId)
                    .HasColumnType("int(11)")
                    .HasColumnName("episode_index_id");

                entity.Property(e => e.NeedPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_point");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEventEpisodeTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("story_event_episode_title");

                entity.Property(e => e.StoryEventId)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");

                entity.Property(e => e.SupportCardName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("support_card_name");

                entity.Property(e => e.SupportCardTitle)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("support_card_title");
            });

            modelBuilder.Entity<BasicSupportCardUniqueEffectInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_support_card_unique_effect_info");

                entity.Property(e => e.Lv)
                    .HasColumnType("int(11)")
                    .HasColumnName("lv");

                entity.Property(e => e.ScoreBonusName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("score_bonus_name");

                entity.Property(e => e.SupportCardUniqueEffectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_unique_effect_id");

                entity.Property(e => e.Type0)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_0");

                entity.Property(e => e.Type1)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_1");

                entity.Property(e => e.Value0)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_0");

                entity.Property(e => e.Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("value_1");
            });

            modelBuilder.Entity<BasicTeamStadiumScoreBonusInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_basic_team_stadium_score_bonus_info");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11)")
                    .HasColumnName("priority");

                entity.Property(e => e.ScoreBonusName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("score_bonus_name");

                entity.Property(e => e.ScoreRate)
                    .HasColumnType("int(11)")
                    .HasColumnName("score_rate");

                entity.Property(e => e.TeamStadiumScoreBonusId)
                    .HasColumnType("int(11)")
                    .HasColumnName("team_stadium_score_bonus_id");
            });

            modelBuilder.Entity<CondensedSkillDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_condensed_skill_data_info");

                entity.Property(e => e.AbilityType11)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_1");

                entity.Property(e => e.AbilityType12)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_2");

                entity.Property(e => e.AbilityType13)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_3");

                entity.Property(e => e.AbilityType21)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_1");

                entity.Property(e => e.AbilityType22)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_2");

                entity.Property(e => e.AbilityType23)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_3");

                entity.Property(e => e.CardIds)
                    .HasColumnType("mediumtext")
                    .HasColumnName("card_ids");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2");

                entity.Property(e => e.FloatAbilityTime1)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_time_1");

                entity.Property(e => e.FloatAbilityTime2)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_time_2");

                entity.Property(e => e.FloatAbilityValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_1");

                entity.Property(e => e.FloatAbilityValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_2");

                entity.Property(e => e.FloatAbilityValue13)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_3");

                entity.Property(e => e.FloatAbilityValue21)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_1");

                entity.Property(e => e.FloatAbilityValue22)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_2");

                entity.Property(e => e.FloatAbilityValue23)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_3");

                entity.Property(e => e.GradeValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade_value");

                entity.Property(e => e.IconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id");

                entity.Property(e => e.NeedSkillPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_skill_point");

                entity.Property(e => e.PopularityAddParam1)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_param_1");

                entity.Property(e => e.PopularityAddParam2)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_param_2");

                entity.Property(e => e.PopularityAddValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_value_1");

                entity.Property(e => e.PopularityAddValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_value_2");

                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_category");

                entity.Property(e => e.SkillDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_desc");

                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_name");

                entity.Property(e => e.SupportCardIds)
                    .HasColumnType("mediumtext")
                    .HasColumnName("support_card_ids");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tag_id");
            });

            modelBuilder.Entity<NiceErrorMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_error_messages");

                entity.Property(e => e.ErrorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("error_id");

                entity.Property(e => e.ErrorIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("error_index");

                entity.Property(e => e.ErrorText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("error_text");
            });

            modelBuilder.Entity<NiceCardDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_card_data_info");

                entity.Property(e => e.AptitudeBetweener)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_betweener");

                entity.Property(e => e.AptitudeChaser)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_chaser");

                entity.Property(e => e.AptitudeDirt)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_dirt");

                entity.Property(e => e.AptitudeLeader)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_leader");

                entity.Property(e => e.AptitudeLong)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_long");

                entity.Property(e => e.AptitudeMiddle)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_middle");

                entity.Property(e => e.AptitudeMile)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_mile");

                entity.Property(e => e.AptitudeRunner)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_runner");

                entity.Property(e => e.AptitudeShort)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_short");

                entity.Property(e => e.AptitudeTurf)
                    .HasColumnType("int(11)")
                    .HasColumnName("aptitude_turf");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.DefaultRarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("default_rarity");

                entity.Property(e => e.Guts1)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts1");

                entity.Property(e => e.Guts2)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts2");

                entity.Property(e => e.Guts3)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts3");

                entity.Property(e => e.Guts4)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts4");

                entity.Property(e => e.Guts5)
                    .HasColumnType("int(11)")
                    .HasColumnName("guts5");

                entity.Property(e => e.LimitedChara)
                    .HasColumnType("int(11)")
                    .HasColumnName("limited_chara");

                entity.Property(e => e.Power1)
                    .HasColumnType("int(11)")
                    .HasColumnName("power1");

                entity.Property(e => e.Power2)
                    .HasColumnType("int(11)")
                    .HasColumnName("power2");

                entity.Property(e => e.Power3)
                    .HasColumnType("int(11)")
                    .HasColumnName("power3");

                entity.Property(e => e.Power4)
                    .HasColumnType("int(11)")
                    .HasColumnName("power4");

                entity.Property(e => e.Power5)
                    .HasColumnType("int(11)")
                    .HasColumnName("power5");

                entity.Property(e => e.Speed1)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed1");

                entity.Property(e => e.Speed2)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed2");

                entity.Property(e => e.Speed3)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed3");

                entity.Property(e => e.Speed4)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed4");

                entity.Property(e => e.Speed5)
                    .HasColumnType("int(11)")
                    .HasColumnName("speed5");

                entity.Property(e => e.Stamina1)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina1");

                entity.Property(e => e.Stamina2)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina2");

                entity.Property(e => e.Stamina3)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina3");

                entity.Property(e => e.Stamina4)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina4");

                entity.Property(e => e.Stamina5)
                    .HasColumnType("int(11)")
                    .HasColumnName("stamina5");

                entity.Property(e => e.TalentGuts)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_guts");

                entity.Property(e => e.TalentPow)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_pow");

                entity.Property(e => e.TalentSpeed)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_speed");

                entity.Property(e => e.TalentStamina)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_stamina");

                entity.Property(e => e.TalentWiz)
                    .HasColumnType("int(11)")
                    .HasColumnName("talent_wiz");

                entity.Property(e => e.Wisdom1)
                    .HasColumnType("int(11)")
                    .HasColumnName("wisdom1");

                entity.Property(e => e.Wisdom2)
                    .HasColumnType("int(11)")
                    .HasColumnName("wisdom2");

                entity.Property(e => e.Wisdom3)
                    .HasColumnType("int(11)")
                    .HasColumnName("wisdom3");

                entity.Property(e => e.Wisdom4)
                    .HasColumnType("int(11)")
                    .HasColumnName("wisdom4");

                entity.Property(e => e.Wisdom5)
                    .HasColumnType("int(11)")
                    .HasColumnName("wisdom5");
            });

            modelBuilder.Entity<NiceCharaBioInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_chara_bio_info");

                entity.Property(e => e.AttachmentModelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("attachment_model_id");

                entity.Property(e => e.BirthDay)
                    .HasColumnType("int(11)")
                    .HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth)
                    .HasColumnType("int(11)")
                    .HasColumnName("birth_month");

                entity.Property(e => e.BirthYear)
                    .HasColumnType("int(11)")
                    .HasColumnName("birth_year");

                entity.Property(e => e.Bust)
                    .HasColumnType("int(11)")
                    .HasColumnName("bust");

                entity.Property(e => e.CharaCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_category");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.EarRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("ear_random_time_max");

                entity.Property(e => e.EarRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("ear_random_time_min");

                entity.Property(e => e.Height)
                    .HasColumnType("int(11)")
                    .HasColumnName("height");

                entity.Property(e => e.ImageColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_main");

                entity.Property(e => e.ImageColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_color_sub");

                entity.Property(e => e.MiniMayuShaderType)
                    .HasColumnType("int(11)")
                    .HasColumnName("mini_mayu_shader_type");

                entity.Property(e => e.PersonalDress)
                    .HasColumnType("int(11)")
                    .HasColumnName("personal_dress");

                entity.Property(e => e.RaceRunningType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_running_type");

                entity.Property(e => e.Scale)
                    .HasColumnType("int(11)")
                    .HasColumnName("scale");

                entity.Property(e => e.Sex)
                    .HasColumnType("int(11)")
                    .HasColumnName("sex");

                entity.Property(e => e.Shape)
                    .HasColumnType("int(11)")
                    .HasColumnName("shape");

                entity.Property(e => e.Skin)
                    .HasColumnType("int(11)")
                    .HasColumnName("skin");

                entity.Property(e => e.Socks)
                    .HasColumnType("int(11)")
                    .HasColumnName("socks");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.StoryEarRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_ear_random_time_max");

                entity.Property(e => e.StoryEarRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_ear_random_time_min");

                entity.Property(e => e.StoryTailRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_tail_random_time_max");

                entity.Property(e => e.StoryTailRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("story_tail_random_time_min");

                entity.Property(e => e.TailModelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_model_id");

                entity.Property(e => e.TailRandomTimeMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_random_time_max");

                entity.Property(e => e.TailRandomTimeMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("tail_random_time_min");

                entity.Property(e => e.UiBorderColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_border_color");

                entity.Property(e => e.UiColorMain)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_main");

                entity.Property(e => e.UiColorSub)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_color_sub");

                entity.Property(e => e.UiNameplateColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_1");

                entity.Property(e => e.UiNameplateColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_nameplate_color_2");

                entity.Property(e => e.UiNumColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_1");

                entity.Property(e => e.UiNumColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_num_color_2");

                entity.Property(e => e.UiSpeechColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_1");

                entity.Property(e => e.UiSpeechColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_speech_color_2");

                entity.Property(e => e.UiTrainingColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_1");

                entity.Property(e => e.UiTrainingColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_training_color_2");

                entity.Property(e => e.UiTurnColor)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_turn_color");

                entity.Property(e => e.UiWipeColor1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_1");

                entity.Property(e => e.UiWipeColor2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_2");

                entity.Property(e => e.UiWipeColor3)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("ui_wipe_color_3");

                entity.Property(e => e.UraObjectives)
                    .HasColumnType("int(11)")
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

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("item_name");
            });

            modelBuilder.Entity<NiceObjectivesInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_objectives_info");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_id");

                entity.Property(e => e.ConditionType)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_type");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("condition_value_2");

                entity.Property(e => e.DetermineRace)
                    .HasColumnType("int(11)")
                    .HasColumnName("determine_race");

                entity.Property(e => e.DetermineRaceFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("determine_race_flag");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_set_id");

                entity.Property(e => e.RaceType)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_type");

                entity.Property(e => e.RouteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("route_id");

                entity.Property(e => e.SortId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sort_id");

                entity.Property(e => e.TargetType)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_type");

                entity.Property(e => e.Turn)
                    .HasColumnType("int(11)")
                    .HasColumnName("turn");
            });

            modelBuilder.Entity<NiceRaceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_race_info");

                entity.Property(e => e.Class)
                    .HasColumnType("int(11)")
                    .HasColumnName("class");

                entity.Property(e => e.Course)
                    .HasColumnType("int(11)")
                    .HasColumnName("course");

                entity.Property(e => e.CourseSet)
                    .HasColumnType("int(11)")
                    .HasColumnName("course_set");

                entity.Property(e => e.Direction)
                    .HasColumnType("int(11)")
                    .HasColumnName("direction");

                entity.Property(e => e.Distance)
                    .HasColumnType("int(11)")
                    .HasColumnName("distance");

                entity.Property(e => e.EntryNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("entry_num");

                entity.Property(e => e.FanCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("fan_count");

                entity.Property(e => e.Grade)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade");

                entity.Property(e => e.Group)
                    .HasColumnType("int(11)")
                    .HasColumnName("group");

                entity.Property(e => e.Half)
                    .HasColumnType("int(11)")
                    .HasColumnName("half");

                entity.Property(e => e.Month)
                    .HasColumnType("int(11)")
                    .HasColumnName("month");

                entity.Property(e => e.RaceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_id");

                entity.Property(e => e.RaceInstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_instance_id");

                entity.Property(e => e.RaceTrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("race_track_id");

                entity.Property(e => e.RequiredFans)
                    .HasColumnType("int(11)")
                    .HasColumnName("required_fans");

                entity.Property(e => e.Terrain)
                    .HasColumnType("int(11)")
                    .HasColumnName("terrain");
            });

            modelBuilder.Entity<NiceSkillDataInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_nice_skill_data_info");

                entity.Property(e => e.AbilityType11)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_1");

                entity.Property(e => e.AbilityType12)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_2");

                entity.Property(e => e.AbilityType13)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_1_3");

                entity.Property(e => e.AbilityType21)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_1");

                entity.Property(e => e.AbilityType22)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_2");

                entity.Property(e => e.AbilityType23)
                    .HasColumnType("int(11)")
                    .HasColumnName("ability_type_2_3");

                entity.Property(e => e.CardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("card_id");

                entity.Property(e => e.Condition1)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_1");

                entity.Property(e => e.Condition2)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("condition_2");

                entity.Property(e => e.FloatAbilityTime1)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_time_1");

                entity.Property(e => e.FloatAbilityTime2)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_time_2");

                entity.Property(e => e.FloatAbilityValue11)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_1");

                entity.Property(e => e.FloatAbilityValue12)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_2");

                entity.Property(e => e.FloatAbilityValue13)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_1_3");

                entity.Property(e => e.FloatAbilityValue21)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_1");

                entity.Property(e => e.FloatAbilityValue22)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_2");

                entity.Property(e => e.FloatAbilityValue23)
                    .HasColumnType("int(11)")
                    .HasColumnName("float_ability_value_2_3");

                entity.Property(e => e.GradeValue)
                    .HasColumnType("int(11)")
                    .HasColumnName("grade_value");

                entity.Property(e => e.IconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icon_id");

                entity.Property(e => e.NeedSkillPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("need_skill_point");

                entity.Property(e => e.PopularityAddParam1)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_param_1");

                entity.Property(e => e.PopularityAddParam2)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_param_2");

                entity.Property(e => e.PopularityAddValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_value_1");

                entity.Property(e => e.PopularityAddValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("popularity_add_value_2");

                entity.Property(e => e.Rarity)
                    .HasColumnType("int(11)")
                    .HasColumnName("rarity");

                entity.Property(e => e.SkillCategory)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_category");

                entity.Property(e => e.SkillDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_desc");

                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("skill_id");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("skill_name");

                entity.Property(e => e.SupportCardId)
                    .HasColumnType("int(11)")
                    .HasColumnName("support_card_id");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tag_id");
            });

            modelBuilder.Entity<NiceSuccessionRelationMemberType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_succession_relation_member_types");

                entity.Property(e => e.CharaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("chara_id");

                entity.Property(e => e.RelationPoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("relation_point");

                entity.Property(e => e.RelationType)
                    .HasColumnType("int(11)")
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
                    .HasColumnType("int(11)")
                    .HasColumnName("tutorial_id");

                entity.Property(e => e.TutorialIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("tutorial_index");

                entity.Property(e => e.TutorialText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("tutorial_text");
            });
            #endregion

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

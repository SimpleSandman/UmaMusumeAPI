namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeDifficultyMode
    {
        public int DifficultyId { get; set; }
        public int GuideId { get; set; }
        public int CharaId { get; set; }
        public int DressId { get; set; }
        public int InMotion { get; set; }
        public int StandMotion { get; set; }
        public int PlayMotion { get; set; }
        public int GaugeMotion { get; set; }
        public int GaugeMotion2 { get; set; }
        public int GaugeMotion3 { get; set; }
        public int PopoutMotion { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public int RewardType { get; set; }
        public int RewardSetId { get; set; }
        public int GaugeMax { get; set; }
        public int GaugeUp { get; set; }
        public int ConsumeTpRatio { get; set; }
        public int ConsumeTpBonusRatio { get; set; }
        public int FirstClearMotion { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int MaxNum { get; set; }
        public int PrizeMotion1 { get; set; }
        public int PrizeMotion2 { get; set; }
        public int PrizeMotion3 { get; set; }
    }
}

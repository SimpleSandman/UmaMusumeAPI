namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeDifficultyMode
    {
        public int DifficultyId { get; set; }
        public long GuideId { get; set; }
        public long CharaId { get; set; }
        public long DressId { get; set; }
        public long InMotion { get; set; }
        public long StandMotion { get; set; }
        public long PlayMotion { get; set; }
        public long GaugeMotion { get; set; }
        public long GaugeMotion2 { get; set; }
        public long GaugeMotion3 { get; set; }
        public long PopoutMotion { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public long RewardType { get; set; }
        public long RewardSetId { get; set; }
        public long GaugeMax { get; set; }
        public long GaugeUp { get; set; }
    }
}

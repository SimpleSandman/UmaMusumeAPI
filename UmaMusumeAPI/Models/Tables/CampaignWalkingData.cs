using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignWalkingData
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int WalkingLimit { get; set; }
        public int GaugeMax { get; set; }
        public int GaugeUpSinglemode { get; set; }
        public int GaugeUpTeamstadium { get; set; }
        public int GaugeUpDailyrace { get; set; }
        public int GaugeUpDailylegendrace { get; set; }
        public int GaugeUpLogin { get; set; }
        public int IconIdLocation1 { get; set; }
        public int IconIdLocation2 { get; set; }
        public int IconIdLocation3 { get; set; }
        public int LogoId { get; set; }
        public int MapId { get; set; }
        public int GaugeConsumeNum { get; set; }
        public int SpecialCampaignType { get; set; }
    }
}

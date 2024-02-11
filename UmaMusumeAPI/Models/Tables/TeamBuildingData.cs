using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingData
    {
        public int TeamBuildingEventId { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
        public int StaminaDefault { get; set; }
        public int StaminaMax { get; set; }
        public int StaminaAdd { get; set; }
        public string StaminaAddTime { get; set; }
        public int StartAddScoutPoint { get; set; }
        public int NoticeDate { get; set; }
        public int StartDate { get; set; }
        public int EndingDate { get; set; }
        public int EndDate { get; set; }
        public int MiddleDate { get; set; }
        public int RequiredRaceCount { get; set; }
        public int SpecialRaceCount { get; set; }
    }
}

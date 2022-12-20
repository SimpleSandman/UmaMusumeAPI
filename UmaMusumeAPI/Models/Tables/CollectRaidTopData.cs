using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectRaidTopData
    {
        public int Id { get; set; }
        public int CollectRaidId { get; set; }
        public int CutId { get; set; }
        public int CutSubId { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
        public int SegmentCuttId { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue { get; set; }
    }
}

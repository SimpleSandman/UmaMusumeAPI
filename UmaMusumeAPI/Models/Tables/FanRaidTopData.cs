using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FanRaidTopData
    {
        public int Id { get; set; }
        public int FanRaidId { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

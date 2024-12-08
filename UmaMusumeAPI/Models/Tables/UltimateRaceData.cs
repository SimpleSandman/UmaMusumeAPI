using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class UltimateRaceData
    {
        public int Id { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
        public int NoticeDate { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
    }
}

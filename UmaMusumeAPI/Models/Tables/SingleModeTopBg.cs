using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTopBg
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
        public int ScenarioId { get; set; }
        public int BgProgress { get; set; }
        public string BgEffect { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheet { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
        public int MaxPlacement { get; set; }
    }
}

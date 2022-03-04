using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsBgm
    {
        public int Id { get; set; }
        public int RoundId { get; set; }
        public int SceneType { get; set; }
        public int RaceNumber { get; set; }
        public string CueName { get; set; }
        public string CuesheetName { get; set; }
        public int FirstBgmPattern { get; set; }
        public int SecondBgmPattern { get; set; }
    }
}

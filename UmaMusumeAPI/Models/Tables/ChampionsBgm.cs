namespace UmaMusumeAPI.Models.Tables
{
    public class ChampionsBgm
    {
        public int Id { get; set; }
        public long RoundId { get; set; }
        public long SceneType { get; set; }
        public long RaceNumber { get; set; }
        public string CueName { get; set; }
        public string CuesheetName { get; set; }
        public long FirstBgmPattern { get; set; }
        public long SecondBgmPattern { get; set; }
    }
}

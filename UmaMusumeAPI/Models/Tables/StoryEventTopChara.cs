namespace UmaMusumeAPI.Models.Tables
{
    public class StoryEventTopChara
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long MinEpisodeIndex { get; set; }
        public long MaxEpisodeIndex { get; set; }
        public long EndingFlag { get; set; }
        public long CharacterId { get; set; }
        public long DressId { get; set; }
        public long MenuBgId { get; set; }
        public long MenuBgSubId { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
    }
}

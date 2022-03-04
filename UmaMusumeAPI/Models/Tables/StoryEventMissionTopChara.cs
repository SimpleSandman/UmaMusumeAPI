using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventMissionTopChara
    {
        public int Id { get; set; }
        public int StoryEventId { get; set; }
        public int EndingFlag { get; set; }
        public int CharacterId { get; set; }
        public int DressId { get; set; }
        public int MenuBgId { get; set; }
        public int MenuBgSubId { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public string EnvCueName { get; set; }
        public string EnvCuesheetName { get; set; }
    }
}

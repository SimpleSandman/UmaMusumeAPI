using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectRaidMissionTopChara
    {
        public int Id { get; set; }
        public int MissionTopCharaGroupId { get; set; }
        public int EndingFlag { get; set; }
        public int CharaId { get; set; }
        public int DressId { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
    }
}

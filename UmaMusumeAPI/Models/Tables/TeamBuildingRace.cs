using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingRace
    {
        public int Id { get; set; }
        public int TeamBuildingEventId { get; set; }
        public int RotationOrder { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
        public int RaceInstanceId { get; set; }
    }
}

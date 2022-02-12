using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeChangeCharaRoute
    {
        public int Id { get; set; }
        public long RouteRaceGroupId { get; set; }
        public long CharaId { get; set; }
        public long RouteRaceId { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRouteAnnounce
    {
        public int Id { get; set; }
        public long RouteRaceType { get; set; }
        public long RouteRaceId { get; set; }
        public long Turn { get; set; }
        public long TargetType { get; set; }
        public long TargetValue { get; set; }
    }
}

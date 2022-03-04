using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRouteAnnounce
    {
        public int Id { get; set; }
        public int RouteRaceType { get; set; }
        public int RouteRaceId { get; set; }
        public int Turn { get; set; }
        public int TargetType { get; set; }
        public int TargetValue { get; set; }
    }
}

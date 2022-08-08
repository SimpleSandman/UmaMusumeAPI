using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceTrack
    {
        public int Id { get; set; }
        public int InitialLaneType { get; set; }
        public int EnableHalfGate { get; set; }
        public int HorseNumGateVariation { get; set; }
        public int TurfVisionType { get; set; }
        public int FootsmokeColorType { get; set; }
        public int Area { get; set; }
        public int GatePanelType { get; set; }
        public int GateLampType { get; set; }
    }
}

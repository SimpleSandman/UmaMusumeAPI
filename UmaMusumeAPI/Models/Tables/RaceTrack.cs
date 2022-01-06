using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceTrack
    {
        public int Id { get; set; }
        public long InitialLaneType { get; set; }
        public long EnableHalfGate { get; set; }
        public long HorseNumGateVariation { get; set; }
        public long TurfVisionType { get; set; }
        public long FootsmokeColorType { get; set; }
    }
}

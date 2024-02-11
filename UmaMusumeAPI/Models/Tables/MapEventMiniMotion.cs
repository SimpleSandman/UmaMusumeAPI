using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MapEventMiniMotion
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int CharaId { get; set; }
        public int DressId { get; set; }
        public int StandMotion { get; set; }
        public int WalkMotion { get; set; }
        public int ArriveMotion { get; set; }
        public int CheckpointMotion { get; set; }
        public int TapMotion { get; set; }
        public int CompleteMotion { get; set; }
    }
}

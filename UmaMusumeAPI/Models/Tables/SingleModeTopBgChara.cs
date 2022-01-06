using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTopBgChara
    {
        public int Id { get; set; }
        public long ScenarioId { get; set; }
        public long BgId { get; set; }
        public long GroupId { get; set; }
        public long PosX { get; set; }
        public long PosZ { get; set; }
        public long RotationY { get; set; }
        public long MotionSetId { get; set; }
    }
}

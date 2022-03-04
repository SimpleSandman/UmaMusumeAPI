using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTopBgChara
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int BgId { get; set; }
        public int GroupId { get; set; }
        public int PosX { get; set; }
        public int PosZ { get; set; }
        public int RotationY { get; set; }
        public int MotionSetId { get; set; }
    }
}

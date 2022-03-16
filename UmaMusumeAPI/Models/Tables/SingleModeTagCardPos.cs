using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTagCardPos
    {
        public int Id { get; set; }
        public int SupportCardId { get; set; }
        public int Pattern { get; set; }
        public int PosIndex { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int ScaleX { get; set; }
        public int ScaleY { get; set; }
        public int RotZ { get; set; }
    }
}

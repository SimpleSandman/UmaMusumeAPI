using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MiniBg
    {
        public int Id { get; set; }
        public int SceneType { get; set; }
        public int ReleaseNum { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public string GridOffsetX { get; set; }
        public string GridOffsetY { get; set; }
        public int DressId { get; set; }
        public string Position { get; set; }
    }
}

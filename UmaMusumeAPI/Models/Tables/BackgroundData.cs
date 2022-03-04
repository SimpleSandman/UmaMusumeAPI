using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class BackgroundData
    {
        public int Id { get; set; }
        public int BgId { get; set; }
        public int BgSub { get; set; }
        public string CueName { get; set; }
        public string SheetName { get; set; }
        public string BusParamSetName { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}

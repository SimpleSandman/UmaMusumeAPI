namespace UmaMusumeAPI.Models.Tables
{
    public partial class BackgroundData
    {
        public int Id { get; set; }
        public long BgId { get; set; }
        public long BgSub { get; set; }
        public string CueName { get; set; }
        public string SheetName { get; set; }
        public string BusParamSetName { get; set; }
        public long PosX { get; set; }
        public long PosY { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
    }
}

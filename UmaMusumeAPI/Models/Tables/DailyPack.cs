namespace UmaMusumeAPI.Models.Tables
{
    public class DailyPack
    {
        public int ShopDataId { get; set; }
        public int PlatformId { get; set; }
        public int Term { get; set; }
        public int RepurchaseDay { get; set; }
        public int GroupId { get; set; }
        public int DailyFreeNum { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}

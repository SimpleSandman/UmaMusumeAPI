namespace UmaMusumeAPI.Models.Tables
{
    public class DailyPack
    {
        public int ShopDataId { get; set; }
        public int PlatformId { get; set; }
        public long Term { get; set; }
        public long RepurchaseDay { get; set; }
        public long GroupId { get; set; }
        public long DailyFreeNum { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}

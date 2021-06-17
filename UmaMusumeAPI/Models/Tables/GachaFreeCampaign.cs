namespace UmaMusumeAPI.Models.Tables
{
    public class GachaFreeCampaign
    {
        public int Id { get; set; }
        public long GachaId { get; set; }
        public long TargetDrawType { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}

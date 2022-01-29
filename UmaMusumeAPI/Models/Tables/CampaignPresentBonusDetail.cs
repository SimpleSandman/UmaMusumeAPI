using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignPresentBonusDetail
    {
        public int Id { get; set; }
        public int CampaignId { get; set; }
        public int CardId { get; set; }
        public int Count { get; set; }
        public int ItemCategory1 { get; set; }
        public int ItemId1 { get; set; }
        public int ItemNum1 { get; set; }
        public int ItemCategory2 { get; set; }
        public int ItemId2 { get; set; }
        public int ItemNum2 { get; set; }
    }
}

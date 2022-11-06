using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignWalkingRewardSet
    {
        public int Id { get; set; }
        public int RewardSetId { get; set; }
        public int LimitNum { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}

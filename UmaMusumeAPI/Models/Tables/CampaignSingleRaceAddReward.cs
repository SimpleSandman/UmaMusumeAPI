using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CampaignSingleRaceAddReward
    {
        public int Id { get; set; }
        public int RaceAdditionalRewardId { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int RewardType { get; set; }
        public int RewardValue { get; set; }
        public int RewardRate { get; set; }
    }
}

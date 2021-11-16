namespace UmaMusumeAPI.Models.Tables
{
    public class CampaignSingleRaceAddReward
    {
        public int Id { get; set; }
        public long RaceAdditionalRewardId { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long RewardType { get; set; }
        public long RewardValue { get; set; }
        public long RewardRate { get; set; }
    }
}

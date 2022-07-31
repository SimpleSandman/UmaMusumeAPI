using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingBasicReward
    {
        public int Id { get; set; }
        public int RewardValue { get; set; }
        public int TeamRankMin { get; set; }
        public int TeamRankMax { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}

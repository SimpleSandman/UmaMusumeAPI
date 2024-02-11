using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RatingRaceWeekendReward
    {
        public int Id { get; set; }
        public int RatingRaceDataId { get; set; }
        public int RatingRank { get; set; }
        public int WeekendRewardPoint { get; set; }
        public int RewardGroupId { get; set; }
    }
}

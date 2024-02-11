using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RatingRaceRatingRank
    {
        public int Id { get; set; }
        public int RatingRaceDataId { get; set; }
        public int RatingRank { get; set; }
        public int RatingScoreMin { get; set; }
        public int RatingScoreMax { get; set; }
        public int DowngradePermitted { get; set; }
        public int NpcCount { get; set; }
        public int RewardGroupId { get; set; }
    }
}

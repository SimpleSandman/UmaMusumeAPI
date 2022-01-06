using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingChallengeScore
    {
        public int Id { get; set; }
        public long ScoreGroupId { get; set; }
        public long ScoreType { get; set; }
        public long Data { get; set; }
        public long DispOrder { get; set; }
        public long BonusScore { get; set; }
        public long RewardCoin { get; set; }
    }
}

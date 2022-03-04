using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingChallengeScore
    {
        public int Id { get; set; }
        public int ScoreGroupId { get; set; }
        public int ScoreType { get; set; }
        public int Data { get; set; }
        public int DispOrder { get; set; }
        public int BonusScore { get; set; }
        public int RewardCoin { get; set; }
    }
}

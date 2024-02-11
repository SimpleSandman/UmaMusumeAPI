using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TrainingReportNormalReward
    {
        public int Id { get; set; }
        public int RewardSet { get; set; }
        public int IsPickup { get; set; }
        public int BasePoint { get; set; }
        public int RewardItemId { get; set; }
        public int RewardItemCategory { get; set; }
        public int RewardItemNum { get; set; }
    }
}

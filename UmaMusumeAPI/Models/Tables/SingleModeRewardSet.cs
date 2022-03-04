using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRewardSet
    {
        public int Id { get; set; }
        public int RewardSetId { get; set; }
        public int OrderMin { get; set; }
        public int OrderMax { get; set; }
        public int RewardType { get; set; }
        public int Bonus { get; set; }
        public int Odds { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}

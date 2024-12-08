using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRaceLimitReward
    {
        public int Id { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int RewardNum { get; set; }
        public int RewardLimit { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}
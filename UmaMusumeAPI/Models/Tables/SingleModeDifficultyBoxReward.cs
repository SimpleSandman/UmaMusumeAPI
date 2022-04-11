using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeDifficultyBoxReward
    {
        public int Id { get; set; }
        public int BoxId { get; set; }
        public int BoxNum { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
        public int Rate { get; set; }
        public int PrizeType { get; set; }
    }
}

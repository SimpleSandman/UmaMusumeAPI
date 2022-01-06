using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeDifficultyBoxReward
    {
        public int Id { get; set; }
        public long BoxId { get; set; }
        public long BoxNum { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public long Rate { get; set; }
    }
}

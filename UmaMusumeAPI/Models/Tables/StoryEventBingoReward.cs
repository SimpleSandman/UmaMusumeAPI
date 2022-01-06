using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventBingoReward
    {
        public int Id { get; set; }
        public long RewardSetId { get; set; }
        public long LineNum { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}

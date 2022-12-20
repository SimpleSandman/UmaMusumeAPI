using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectRaidAllReward
    {
        public int Id { get; set; }
        public int AllRewardSetId { get; set; }
        public int AllCollectItemNum { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectRaidIndividualReward
    {
        public int Id { get; set; }
        public int IndividualRewardSetId { get; set; }
        public int IndividualCollectItemNum { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}

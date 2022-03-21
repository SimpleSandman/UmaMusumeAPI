using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class FanRaidIndividualReward
    {
        public int Id { get; set; }
        public int FanRaidId { get; set; }
        public int IndividualFan { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}

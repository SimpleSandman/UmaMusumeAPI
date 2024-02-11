using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HeroesSpecialReward
    {
        public int Id { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int ItemCategory { get; set; }
        public int ItemId { get; set; }
        public int ItemNum { get; set; }
    }
}

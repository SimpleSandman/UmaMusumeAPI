using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SubscriptionEffect
    {
        public int Id { get; set; }
        public int TargetType { get; set; }
        public int EffectType1 { get; set; }
        public int EffectValue1 { get; set; }
        public int UserShow { get; set; }
        public int ImageIconId { get; set; }
        public int TransitionType { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}
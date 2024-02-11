using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HeroesGauge
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int GaugeUp { get; set; }
        public int AddTiming { get; set; }
    }
}

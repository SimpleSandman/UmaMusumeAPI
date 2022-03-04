using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SuccessionFactorEffect
    {
        public int Id { get; set; }
        public int FactorGroupId { get; set; }
        public int EffectId { get; set; }
        public int TargetType { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }
}

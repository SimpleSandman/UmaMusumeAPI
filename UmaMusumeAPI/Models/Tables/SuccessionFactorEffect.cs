namespace UmaMusumeAPI.Models.Tables
{
    public partial class SuccessionFactorEffect
    {
        public int Id { get; set; }
        public long FactorGroupId { get; set; }
        public long EffectId { get; set; }
        public long TargetType { get; set; }
        public long Value1 { get; set; }
        public long Value2 { get; set; }
    }
}

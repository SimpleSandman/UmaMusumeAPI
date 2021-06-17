namespace UmaMusumeAPI.Models.Tables
{
    public class SuccessionFactor
    {
        public int FactorId { get; set; }
        public long FactorGroupId { get; set; }
        public long Rarity { get; set; }
        public long Grade { get; set; }
        public long FactorType { get; set; }
        public long EffectGroupId { get; set; }
    }
}

namespace UmaMusumeAPI.Models.Tables
{
    public class SuccessionFactor
    {
        public int FactorId { get; set; }
        public int FactorGroupId { get; set; }
        public int Rarity { get; set; }
        public int Grade { get; set; }
        public int FactorType { get; set; }
        public int EffectGroupId { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int SuccessionSearchHidden { get; set; }
    }
}

namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeHintGain
    {
        public long Id { get; set; }
        public long HintId { get; set; }
        public long SupportCardId { get; set; }
        public long HintGroup { get; set; }
        public long HintGainType { get; set; }
        public long HintValue1 { get; set; }
        public long HintValue2 { get; set; }
    }
}

namespace UmaMusumeAPI.Models.Tables
{
    public partial class HonorData
    {
        public int Id { get; set; }
        public long Rank { get; set; }
        public long Category { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue { get; set; }
        public long ConditionValue2 { get; set; }
        public long StepGroupId { get; set; }
        public long StepOrder { get; set; }
    }
}

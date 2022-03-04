using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HonorData
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public int Category { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue { get; set; }
        public int ConditionValue2 { get; set; }
        public int StepGroupId { get; set; }
        public int StepOrder { get; set; }
    }
}

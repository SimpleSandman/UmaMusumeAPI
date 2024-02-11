using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeAnalyzeCondition
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int ConditionValue3 { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SkillUpScenarioCondition
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int Rank { get; set; }
        public int ConditionId { get; set; }
        public int Num { get; set; }
        public int SubNum { get; set; }
        public int TimingType { get; set; }
        public int CountType { get; set; }
    }
}

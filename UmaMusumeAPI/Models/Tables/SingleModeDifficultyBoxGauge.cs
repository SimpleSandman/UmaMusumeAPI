using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeDifficultyBoxGauge
    {
        public int Id { get; set; }
        public int DifficultyId { get; set; }
        public int ResultMin { get; set; }
        public int ResultMax { get; set; }
        public int GaugeRate { get; set; }
        public int ScenarioId { get; set; }
        public int AddConditionType { get; set; }
        public int AddConditionMin { get; set; }
        public int AddConditionMax { get; set; }
    }
}

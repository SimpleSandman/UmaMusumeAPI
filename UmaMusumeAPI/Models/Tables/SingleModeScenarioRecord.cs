using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeScenarioRecord
    {
        public int Id { get; set; }
        public long ScenarioId { get; set; }
        public long NeedRecordMin { get; set; }
        public long RewardItemCategory { get; set; }
        public long RewardItemId { get; set; }
        public long RewardNum { get; set; }
    }
}

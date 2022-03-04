using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeScenarioRecord
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int NeedRecordMin { get; set; }
        public int RewardItemCategory { get; set; }
        public int RewardItemId { get; set; }
        public int RewardNum { get; set; }
    }
}

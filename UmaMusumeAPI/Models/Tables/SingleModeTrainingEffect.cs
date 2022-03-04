using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTrainingEffect
    {
        public int Id { get; set; }
        public int CommandId { get; set; }
        public int SubId { get; set; }
        public int ResultState { get; set; }
        public int TargetType { get; set; }
        public int EffectValue { get; set; }
        public int ScenarioId { get; set; }
    }
}

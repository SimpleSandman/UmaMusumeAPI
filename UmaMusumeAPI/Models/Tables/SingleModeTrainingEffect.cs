namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeTrainingEffect
    {
        public int Id { get; set; }
        public long CommandId { get; set; }
        public long SubId { get; set; }
        public long ResultState { get; set; }
        public long TargetType { get; set; }
        public long EffectValue { get; set; }
        public long ScenarioId { get; set; }
    }
}

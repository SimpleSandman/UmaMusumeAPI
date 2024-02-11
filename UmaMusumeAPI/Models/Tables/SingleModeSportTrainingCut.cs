using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeSportTrainingCut
    {
        public int Id { get; set; }
        public int CommandId { get; set; }
        public int TrainingLevel { get; set; }
        public string SuccessCutinName { get; set; }
        public string FailureCutinName { get; set; }
    }
}

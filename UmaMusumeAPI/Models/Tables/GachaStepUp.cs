using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class GachaStepUp
    {
        public int Id { get; set; }
        public int StepUpId { get; set; }
        public int TargetGachaId { get; set; }
        public int StepUpStep { get; set; }
    }
}

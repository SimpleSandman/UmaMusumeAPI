using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeTrainingSe
    {
        public int Id { get; set; }
        public string SheetId { get; set; }
        public string SeCueName { get; set; }
        public string SeCuesheetName { get; set; }
        public string SkipSeCueName { get; set; }
        public string SkipSeCuesheetName { get; set; }
        public int CharaIndex { get; set; }
        public int VoiceTriggerId { get; set; }
    }
}

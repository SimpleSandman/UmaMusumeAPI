using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class AnnounceEvent
    {
        public int Id { get; set; }
        public string CueName { get; set; }
        public string CueSheetName { get; set; }
        public int VoiceTextAsset { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

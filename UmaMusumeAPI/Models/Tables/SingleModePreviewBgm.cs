using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModePreviewBgm
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int PreviewOrder { get; set; }
        public string CueName { get; set; }
        public string CuesheetName { get; set; }
    }
}

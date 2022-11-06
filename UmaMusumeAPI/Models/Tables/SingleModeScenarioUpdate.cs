using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeScenarioUpdate
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int TipsGroupId { get; set; }
        public int PageIndexFrom { get; set; }
        public int PageIndexTo { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

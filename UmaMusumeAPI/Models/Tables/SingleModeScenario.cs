using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeScenario
    {
        public int Id { get; set; }
        public long SortId { get; set; }
        public long ScenarioImageId { get; set; }
        public long PrologueId { get; set; }
        public long TurnSetId { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}

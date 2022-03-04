using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRoute
    {
        public int Id { get; set; }
        public int ScenarioId { get; set; }
        public int CharaId { get; set; }
        public int RaceSetId { get; set; }
        public int ConditionSetId { get; set; }
        public int Priority { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRouteRace
    {
        public int Id { get; set; }
        public int RaceSetId { get; set; }
        public int TargetType { get; set; }
        public int SortId { get; set; }
        public int Turn { get; set; }
        public int RaceType { get; set; }
        public int ConditionType { get; set; }
        public int ConditionId { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int DetermineRace { get; set; }
        public int DetermineRaceFlag { get; set; }
        public int ScenarioGroupId { get; set; }
    }
}

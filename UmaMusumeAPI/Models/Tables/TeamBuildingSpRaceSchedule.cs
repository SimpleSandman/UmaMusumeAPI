using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingSpRaceSchedule
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int SpecialRaceInstanceId { get; set; }
        public int RaceConditionId { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

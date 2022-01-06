using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamStadium
    {
        public int Id { get; set; }
        public long RaceStartDate { get; set; }
        public string RaceStartTime { get; set; }
        public long RaceEndDate { get; set; }
        public string RaceEndTime { get; set; }
        public long IntervalStartDate { get; set; }
        public string IntervalStartTime { get; set; }
        public long IntervalEndDate { get; set; }
        public string IntervalEndTime { get; set; }
        public long CalcStartDate { get; set; }
        public string CalcStartTime { get; set; }
        public long CalcEndDate { get; set; }
        public string CalcEndTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}

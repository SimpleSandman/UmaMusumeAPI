using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamStadium
    {
        public int Id { get; set; }
        public int RaceStartDate { get; set; }
        public string RaceStartTime { get; set; }
        public int RaceEndDate { get; set; }
        public string RaceEndTime { get; set; }
        public int IntervalStartDate { get; set; }
        public string IntervalStartTime { get; set; }
        public int IntervalEndDate { get; set; }
        public string IntervalEndTime { get; set; }
        public int CalcStartDate { get; set; }
        public string CalcStartTime { get; set; }
        public int CalcEndDate { get; set; }
        public string CalcEndTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}

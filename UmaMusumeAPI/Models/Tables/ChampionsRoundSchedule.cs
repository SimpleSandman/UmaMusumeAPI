using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsRoundSchedule
    {
        public int Id { get; set; }
        public int ChampionsId { get; set; }
        public int Round { get; set; }
        public int RoundDetail { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int IntervalStartTime { get; set; }
        public int IntervalEndTime { get; set; }
    }
}

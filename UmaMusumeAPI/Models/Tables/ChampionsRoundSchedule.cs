namespace UmaMusumeAPI.Models.Tables
{
    public class ChampionsRoundSchedule
    {
        public int Id { get; set; }
        public long ChampionsId { get; set; }
        public long Round { get; set; }
        public long RoundDetail { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        public long IntervalStartTime { get; set; }
        public long IntervalEndTime { get; set; }
    }
}

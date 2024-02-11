using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RatingRaceData
    {
        public int Id { get; set; }
        public int NoticeDate { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int WeekdayFreePlayNum { get; set; }
        public int WeekendFreePlayNum { get; set; }
        public int RatingRankInitialLimit { get; set; }
        public int RatingRankResetLimit { get; set; }
    }
}

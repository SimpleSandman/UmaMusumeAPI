using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RatingRacePhaseSchedule
    {
        public int Id { get; set; }
        public int RatingRaceDataId { get; set; }
        public int Week { get; set; }
        public int Phase { get; set; }
        public int RatingRaceConditionIdShort { get; set; }
        public int RatingRaceConditionIdMile { get; set; }
        public int RatingRaceConditionIdMiddle { get; set; }
        public int RatingRaceConditionIdLong { get; set; }
        public int RatingRaceConditionIdDirt { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

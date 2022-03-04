using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceCourseSet
    {
        public int Id { get; set; }
        public int RaceTrackId { get; set; }
        public int Distance { get; set; }
        public int Ground { get; set; }
        public int Inout { get; set; }
        public int Turn { get; set; }
        public int FenceSet { get; set; }
        public int FloatLaneMax { get; set; }
        public int CourseSetStatusId { get; set; }
        public int FinishTimeMin { get; set; }
        public int FinishTimeMinRandomRange { get; set; }
        public int FinishTimeMax { get; set; }
        public int FinishTimeMaxRandomRange { get; set; }
    }
}

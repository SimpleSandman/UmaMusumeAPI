using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HeroesStageSchedule
    {
        public int Id { get; set; }
        public int HeroesId { get; set; }
        public int Stage { get; set; }
        public int StageStep { get; set; }
        public int RaceNum { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

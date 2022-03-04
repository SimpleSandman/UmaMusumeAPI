using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceTrophy
    {
        public int Id { get; set; }
        public int TrophyId { get; set; }
        public int RaceInstanceId { get; set; }
        public int OriginalFlag { get; set; }
        public int DispOrder { get; set; }
        public int Size { get; set; }
        public int EventType { get; set; }
        public string StartDate { get; set; }
        public string DisplayEndDate { get; set; }
    }
}

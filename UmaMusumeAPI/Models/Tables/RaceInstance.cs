using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceInstance
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public int NpcGroupId { get; set; }
        public int Date { get; set; }
        public int Time { get; set; }
        public int RaceNumber { get; set; }
        public int ClockTime { get; set; }
    }
}

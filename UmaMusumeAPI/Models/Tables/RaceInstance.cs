using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceInstance
    {
        public int Id { get; set; }
        public long RaceId { get; set; }
        public long NpcGroupId { get; set; }
        public long Date { get; set; }
        public long Time { get; set; }
        public long RaceNumber { get; set; }
    }
}

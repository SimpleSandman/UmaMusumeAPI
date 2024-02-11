using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class HeroesRaceCondition
    {
        public int Id { get; set; }
        public int HeroesId { get; set; }
        public int Stage { get; set; }
        public int RaceInstanceId { get; set; }
        public int Season { get; set; }
        public int Weather { get; set; }
        public int Ground { get; set; }
    }
}

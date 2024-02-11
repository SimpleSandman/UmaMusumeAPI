using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RatingRaceCondition
    {
        public int Id { get; set; }
        public int RaceInstanceId { get; set; }
        public int Season { get; set; }
        public int Weather { get; set; }
        public int Ground { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
    }
}

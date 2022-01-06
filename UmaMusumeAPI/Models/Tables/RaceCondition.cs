using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceCondition
    {
        public int Id { get; set; }
        public long Season { get; set; }
        public long Weather { get; set; }
        public long Ground { get; set; }
        public long Rate { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeDifficultyBoxGauge
    {
        public int Id { get; set; }
        public long DifficultyId { get; set; }
        public long ResultMin { get; set; }
        public long ResultMax { get; set; }
        public long GaugeRate { get; set; }
    }
}

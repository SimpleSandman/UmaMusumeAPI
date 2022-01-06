using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SupportCardLevel
    {
        public int Id { get; set; }
        public long Rarity { get; set; }
        public long Level { get; set; }
        public long TotalExp { get; set; }
    }
}

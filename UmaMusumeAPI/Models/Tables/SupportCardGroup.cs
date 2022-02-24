using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SupportCardGroup
    {
        public int Id { get; set; }
        public long SupportCardId { get; set; }
        public long CharaId { get; set; }
        public long OutingMax { get; set; }
    }
}

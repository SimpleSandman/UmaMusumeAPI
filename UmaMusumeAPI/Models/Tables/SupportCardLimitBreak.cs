using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SupportCardLimitBreak
    {
        public int Id { get; set; }
        public long Rarity { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
        public long DispOrder { get; set; }
    }
}

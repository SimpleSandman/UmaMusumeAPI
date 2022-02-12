using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeFreeShopBg
    {
        public int Id { get; set; }
        public long StartTurn { get; set; }
        public long EndTurn { get; set; }
        public long BgId { get; set; }
        public long BgSubId { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CollectRaidDressColor
    {
        public int Id { get; set; }
        public int CollectRaidId { get; set; }
        public int CharaId { get; set; }
        public int DressId { get; set; }
        public int ColorId { get; set; }
    }
}
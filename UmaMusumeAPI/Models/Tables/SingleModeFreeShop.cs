using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeFreeShop
    {
        public int Id { get; set; }
        public long StartTurn { get; set; }
        public long EndTurn { get; set; }
        public long LineupGroupId { get; set; }
        public long MaxLineupNum { get; set; }
    }
}

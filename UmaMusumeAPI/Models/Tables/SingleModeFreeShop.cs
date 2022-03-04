using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeFreeShop
    {
        public int Id { get; set; }
        public int StartTurn { get; set; }
        public int EndTurn { get; set; }
        public int LineupGroupId { get; set; }
        public int MaxLineupNum { get; set; }
    }
}

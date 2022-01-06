using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChampionsNewsCharaComment
    {
        public int Id { get; set; }
        public long RoundId { get; set; }
        public long CharaId { get; set; }
        public long BigFlag { get; set; }
    }
}

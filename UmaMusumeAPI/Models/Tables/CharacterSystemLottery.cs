using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharacterSystemLottery
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int CardId { get; set; }
        public int CardRarityId { get; set; }
        public int Trigger { get; set; }
        public int Param1 { get; set; }
        public int Per { get; set; }
        public int Priority { get; set; }
        public int SysTextId { get; set; }
    }
}

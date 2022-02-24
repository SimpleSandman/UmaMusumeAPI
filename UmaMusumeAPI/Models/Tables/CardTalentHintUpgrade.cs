using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CardTalentHintUpgrade
    {
        public int Id { get; set; }
        public int Rarity { get; set; }
        public long TalentLevel { get; set; }
        public long ItemCategory1 { get; set; }
        public long ItemId1 { get; set; }
        public long ItemDispOrder1 { get; set; }
        public long ItemNum1 { get; set; }
        public long ItemCategory2 { get; set; }
        public long ItemId2 { get; set; }
        public long ItemDispOrder2 { get; set; }
        public long ItemNum2 { get; set; }
        public long MoneyNum { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SupportCardData
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long Rarity { get; set; }
        public long ExchangeItemId { get; set; }
        public long EffectTableId { get; set; }
        public long UniqueEffectId { get; set; }
        public long CommandType { get; set; }
        public long CommandId { get; set; }
        public long SupportCardType { get; set; }
        public long SkillSetId { get; set; }
        public long DetailPosX { get; set; }
        public long DetailPosY { get; set; }
        public long DetailScale { get; set; }
        public long DetailRotZ { get; set; }
    }
}

namespace UmaMusumeAPI.Models.Views
{
    public partial class NiceSkillDataInfo
    {
        public int SkillId { get; set; }
        public long? AvailableSkillSetId { get; set; }
        public long? NeedSkillPoint { get; set; }
        public int? SkillSetId { get; set; }
        public long? HintId { get; set; }
        public long? SupportCardId { get; set; }
        public long? CharaId { get; set; }
        public long? Rarity { get; set; }
        public long? UniqueEffectId { get; set; }
        public int? CardId { get; set; }
        public string SkillName { get; set; }
        public string SkillDesc { get; set; }
    }
}

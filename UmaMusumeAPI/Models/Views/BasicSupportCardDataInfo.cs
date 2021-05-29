#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicSupportCardDataInfo
    {
        public int SupportCardDataId { get; set; }
        public long CharaId { get; set; }
        public long Rarity { get; set; }
        public long SkillSetId { get; set; }
        public string SupportCardTitleName { get; set; }
    }
}

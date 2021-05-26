#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class VwBasicTeamStadiumScoreBonusInfo
    {
        public int TeamStadiumScoreBonusId { get; set; }
        public long Priority { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ScoreRate { get; set; }
        public string ScoreBonusName { get; set; }
    }
}

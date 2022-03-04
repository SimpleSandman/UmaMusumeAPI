namespace UmaMusumeAPI.Models.Views
{
    public class BasicTeamStadiumScoreBonusInfo
    {
        public int TeamStadiumScoreBonusId { get; set; }
        public int Priority { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int ScoreRate { get; set; }
        public string ScoreBonusName { get; set; }
        public string ScoreBonusNameEnglish { get; set; }
    }
}

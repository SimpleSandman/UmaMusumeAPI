using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamStadiumScoreBonus
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionValue2 { get; set; }
        public int ScoreRate { get; set; }
    }
}

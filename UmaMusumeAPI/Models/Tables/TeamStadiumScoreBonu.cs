namespace UmaMusumeAPI.Models.Tables
{
    public partial class TeamStadiumScoreBonu
    {
        public int Id { get; set; }
        public long Priority { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ScoreRate { get; set; }
    }
}

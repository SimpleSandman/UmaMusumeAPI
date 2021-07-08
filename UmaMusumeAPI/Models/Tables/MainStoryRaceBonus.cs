namespace UmaMusumeAPI.Models.Tables
{
    public class MainStoryRaceBonus
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long BonusType { get; set; }
        public long BonusValue { get; set; }
        public long ConditionGroup { get; set; }
    }
}

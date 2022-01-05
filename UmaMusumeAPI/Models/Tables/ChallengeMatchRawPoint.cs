namespace UmaMusumeAPI.Models.Tables
{
    public class ChallengeMatchRawPoint
    {
        public int Id { get; set; }
        public long Priority { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long Point { get; set; }
        public long RacePointNameId { get; set; }
        public long SortOrder { get; set; }
    }
}

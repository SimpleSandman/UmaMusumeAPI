namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeRouteCondition
    {
        public int Id { get; set; }
        public long ConditionSetId { get; set; }
        public long ConditionType1 { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
    }
}

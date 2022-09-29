namespace UmaMusumeAPI.Models.Tables
{
    public class RaceJikkyoCue
    {
        public int Id { get; set; }
        public int CuesheetId { get; set; }
        public int CuesheetType { get; set; }
        public int ConditionType1 { get; set; }
        public int ConditionValue1 { get; set; }
        public int ConditionType2 { get; set; }
        public int ConditionValue2 { get; set; }
        public int ConditionType3 { get; set; }
        public int ConditionValue3 { get; set; }
        public int CuesheetName { get; set; }
    }
}

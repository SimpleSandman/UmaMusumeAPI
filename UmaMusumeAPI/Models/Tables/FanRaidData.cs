namespace UmaMusumeAPI.Models.Tables
{
    public class FanRaidData
    {
        public int FanRaidId { get; set; }
        public int ConditionType { get; set; }
        public int ConditionValue { get; set; }
        public int CharaId { get; set; }
        public int DressId { get; set; }
        public string ResultSeCueName { get; set; }
        public string ResultSeCuesheetName { get; set; }
        public int StartDate { get; set; }
        public int CalcStartDate { get; set; }
        public int CalcEndDate { get; set; }
        public int EndDate { get; set; }
    }
}

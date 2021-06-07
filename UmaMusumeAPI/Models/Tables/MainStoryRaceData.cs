namespace UmaMusumeAPI.Models.Tables
{
    public partial class MainStoryRaceData
    {
        public int Id { get; set; }
        public long RaceInstanceId { get; set; }
        public long GroupId { get; set; }
        public long RaceConditionId { get; set; }
        public long ClearRank { get; set; }
        public long BonusChara1 { get; set; }
        public long BonusChara2 { get; set; }
        public long BonusChara3 { get; set; }
    }
}

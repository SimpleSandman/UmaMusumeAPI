namespace UmaMusumeAPI.Models.Tables
{
    public class RaceTrophy
    {
        public int Id { get; set; }
        public long TrophyId { get; set; }
        public long RaceInstanceId { get; set; }
        public long OriginalFlag { get; set; }
        public long DispOrder { get; set; }
        public long Size { get; set; }
        public long EventType { get; set; }
        public string StartDate { get; set; }
        public string DisplayEndDate { get; set; }
    }
}

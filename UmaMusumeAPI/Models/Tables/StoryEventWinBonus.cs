namespace UmaMusumeAPI.Models.Tables
{
    public class StoryEventWinBonus
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long MinWinCount { get; set; }
        public long MaxWinCount { get; set; }
        public long BonusPoint { get; set; }
    }
}

namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryEventWinBonu
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long MinWinCount { get; set; }
        public long MaxWinCount { get; set; }
        public long BonusPoint { get; set; }
    }
}

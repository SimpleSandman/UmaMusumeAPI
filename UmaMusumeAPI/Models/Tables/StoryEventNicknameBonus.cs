namespace UmaMusumeAPI.Models.Tables
{
    public class StoryEventNicknameBonus
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long NicknameRank { get; set; }
        public long BonusPoint { get; set; }
    }
}

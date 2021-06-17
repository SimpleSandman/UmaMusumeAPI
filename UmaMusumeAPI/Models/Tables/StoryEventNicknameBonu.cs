namespace UmaMusumeAPI.Models.Tables
{
    public class StoryEventNicknameBonu
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long NicknameRank { get; set; }
        public long BonusPoint { get; set; }
    }
}

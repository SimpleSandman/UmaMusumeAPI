using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventNicknameBonus
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long NicknameRank { get; set; }
        public long BonusPoint { get; set; }
    }
}

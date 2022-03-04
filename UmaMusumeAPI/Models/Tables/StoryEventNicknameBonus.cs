using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventNicknameBonus
    {
        public int Id { get; set; }
        public int StoryEventId { get; set; }
        public int NicknameRank { get; set; }
        public int BonusPoint { get; set; }
    }
}

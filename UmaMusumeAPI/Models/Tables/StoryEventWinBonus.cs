using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventWinBonus
    {
        public int Id { get; set; }
        public int StoryEventId { get; set; }
        public int MinWinCount { get; set; }
        public int MaxWinCount { get; set; }
        public int BonusPoint { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventBonusCard
    {
        public int Id { get; set; }
        public int StoryEventId { get; set; }
        public int CharaId { get; set; }
        public int CardId { get; set; }
        public int Rarity1 { get; set; }
        public int Rarity2 { get; set; }
        public int Rarity3 { get; set; }
        public int Rarity4 { get; set; }
        public int Rarity5 { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventBonusCard
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long CharaId { get; set; }
        public long CardId { get; set; }
        public long Rarity1 { get; set; }
        public long Rarity2 { get; set; }
        public long Rarity3 { get; set; }
        public long Rarity4 { get; set; }
        public long Rarity5 { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
    }
}

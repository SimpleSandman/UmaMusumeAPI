using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventRouletteBingo
    {
        public int Id { get; set; }
        public int RouletteId { get; set; }
        public int StoryEventId { get; set; }
        public int SheetNum { get; set; }
        public int CanLoop { get; set; }
        public int UseItemCategory { get; set; }
        public int UseItemId { get; set; }
        public int UseItemNum { get; set; }
        public int CharacterId { get; set; }
        public int DressId { get; set; }
        public int ResetLine { get; set; }
        public int RewardSetId { get; set; }
        public int RouletteMaxNum { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

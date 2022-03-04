using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class StoryEventBonusSupportCard
    {
        public int Id { get; set; }
        public int StoryEventId { get; set; }
        public int CharaId { get; set; }
        public int Rarity { get; set; }
        public int SupportCardId { get; set; }
        public int Limit0 { get; set; }
        public int Limit1 { get; set; }
        public int Limit2 { get; set; }
        public int Limit3 { get; set; }
        public int Limit4 { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
}

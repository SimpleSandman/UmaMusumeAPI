using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeStoryData
    {
        public int Id { get; set; }
        public long StoryId { get; set; }
        public long ShortStoryId { get; set; }
        public long CardId { get; set; }
        public long CardCharaId { get; set; }
        public long SupportCardId { get; set; }
        public long SupportCharaId { get; set; }
        public long ShowProgress1 { get; set; }
        public long ShowProgress2 { get; set; }
        public long ShowClear { get; set; }
        public long ShowSuccession { get; set; }
        public long EventTitleStyle { get; set; }
        public long EventTitleDressIcon { get; set; }
        public long EventTitleCharaIcon { get; set; }
        public long SeChange { get; set; }
        public long EndingType { get; set; }
        public long RaceEventFlag { get; set; }
        public long MiniGameResult { get; set; }
    }
}

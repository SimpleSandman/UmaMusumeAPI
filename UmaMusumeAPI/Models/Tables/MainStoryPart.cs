using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class MainStoryPart
    {
        public int Id { get; set; }
        public int MainStoryLastChapter { get; set; }
        public int StartDate { get; set; }
        public string UiColor { get; set; }
        public int SectionId { get; set; }
        public int PartIndex { get; set; }
        public int IsLastPart { get; set; }
    }
}

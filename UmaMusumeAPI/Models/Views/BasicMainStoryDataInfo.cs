#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicMainStoryDataInfo
    {
        public int MainStoryDataId { get; set; }
        public long PartId { get; set; }
        public long EpisodeIndex { get; set; }
        public long StoryNumber { get; set; }
        public string MainStoryEpisodeTitle { get; set; }
    }
}

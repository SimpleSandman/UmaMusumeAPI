using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicStoryEventStoryDataInfo
    {
        public int StoryEventStoryId { get; set; }
        public int StoryEventId { get; set; }
        public int EpisodeIndexId { get; set; }
        public int NeedPoint { get; set; }
        public DateTime? StartDate { get; set; }
        public string StoryEventEpisodeTitle { get; set; }
        public string StoryEventEpisodeTitleEnglish { get; set; }
    }
}

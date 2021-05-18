using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicStoryEventStoryDataInfo
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long EpisodeIndexId { get; set; }
        public long NeedPoint { get; set; }
        public DateTime? StartDate { get; set; }
        public string StoryEventEpisodeTitle { get; set; }
    }
}

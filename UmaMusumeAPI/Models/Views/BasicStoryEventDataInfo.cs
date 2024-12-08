using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicStoryEventDataInfo
    {
        public int StoryEventId { get; set; }
        public DateTime? NoticeDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? MiddleDate01 { get; set; }
        public DateTime? MiddleDate02 { get; set; }
        public DateTime? EndingDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StoryEventTitle { get; set; }
    }
}

﻿namespace UmaMusumeAPI.Models.Tables
{
    public partial class ShortEpisode
    {
        public int Id { get; set; }
        public long Scene { get; set; }
        public long Sort { get; set; }
        public long ConditionType { get; set; }
        public long ConditionValue1 { get; set; }
        public long StoryId { get; set; }
    }
}

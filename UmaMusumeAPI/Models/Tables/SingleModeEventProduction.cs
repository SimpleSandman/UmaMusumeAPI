using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeEventProduction
    {
        public int StoryId { get; set; }
        public long EventCategoryId { get; set; }
        public long MaxItemId { get; set; }
    }
}

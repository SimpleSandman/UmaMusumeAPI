using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class MainStoryPart
    {
        public int Id { get; set; }
        public long MainStoryLastChapter { get; set; }
        public long StartDate { get; set; }
        public string UiColor { get; set; }
    }
}

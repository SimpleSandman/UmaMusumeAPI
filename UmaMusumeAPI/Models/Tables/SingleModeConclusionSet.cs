using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeConclusionSet
    {
        public long StoryId { get; set; }
        public long RootId { get; set; }
        public long ConclusionId { get; set; }
    }
}

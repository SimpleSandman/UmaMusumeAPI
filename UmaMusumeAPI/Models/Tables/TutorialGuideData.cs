using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TutorialGuideData
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long PageIndex { get; set; }
        public long ImageIndex { get; set; }
    }
}

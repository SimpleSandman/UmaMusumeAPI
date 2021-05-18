using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class TutorialMessage
    {
        public long TutorialId { get; set; }
        public int TutorialIndex { get; set; }
        public string TutorialText { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeTrainingSe
    {
        public int Id { get; set; }
        public string SheetId { get; set; }
        public string SeCueName { get; set; }
        public string SeCuesheetName { get; set; }
        public string SkipSeCueName { get; set; }
        public string SkipSeCuesheetName { get; set; }
        public long CharaIndex { get; set; }
        public long VoiceTriggerId { get; set; }
    }
}

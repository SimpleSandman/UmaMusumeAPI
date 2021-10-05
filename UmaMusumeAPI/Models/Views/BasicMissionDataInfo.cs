using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicMissionDataInfo
    {
        public int MissionId { get; set; }
        public long MissionType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MissionName { get; set; }
        public string MissionNameEnglish { get; set; }
    }
}

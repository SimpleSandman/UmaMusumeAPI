using System;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class VwBasicMissionDataInfo
    {
        public int Id { get; set; }
        public long MissionType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MissionName { get; set; }
    }
}

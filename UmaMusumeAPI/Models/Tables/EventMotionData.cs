using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class EventMotionData
    {
        public int Id { get; set; }
        public string CommandName { get; set; }
        public string BaseStateName { get; set; }
        public int PoseBlend { get; set; }
        public int Type { get; set; }
        public int StateGroup { get; set; }
        public int Category { get; set; }
        public int StartBlendTime { get; set; }
        public int EndBlendTime { get; set; }
    }
}

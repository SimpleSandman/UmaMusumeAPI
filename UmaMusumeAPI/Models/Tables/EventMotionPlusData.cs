using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class EventMotionPlusData
    {
        public int Id { get; set; }
        public string CommandName { get; set; }
        public string BaseStateName { get; set; }
        public int LayerIndex { get; set; }
        public int TailMotionType { get; set; }
        public int StartBlendTime { get; set; }
        public int EndBlendTime { get; set; }
    }
}

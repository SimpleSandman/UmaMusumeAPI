using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class EventMotionPlusData
    {
        public int Id { get; set; }
        public string CommandName { get; set; }
        public string BaseStateName { get; set; }
        public long LayerIndex { get; set; }
        public long TailMotionType { get; set; }
        public long StartBlendTime { get; set; }
        public long EndBlendTime { get; set; }
    }
}

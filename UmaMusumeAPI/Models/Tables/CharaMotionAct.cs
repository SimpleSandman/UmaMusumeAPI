using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharaMotionAct
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long TargetMotion { get; set; }
        public string CommandName { get; set; }
    }
}

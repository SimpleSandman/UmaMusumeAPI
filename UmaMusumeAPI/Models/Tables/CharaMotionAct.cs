using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class CharaMotionAct
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int TargetMotion { get; set; }
        public string CommandName { get; set; }
    }
}

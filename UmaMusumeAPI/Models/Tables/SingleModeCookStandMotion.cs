using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCookStandMotion
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int Type { get; set; }
        public int ConditionType { get; set; }
        public int MiniCharaMotionId { get; set; }
    }
}
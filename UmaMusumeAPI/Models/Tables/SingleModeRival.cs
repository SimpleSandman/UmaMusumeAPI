using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRival
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int Turn { get; set; }
        public int RaceProgramId { get; set; }
        public int RivalFlagId { get; set; }
        public int ConditionType { get; set; }
        public int RivalCharaId { get; set; }
        public int SingleModeNpcId { get; set; }
        public int FrameOrder { get; set; }
    }
}

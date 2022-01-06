using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeRival
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long Turn { get; set; }
        public long RaceProgramId { get; set; }
        public long ConditionType { get; set; }
        public long RivalCharaId { get; set; }
        public long SingleModeNpcId { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCharaEffect
    {
        public int Id { get; set; }
        public long EffectType { get; set; }
        public long EffectCategory { get; set; }
        public long EffectGroupId { get; set; }
        public long Priority { get; set; }
    }
}

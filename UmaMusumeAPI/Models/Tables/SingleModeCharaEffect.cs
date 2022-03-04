using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCharaEffect
    {
        public int Id { get; set; }
        public int EffectType { get; set; }
        public int EffectCategory { get; set; }
        public int EffectGroupId { get; set; }
        public int Priority { get; set; }
    }
}

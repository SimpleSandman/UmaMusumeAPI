using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeVenusCrystalGroup
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int VenusLevel { get; set; }
        public int PassiveEffectGroupId { get; set; }
        public int ActiveEffectGroupId { get; set; }
        public int ActiveEffectTurn { get; set; }
    }
}

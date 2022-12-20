using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeCharaEffectBuff
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int EffectId { get; set; }
        public int Turn { get; set; }
        public int ProgramId { get; set; }
        public int SpeedAdd { get; set; }
        public int StaminaAdd { get; set; }
        public int PowerAdd { get; set; }
        public int GutsAdd { get; set; }
        public int WizAdd { get; set; }
    }
}

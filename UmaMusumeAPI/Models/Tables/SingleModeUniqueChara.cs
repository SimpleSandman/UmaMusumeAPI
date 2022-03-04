using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeUniqueChara
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public int ScenarioId { get; set; }
        public int CharaId { get; set; }
        public int Period { get; set; }
        public int TrainingPlacement { get; set; }
        public int GainFlagId { get; set; }
        public int IsSupportFeaturedStock { get; set; }
        public int GainRoleId { get; set; }
    }
}

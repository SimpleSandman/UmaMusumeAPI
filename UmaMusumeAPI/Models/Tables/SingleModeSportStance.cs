using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeSportStance
    {
        public int Id { get; set; }
        public int SportType { get; set; }
        public int TotalSportRank { get; set; }
        public int StanceEffectId1 { get; set; }
        public int StanceEffectId2 { get; set; }
        public int StanceEffectId3 { get; set; }
        public int StanceEffectId4 { get; set; }
        public int StanceEffectId5 { get; set; }
        public int EffectTurn { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeProgram
    {
        public int Id { get; set; }
        public int BaseProgramId { get; set; }
        public int ProgramGroup { get; set; }
        public int RaceInstanceId { get; set; }
        public int RacePermission { get; set; }
        public int Month { get; set; }
        public int Half { get; set; }
        public int GradeRateId { get; set; }
        public int EntryDecrease { get; set; }
        public int EntryDecreaseFlag { get; set; }
        public int RecommendClassId { get; set; }
        public int FillyOnlyFlag { get; set; }
        public int NeedFanCount { get; set; }
        public int FanSetId { get; set; }
        public int RewardSetId { get; set; }
    }
}

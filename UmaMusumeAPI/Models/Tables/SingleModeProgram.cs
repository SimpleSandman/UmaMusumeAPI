namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeProgram
    {
        public int Id { get; set; }
        public long BaseProgramId { get; set; }
        public long ProgramGroup { get; set; }
        public long RaceInstanceId { get; set; }
        public long RacePermission { get; set; }
        public long Month { get; set; }
        public long Half { get; set; }
        public long GradeRateId { get; set; }
        public long EntryDecrease { get; set; }
        public long EntryDecreaseFlag { get; set; }
        public long RecommendClassId { get; set; }
        public long FillyOnlyFlag { get; set; }
        public long NeedFanCount { get; set; }
        public long FanSetId { get; set; }
        public long RewardSetId { get; set; }
    }
}

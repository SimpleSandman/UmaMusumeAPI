namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeRaceGroup
    {
        public int Id { get; set; }
        public long RaceGroupId { get; set; }
        public long RaceProgramId { get; set; }
    }
}

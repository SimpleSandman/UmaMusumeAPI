namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeDifficultyBox
    {
        public int RewardSetId { get; set; }
        public int BoxStep { get; set; }
        public long BoxOpenCondition { get; set; }
        public long BoxType { get; set; }
        public long BoxId { get; set; }
        public string CueNameIcon { get; set; }
        public string CueNamePopout { get; set; }
        public string CuesheetNameIcon { get; set; }
        public string CuesheetNamePopout { get; set; }
    }
}

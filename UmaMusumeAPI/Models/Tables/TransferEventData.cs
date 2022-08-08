namespace UmaMusumeAPI.Models.Tables
{
    public class TransferEventData
    {
        public int TransferEventId { get; set; }
        public int PreStartDate { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int LogoId { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
        public int TutorialGuideId { get; set; }
        public string BgmCueName { get; set; }
        public string BgmCuesheetName { get; set; }
        public int TopTrigger { get; set; }
        public int FinishTrigger { get; set; }
        public int ClearTrigger { get; set; }
    }
}

using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class SingleModeScenario
    {
        public int Id { get; set; }
        public int SortId { get; set; }
        public int ScenarioImageId { get; set; }
        public int PrologueId { get; set; }
        public int TurnSetId { get; set; }
        public int HintRate { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int BgId { get; set; }
        public int BgSubId { get; set; }
        public int BgOffsetX { get; set; }
        public int SecBgId { get; set; }
        public int SecBgSubId { get; set; }
        public string LabelFontColor { get; set; }
        public string LabelBgColor { get; set; }
        public int CharaProgramChangeFlag { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxStamina { get; set; }
        public int MaxPow { get; set; }
        public int MaxGuts { get; set; }
        public int MaxWiz { get; set; }
        public int GimmickDiscountRate { get; set; }
        public int AdditionalIconSetId { get; set; }
    }
}

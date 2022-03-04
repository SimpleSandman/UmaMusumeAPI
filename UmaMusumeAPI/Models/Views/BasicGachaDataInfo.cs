using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicGachaDataInfo
    {
        public int GachaId { get; set; }
        public int CardType { get; set; }
        public int DailyPayCost { get; set; }
        public int OnlyOnceFlag { get; set; }
        public int CostType { get; set; }
        public int CostSingle { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? FreeCampaignStartDate { get; set; }
        public DateTime? FreeCampaignEndDate { get; set; }
        public string GachaText { get; set; }
        public string GachaTextEnglish { get; set; }
    }
}

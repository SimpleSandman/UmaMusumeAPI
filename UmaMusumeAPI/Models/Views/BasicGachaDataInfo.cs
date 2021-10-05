﻿using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicGachaDataInfo
    {
        public int GachaId { get; set; }
        public long CardType { get; set; }
        public long DailyPayCost { get; set; }
        public long OnlyOnceFlag { get; set; }
        public long CostType { get; set; }
        public long CostSingle { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? FreeCampaignStartDate { get; set; }
        public DateTime? FreeCampaignEndDate { get; set; }
        public string GachaText { get; set; }
        public string GachaTextEnglish { get; set; }
    }
}

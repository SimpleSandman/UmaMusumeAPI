using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicItemExchangeInfo
    {
        public int ItemExchangeId { get; set; }
        public long ItemExchangeTopId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ItemExchangeCondition { get; set; }
        public string ItemExchangeConditionEnglish { get; set; }
    }
}

using System;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class VwBasicItemExchangeInfo
    {
        public int Id { get; set; }
        public long ItemExchangeTopId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ItemExchangeCondition { get; set; }
    }
}

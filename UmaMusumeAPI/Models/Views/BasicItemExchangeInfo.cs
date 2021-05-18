using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicItemExchangeInfo
    {
        public int Id { get; set; }
        public long ItemExchangeTopId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ItemExchangeCondition { get; set; }
    }
}

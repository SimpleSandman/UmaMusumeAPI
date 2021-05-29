using System;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicLoginBonusDataInfo
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long CountNum { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LoginBonusName { get; set; }
    }
}

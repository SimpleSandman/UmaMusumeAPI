using System;

namespace UmaMusumeAPI.Models.Views
{
    public class BasicLoginBonusDataInfo
    {
        public int LoginBonusId { get; set; }
        public int Type { get; set; }
        public int CountNum { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LoginBonusName { get; set; }
        public string LoginBonusNameEnglish { get; set; }
    }
}

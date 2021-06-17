using System;

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicCharaDataInfo
    {
        public int CharaId { get; set; }
        public int? CardId { get; set; }
        public int? SupportCardId { get; set; }
        public DateTime? CharaStartDate { get; set; }
        public string CharaName { get; set; }
        public string CharaCv { get; set; }
    }
}

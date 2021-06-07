using System;

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicCharaDataInfo
    {
        public int CharaId { get; set; }
        public int? CharaVersionId { get; set; }
        public DateTime? CharaStartDate { get; set; }
        public string HorseName { get; set; }
    }
}

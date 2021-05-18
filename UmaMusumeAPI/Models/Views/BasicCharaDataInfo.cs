using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Views
{
    public partial class BasicCharaDataInfo
    {
        public int CharaId { get; set; }
        public long? CharaVersionId { get; set; }
        public DateTime? CharaStartDate { get; set; }
        public string HorseName { get; set; }
    }
}

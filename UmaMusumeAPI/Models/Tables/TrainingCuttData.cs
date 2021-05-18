using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TrainingCuttData
    {
        public long CommandId { get; set; }
        public long SubId { get; set; }
        public long CharaNum { get; set; }
        public long TargetCharaIndex { get; set; }
        public long TargetValue { get; set; }
        public long CuttIndex { get; set; }
        public long SuccessFlg { get; set; }
    }
}

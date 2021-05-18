using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeRecommend
    {
        public int Id { get; set; }
        public long GradeUpperLimit { get; set; }
        public long GradeLowerLimit { get; set; }
    }
}

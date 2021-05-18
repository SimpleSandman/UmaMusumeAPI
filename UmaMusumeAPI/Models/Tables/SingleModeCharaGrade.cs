using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeCharaGrade
    {
        public int Id { get; set; }
        public long WinNum { get; set; }
        public long RunNum { get; set; }
        public long NeedFanCount { get; set; }
    }
}

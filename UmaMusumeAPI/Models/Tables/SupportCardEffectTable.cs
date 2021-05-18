using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SupportCardEffectTable
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public long Init { get; set; }
        public long LimitLv5 { get; set; }
        public long LimitLv10 { get; set; }
        public long LimitLv15 { get; set; }
        public long LimitLv20 { get; set; }
        public long LimitLv25 { get; set; }
        public long LimitLv30 { get; set; }
        public long LimitLv35 { get; set; }
        public long LimitLv40 { get; set; }
        public long LimitLv45 { get; set; }
        public long LimitLv50 { get; set; }
    }
}

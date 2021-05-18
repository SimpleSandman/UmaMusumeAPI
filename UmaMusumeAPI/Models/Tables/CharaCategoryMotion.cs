using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class CharaCategoryMotion
    {
        public int CharaId { get; set; }
        public long StandbyMotion1 { get; set; }
        public long StandbyMotion2 { get; set; }
        public long StandbyMotion3 { get; set; }
        public long StandbyMotion4 { get; set; }
        public long StandbyMotion5 { get; set; }
        public long StandbyMotion6 { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeCharaProgram
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long ProgramGroup { get; set; }
    }
}

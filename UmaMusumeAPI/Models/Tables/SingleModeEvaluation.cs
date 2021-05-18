using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeEvaluation
    {
        public int Id { get; set; }
        public long Evaluation { get; set; }
        public long CharaId { get; set; }
    }
}

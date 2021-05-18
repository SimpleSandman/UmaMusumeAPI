using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeUniqueChara
    {
        public int Id { get; set; }
        public long PartnerId { get; set; }
        public long ScenarioId { get; set; }
        public long CharaId { get; set; }
        public long Period { get; set; }
        public long TrainingPlacement { get; set; }
    }
}

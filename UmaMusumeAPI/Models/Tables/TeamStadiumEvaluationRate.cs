﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TeamStadiumEvaluationRate
    {
        public long Id { get; set; }
        public int ProperType { get; set; }
        public int ProperRank { get; set; }
        public long Rate { get; set; }
    }
}

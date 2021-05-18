using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class SingleModeOuting
    {
        public int Id { get; set; }
        public long CommandGroupId { get; set; }
        public long Condition { get; set; }
        public long IsPlayCutt { get; set; }
    }
}

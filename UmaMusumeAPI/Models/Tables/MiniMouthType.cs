using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class MiniMouthType
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long ReverseMouthId { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class Topic
    {
        public int Id { get; set; }
        public long Type { get; set; }
        public long Value { get; set; }
        public long Index { get; set; }
        public string StartDate { get; set; }
    }
}

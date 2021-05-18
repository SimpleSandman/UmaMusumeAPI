using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class AnnounceCharacter
    {
        public int Id { get; set; }
        public long MovieId { get; set; }
        public long CanEndSecond { get; set; }
    }
}

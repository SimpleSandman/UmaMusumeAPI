using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class HomeCharacterType
    {
        public int PosId { get; set; }
        public int OriginalPersonality { get; set; }
        public long ChangePersonality { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceBgmCutinExtensionTime
    {
        public int Id { get; set; }
        public long CutinCategory { get; set; }
        public long CardId { get; set; }
        public long CharaId { get; set; }
        public long ExtensionSec { get; set; }
        public long ExtensionSecLong { get; set; }
    }
}

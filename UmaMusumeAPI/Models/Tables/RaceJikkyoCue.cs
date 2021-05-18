using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceJikkyoCue
    {
        public int Id { get; set; }
        public long CuesheetId { get; set; }
        public int CuesheetType { get; set; }
    }
}

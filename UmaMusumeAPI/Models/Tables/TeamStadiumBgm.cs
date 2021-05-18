using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class TeamStadiumBgm
    {
        public int Id { get; set; }
        public long SceneType { get; set; }
        public long Priority { get; set; }
        public string CueName { get; set; }
        public string CuesheetName { get; set; }
    }
}

﻿namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceEnvDefine
    {
        public int Id { get; set; }
        public long RaceTrackId { get; set; }
        public long Season { get; set; }
        public long Weather { get; set; }
        public long Timezone { get; set; }
        public long Resource { get; set; }
    }
}

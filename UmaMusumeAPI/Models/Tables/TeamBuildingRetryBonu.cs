﻿using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class TeamBuildingRetryBonu
    {
        public int Id { get; set; }
        public int RetryMin { get; set; }
        public int RetryMax { get; set; }
        public int BonusRate { get; set; }
        public int ResimulateNum { get; set; }
    }
}

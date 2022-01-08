﻿using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class ChallengeMatchRetryBonus
    {
        public int Id { get; set; }
        public long RetryMin { get; set; }
        public long RetryMax { get; set; }
        public long BonusRate { get; set; }
        public long ResimulateNum { get; set; }
    }
}
﻿namespace UmaMusumeAPI.Models.Tables
{
    public class LoginBonusDetail
    {
        public int Id { get; set; }
        public long LoginBonusId { get; set; }
        public long Count { get; set; }
        public long ItemCategory { get; set; }
        public long ItemId { get; set; }
        public long ItemNum { get; set; }
    }
}

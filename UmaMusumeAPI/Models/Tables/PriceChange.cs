﻿using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class PriceChange
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public long MinNum { get; set; }
        public long MaxNum { get; set; }
        public long PayItemNum { get; set; }
    }
}

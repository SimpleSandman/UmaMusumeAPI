﻿namespace UmaMusumeAPI.Models.Tables
{
    public class SingleModeAoharuSchedule
    {
        public int Id { get; set; }
        public long TurnNum { get; set; }
        public long NoticeTurn1 { get; set; }
        public long NoticeTurn2 { get; set; }
        public long NoticeTurn3 { get; set; }
        public long NoticeTurn4 { get; set; }
        public long NoticeTurn5 { get; set; }
    }
}
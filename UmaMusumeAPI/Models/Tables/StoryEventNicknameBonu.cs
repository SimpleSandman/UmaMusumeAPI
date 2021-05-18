using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class StoryEventNicknameBonu
    {
        public int Id { get; set; }
        public long StoryEventId { get; set; }
        public long NicknameRank { get; set; }
        public long BonusPoint { get; set; }
    }
}

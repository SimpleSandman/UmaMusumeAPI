using System;
using System.Collections.Generic;

#nullable disable

namespace UmaMusumeAPI.Models.Tables
{
    public partial class RaceJikkyoMessage
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public string Message { get; set; }
        public string Voice { get; set; }
        public long Per { get; set; }
        public long CommentGroup { get; set; }
        public long Reuse { get; set; }
    }
}

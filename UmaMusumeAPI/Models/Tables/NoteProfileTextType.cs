﻿namespace UmaMusumeAPI.Models.Tables
{
    public partial class NoteProfileTextType
    {
        public int Id { get; set; }
        public long TextType { get; set; }
        public long TextCategoryId { get; set; }
        public long Sort { get; set; }
    }
}

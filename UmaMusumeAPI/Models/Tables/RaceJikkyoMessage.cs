namespace UmaMusumeAPI.Models.Tables
{
    public class RaceJikkyoMessage
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

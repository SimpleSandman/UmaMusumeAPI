using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class RaceJikkyoMessage
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Message { get; set; }
        public string Voice { get; set; }
        public int Per { get; set; }
        public int CommentGroup { get; set; }
        public int Reuse { get; set; }
    }
}

namespace UmaMusumeAPI.Models.Tables
{
    public class JukeboxComment
    {
        public int Id { get; set; }
        public long CommentId { get; set; }
        public long CharaId { get; set; }
        public long CommentType { get; set; }
        public long VariationType { get; set; }
        public long VariationValue { get; set; }
    }
}

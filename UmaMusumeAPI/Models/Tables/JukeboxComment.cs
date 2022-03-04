using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class JukeboxComment
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int CharaId { get; set; }
        public int CommentType { get; set; }
        public int VariationType { get; set; }
        public int VariationValue { get; set; }
    }
}

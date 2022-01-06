using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class NoteProfileTextType
    {
        public int Id { get; set; }
        public long TextType { get; set; }
        public long TextCategoryId { get; set; }
        public long Sort { get; set; }
    }
}

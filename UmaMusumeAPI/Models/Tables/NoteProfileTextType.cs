using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class NoteProfileTextType
    {
        public int Id { get; set; }
        public int TextType { get; set; }
        public int TextCategoryId { get; set; }
        public int Sort { get; set; }
    }
}

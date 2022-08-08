using UmaMusumeAPI.Controllers;

namespace UmaMusumeAPI.Models.Tables
{
    [GeneratedController]
    public class NoteProfile
    {
        public int Id { get; set; }
        public int CharaId { get; set; }
        public int TextType { get; set; }
        public int LockType { get; set; }
        public int LockValue { get; set; }
        public int Sort { get; set; }
        public int SecretFlg { get; set; }
    }
}

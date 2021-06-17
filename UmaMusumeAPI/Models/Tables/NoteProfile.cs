namespace UmaMusumeAPI.Models.Tables
{
    public class NoteProfile
    {
        public int Id { get; set; }
        public long CharaId { get; set; }
        public long TextType { get; set; }
        public long LockType { get; set; }
        public long LockValue { get; set; }
        public long Sort { get; set; }
    }
}

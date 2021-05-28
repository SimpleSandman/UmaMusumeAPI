#nullable disable

namespace UmaMusumeAPI.Models.StoredProcedures
{
    public class SpSuccessionPointSum
    {
        public long Parent1Child { get; set; }
        public long GrandparentAParent1 { get; set; }
        public long GrandparentBParent1 { get; set; }
        public long Parent2Child { get; set; }
        public long GrandparentAParent2 { get; set; }
        public long GrandparentBParent2 { get; set; }
        public long Parent1Parent2 { get; set; }
        public long PointSum { get; set; }
    }
}

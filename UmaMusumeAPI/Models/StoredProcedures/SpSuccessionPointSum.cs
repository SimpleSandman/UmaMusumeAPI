namespace UmaMusumeAPI.Models.StoredProcedures
{
    public class SpSuccessionPointSum
    {
        public int Parent1Child { get; set; }
        public int GrandparentAParent1 { get; set; }
        public int GrandparentBParent1 { get; set; }
        public int Parent2Child { get; set; }
        public int GrandparentAParent2 { get; set; }
        public int GrandparentBParent2 { get; set; }
        public int Parent1Parent2 { get; set; }
        public int PointSum { get; set; }
    }
}

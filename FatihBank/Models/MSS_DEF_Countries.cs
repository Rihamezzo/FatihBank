namespace FatihBank.Models
{
    public class MSS_DEF_Countries
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime entry_date { get; set; }

        public virtual ICollection<MSS_DEF_Stores> stores { get; set; }
    }
}

namespace FatihBank.Models
{
    public class MSS_CAS_Operations
    {
        public int Id { get; set; }
        public int cashier_id { get; set; }
        public int? cashierId { get; set; }
        public virtual MSS_DEF_Cashiers cashier { get; set; }
        public double amount { get; set; }
        public DateTime date { get; set; }
        public string notes { get; set; }
        public string reason { get; set; }
        public int entered_by { get; set; }
        public DateTime entry_date { get; set; }
        public int type { get; set; }
    }
}

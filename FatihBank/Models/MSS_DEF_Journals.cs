namespace FatihBank.Models
{
    public enum JournalStatus
    {
        Pending = 1,
        Posted = 2,
        Canceled = 3
    }
    public class MSS_DEF_Journals
    {
        public int Id { get; set; }
        public JournalStatus status { get; set; }
        public string code { get; set; }
        public string notes { get; set; }
        public DateTime date { get; set; }
        public double total_amount { get; set; }
        public int entered_by { get; set; }

        public virtual ICollection<MSS_JOU_Details> details { get; set; }
    }

    public class MSS_JOU_Details
    {
        public int Id { get; set; }
        public int? journalId { get; set; }

        public int? accountId { get; set; }
        public int? customerId { get; set; }
        public double? currencyAmount { get; set; }
        public int? currencyId { get; set; }

        public double? inAmount { get; set; }
        public double? outAmount { get; set; }

        public virtual MSS_DEF_Customers customer { get; set; }
        public virtual MSS_DEF_Currencies currency { get; set; }
        public virtual MSS_DEF_Accounts account { get; set; }
        public virtual MSS_DEF_Journals journal { get; set; }

    }
}

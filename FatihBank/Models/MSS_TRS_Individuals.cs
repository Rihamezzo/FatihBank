namespace FatihBank.Models
{
    public class MSS_TRS_Individuals
    {
        public int Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public virtual MSS_DEF_Accounts account { get; set; }
        public string deliever_to { get; set; }
        public string notes { get; set; }

        public int is_delievered { get; set; }

        public double amount { get; set; }

        public int cashier_id { get; set; }
        public int? cashierId { get; set; }
        public virtual MSS_DEF_Cashiers cashier { get; set; }
        public int order_by { get; set; }
        public int? delievered_by { get; set; }
        public DateTime order_date { get; set; }
        public DateTime? deliever_date { get; set; }
    }
}

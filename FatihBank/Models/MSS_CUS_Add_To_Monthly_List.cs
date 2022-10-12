namespace FatihBank.Models
{
    public class MSS_CUS_Add_To_Monthly_List
    {
        public int Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public virtual MSS_DEF_Accounts account { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public virtual MSS_DEF_Currencies currency { get; set; }
        public double percent { get; set; }
        public int profit_id { get; set; }
        public int? profitAccountId { get; set; }
        public virtual MSS_DEF_Accounts profitAccount { get; set; }
    }
}

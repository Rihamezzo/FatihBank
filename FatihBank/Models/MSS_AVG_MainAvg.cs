namespace FatihBank.Models
{
    public class MSS_AVG_MainAvg
    {
        public int Id { get; set; }
        public int currency_1 { get; set; }
        public int? currency1Id { get; set; }

        public virtual MSS_DEF_Currencies currency1 { get; set; }
        public double currency1_amount { get; set; }
        public int currency_2 { get; set; }
        public int? currency2Id { get; set; }

        public virtual MSS_DEF_Currencies currency2 { get; set; }
        public double currency2_amount { get; set; }
        public double price { get; set; }

        public DateTime last_update { get; set; }
        public int? exchange_account { get; set; }
        public int? exchangeAccountId { get; set; }
        public virtual MSS_DEF_Exchange_Accounts exchangeAccount { get; set; }
    }
}

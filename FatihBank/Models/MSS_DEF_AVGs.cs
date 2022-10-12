namespace FatihBank.Models
{
    public class MSS_DEF_AVGs
    {
        public int Id { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public virtual MSS_DEF_Currencies currency { get; set; }
        public double amount1 { get; set; }
        public double amount2 { get; set; }
        public double avg { get; set; }
        public int type { get; set; }
        public DateTime last_update { get; set; }
    }
}

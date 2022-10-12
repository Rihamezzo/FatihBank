namespace FatihBank.Models
{
    public class MSS_DEF_P_Prices
    {
        public int Id { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public virtual MSS_DEF_Currencies currency { get; set; }
        public double price { get; set; }
        public int divide { get; set; }
        public DateTime last_update { get; set; }
        public int user_id { get; set; }
        public int? userId { get; set; }
        public virtual MSS_DEF_Users user { get; set; }
    }
}

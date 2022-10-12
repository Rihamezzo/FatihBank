namespace FatihBank.Models
{
    public class MSS_DEF_Exchange_Accounts
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public virtual MSS_DEF_Currencies currency { get; set; }
        public double start_amount { get; set; }
        public double? price { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime entery_date { get; set; }
        public int? currency2_id { get; set; }
        public int? currency2Id { get; set; }
        public virtual MSS_DEF_Currencies currency2 { get; set; }
        public int? parent_id { get; set; }
        public int? parentId { get; set; }
        public virtual MSS_DEF_Exchange_Accounts parent { get; set; }

    }
}

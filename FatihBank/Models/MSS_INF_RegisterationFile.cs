namespace FatihBank.Models
{
    public class MSS_INF_RegisterationFile
    {
		public int Id { get; set; }
		public int user_id { get; set; }
		public int? userId { get; set; }
		public virtual MSS_DEF_Users user { get; set; }	
		public DateTime entry_date { get; set; }
		public int operation_type { get; set; }
		public int operation_id { get; set; }
		public int action_type { get; set; }
		public int? Action_typeId { get; set; }
		public virtual MSS_INF_Action_Types Action_Type { get; set; }
		public int? account_id { get; set; }
		public int? accountId { get; set; }
		public virtual MSS_DEF_Accounts account { get; set; }
		public double? amount { get; set; }
		public int? subtype { get; set; }
		public int? cashier_id { get; set; }
		public int? cashierId { get; set; }
		public virtual MSS_DEF_Cashiers cashier { get; set; }
		public int? currency_id { get; set; }
		public int? currencyId { get; set; }
		public virtual MSS_DEF_Currencies currency { get; set; }
		public int? exchange_id { get; set; }
		public int? exchangeId { get; set; }
		public virtual MSS_DEF_Exchange_Accounts exchange { get; set; }
		public double? price { get; set; }
		public string computer_name { get; set; }
	}
}

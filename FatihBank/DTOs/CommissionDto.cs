namespace FatihBank.DTOs
{
    public class CommissionDto
    {
		public int? Id { get; set; }
		public int account_id { get; set; }
		public int? accountId { get; set; }
		public int profit_id { get; set; }
		public int? profitAccountId { get; set; }
		public DateTime from_date { get; set; }
		public DateTime to_date { get; set; }
		public DateTime date { get; set; }
		public int entered_by { get; set; }
		public DateTime entry_date { get; set; }
		public double? total_amount { get; set; }
		public double total_profit { get; set; }
		public double? total_percent { get; set; }
	}
}
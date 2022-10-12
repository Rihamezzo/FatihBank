namespace FatihBank.DTOs
{
    public class MCDDto
    {
		public int? Id { get; set; }
		public int account1_id { get; set; }
		public int? account1Id { get; set; }
		public int account2_id { get; set; }
		public int? account2Id { get; set; }
		public int? profit_id { get; set; }
		public int? profitId { get; set; }
		public double amount { get; set; }
		public double? commission { get; set; }
		public int? type { get; set; }
		public string notes1 { get; set; }
		public string notes2 { get; set; }
		public int entered_by { get; set; }
		public DateTime entry_date { get; set; }
		public string notes_for_profit { get; set; }

		public int? type_of_operation { get; set; }
	}
}

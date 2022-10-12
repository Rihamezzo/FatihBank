namespace FatihBank.DTOs
{
    public class AddToMonthlyListDto
    {
        public int? Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public double percent { get; set; }
        public int profit_id { get; set; }
        public int? profitAccountId { get; set; }
    }
}

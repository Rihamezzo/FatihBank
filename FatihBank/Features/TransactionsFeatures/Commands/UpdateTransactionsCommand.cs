using MediatR;
using System.ComponentModel.DataAnnotations;

namespace FatihBank.Features.TransactionsFeatures.Commands
{
    public class UpdateTransactionsCommand : IRequest
    {
        public int Id { get; set; }
        public int? sub_id { get; set; }
        public int type { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public int cashier_id { get; set; }
        public int? cashierId { get; set; }
        public double current_total { get; set; }
        public double current_total2 { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public int exchange_account { get; set; }
        public int? exchangeId { get; set; }
        public double amount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? date { get; set; }
        public double price { get; set; }
        public double? extra_price { get; set; }
        public int country_id { get; set; }
        public int? countryId { get; set; }
        public string notes { get; set; }
        public string method { get; set; }
        public int entered_by { get; set; }
        public DateTime entry_date { get; set; }
        public double total { get; set; }
        public int currency_2 { get; set; }
        public int? currency2Id { get; set; }
        public double? exchange_account1 { get; set; }
        public double? exchange_account2 { get; set; }
    }
}
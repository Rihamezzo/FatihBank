using FatihBank.Models;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace FatihBank.Features.VouchersFeatures.Commands
{
    public class AddVouchersCommand : IRequest<MSS_DEF_Vouchers>
    {
        public int? Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? date { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public double amount { get; set; }
        public double? total { get; set; }
        public int cashier_id { get; set; }
        public int? cashierId { get; set; }
        public string method { get; set; }
        public string notes { get; set; }
        public int entered_by { get; set; }
        public DateTime? entry_date { get; set; }
        public int type { get; set; }
        public int? transaction_id { get; set; }
        public int? transactionId { get; set; }
        public int? account2_id { get; set; }
        public int? account2Id { get; set; }
        public double current_total { get; set; }
        public double current_total2 { get; set; }
        public int? currency1 { get; set; }
        public int? Currency1Id { get; set; }
        public int? currency2 { get; set; }
        public int? Currency2Id { get; set; }
        public double? price { get; set; }
        public int? type2 { get; set; }
        public int? num { get; set; }
        public double? total_cashier { get; set; }
    }
}
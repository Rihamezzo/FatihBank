
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.OrdersFeatures.Commands
{
    public class AddOrdersCommand : IRequest<MSS_DEF_Orders>
    {
        public int? Id { get; set; }
        public int account_id { get; set; }
        public int? accountId { get; set; }
        public int store_id { get; set; }
        public int? storeId { get; set; }
        public int amount { get; set; }
        public string method { get; set; }
        public string notes { get; set; }
        public int type { get; set; }
        public DateTime date { get; set; }
        public DateTime? last_update { get; set; }
        public int? entered_by { get; set; }
    }
}
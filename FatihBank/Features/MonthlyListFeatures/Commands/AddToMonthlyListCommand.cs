using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MonthlyListFeatures.Commands
{
    public class AddToMonthlyListCommand : IRequest<MSS_CUS_Add_To_Monthly_List>
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
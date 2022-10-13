using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MainAvgFeatures.Commands
{
    public class AddMainAvgCommand : IRequest<MSS_AVG_MainAvg>
    {
        public int? Id { get; set; }
        public int currency_1 { get; set; }
        public int? currency1Id { get; set; }

        public double currency1_amount { get; set; }
        public int currency_2 { get; set; }
        public int? currency2Id { get; set; }

        public double currency2_amount { get; set; }
        public double price { get; set; }

        public DateTime last_update { get; set; }
        public int? exchange_account { get; set; }
        public int? exchangeAccountId { get; set; }
    }
}
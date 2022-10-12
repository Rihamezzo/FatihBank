using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AVGsFeatures.Commands
{
    public class AddAVGsCommand : IRequest<MSS_DEF_AVGs>
    {
        public int? Id { get; set; }
        public int currency_id { get; set; }
        public int? currencyId { get; set; }
        public double amount1 { get; set; }
        public double amount2 { get; set; }
        public double avg { get; set; }
        public int type { get; set; }
        public DateTime last_update { get; set; }
    }
}

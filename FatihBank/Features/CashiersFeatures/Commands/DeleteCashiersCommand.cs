using MediatR;

namespace FatihBank.Features.MSS_DEF_CashiersFeatures.Commands
{
    public class DeleteCashiersCommand : IRequest
    {
        public int Id { get; set; }
    }
}

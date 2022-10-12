using MediatR;

namespace FatihBank.Features.ExchangeAccountsFeatures.Commands
{
    public class DeleteExchangeAccountsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
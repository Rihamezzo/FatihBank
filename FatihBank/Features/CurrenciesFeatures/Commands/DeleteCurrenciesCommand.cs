using MediatR;

namespace FatihBank.Features.MSS_DEF_CurrenciesFeatures.Commands
{
    public class DeleteCurrenciesCommand : IRequest
    {
        public int Id { get; set; }
    }
}
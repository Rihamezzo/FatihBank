using MediatR;

namespace FatihBank.Features.PricesFeatures.Commands
{
    public class DeletePricesCommand : IRequest
    {
        public int Id { get; set; }
    }
}
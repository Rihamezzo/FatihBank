using MediatR;

namespace FatihBank.Features.P_PricesFeatures.Commands
{
    public class DeleteP_PricesCommand : IRequest
    {
        public int Id { get; set; }
    }
}
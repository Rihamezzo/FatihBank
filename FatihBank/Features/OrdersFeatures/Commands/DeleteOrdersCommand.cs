using MediatR;

namespace FatihBank.Features.OrdersFeatures.Commands
{
    public class DeleteOrdersCommand : IRequest
    {
        public int Id { get; set; }
    }
}
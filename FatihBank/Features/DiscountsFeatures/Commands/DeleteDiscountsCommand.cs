using MediatR;

namespace FatihBank.Features.DiscountsFeatures.Commands
{
    public class DeleteDiscountsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
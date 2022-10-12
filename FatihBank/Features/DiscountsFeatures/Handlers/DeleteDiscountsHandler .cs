using FatihBank.Features.DiscountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DiscountsFeatures.Handlers
{
    public class DeleteDiscountsHandler : IRequestHandler<DeleteDiscountsCommand, Unit>
    {
        private readonly IDiscountsRepository discountsRepository;

        public DeleteDiscountsHandler(IDiscountsRepository discountsRepository)
        {
            this.discountsRepository = discountsRepository;
        }

        public async Task<Unit> Handle(DeleteDiscountsCommand request, CancellationToken cancellationToken)
        {
            await discountsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
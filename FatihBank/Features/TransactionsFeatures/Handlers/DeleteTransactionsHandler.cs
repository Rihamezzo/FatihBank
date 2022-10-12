using FatihBank.Features.TransactionsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.TransactionsFeatures.Handlers
{
    public class DeleteTransactionsHandler : IRequestHandler<DeleteTransactionsCommand, Unit>
    {
        private readonly ITransactionsRepository transactionsRepository;

        public DeleteTransactionsHandler(ITransactionsRepository transactionsRepository)
        {
            this.transactionsRepository = transactionsRepository;
        }

        public async Task<Unit> Handle(DeleteTransactionsCommand request, CancellationToken cancellationToken)
        {
            await transactionsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
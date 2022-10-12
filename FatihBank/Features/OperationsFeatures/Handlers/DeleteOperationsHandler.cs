using FatihBank.Features.OperationsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OperationsFeatures.Handlers
{
    public class DeleteOperationsHandler : IRequestHandler<DeleteOperationsCommand, Unit>
    {
        private readonly IOperationsRepository operationsRepository;

        public DeleteOperationsHandler(IOperationsRepository operationsRepository)
        {
            this.operationsRepository = operationsRepository;
        }

        public async Task<Unit> Handle(DeleteOperationsCommand request, CancellationToken cancellationToken)
        {
            await operationsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
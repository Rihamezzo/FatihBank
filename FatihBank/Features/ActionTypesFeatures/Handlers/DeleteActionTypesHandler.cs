using FatihBank.Features.ActionTypesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Handlers
{
    public class DeleteActionTypesHandler : IRequestHandler<DeleteActionTypesCommand, Unit>
    {
        private readonly IActionTypesRepository actionTypesRepository;

        public DeleteActionTypesHandler(IActionTypesRepository actionTypesRepository)
        {
            this.actionTypesRepository = actionTypesRepository;
        }

        public async Task<Unit> Handle(DeleteActionTypesCommand request, CancellationToken cancellationToken)
        {
            await actionTypesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
using FatihBank.Features.ExcusesTypesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Handlers
{
    public class DeleteExcusesTypesHandler : IRequestHandler<DeleteExcusesTypesCommand, Unit>
    {
        private readonly IExcusesTypesRepository excusesTypesRepository;

        public DeleteExcusesTypesHandler(IExcusesTypesRepository excusesTypesRepository)
        {
            this.excusesTypesRepository = excusesTypesRepository;
        }

        public async Task<Unit> Handle(DeleteExcusesTypesCommand request, CancellationToken cancellationToken)
        {
            await excusesTypesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
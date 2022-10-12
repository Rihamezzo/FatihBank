using FatihBank.Features.ExcusesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesFeatures.Handlers
{
    public class DeleteExcusesHandler : IRequestHandler<DeleteExcusesCommand, Unit>
    {
        private readonly IExcusesRepository excusesRepository;

        public DeleteExcusesHandler(IExcusesRepository excusesRepository)
        {
            this.excusesRepository = excusesRepository;
        }

        public async Task<Unit> Handle(DeleteExcusesCommand request, CancellationToken cancellationToken)
        {
            await excusesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
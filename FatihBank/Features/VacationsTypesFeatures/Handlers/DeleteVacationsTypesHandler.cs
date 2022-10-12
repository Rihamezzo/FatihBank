using FatihBank.Features.VacationsTypesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Handlers
{
    public class DeleteVacationsTypesHandler : IRequestHandler<DeleteVacationsTypesCommand, Unit>
    {
        private readonly IVacationsTypesRepository vacationsTypesRepository;

        public DeleteVacationsTypesHandler(IVacationsTypesRepository vacationsTypesRepository)
        {
            this.vacationsTypesRepository = vacationsTypesRepository;
        }

        public async Task<Unit> Handle(DeleteVacationsTypesCommand request, CancellationToken cancellationToken)
        {
            await vacationsTypesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
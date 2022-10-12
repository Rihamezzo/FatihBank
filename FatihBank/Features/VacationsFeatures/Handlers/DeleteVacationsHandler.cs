using FatihBank.Features.VacationsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsFeatures.Handlers
{
    public class DeleteVacationsHandler : IRequestHandler<DeleteVacationsCommand, Unit>
    {
        private readonly IVacationsRepository vacationsRepository;

        public DeleteVacationsHandler(IVacationsRepository vacationsRepository)
        {
            this.vacationsRepository = vacationsRepository;
        }

        public async Task<Unit> Handle(DeleteVacationsCommand request, CancellationToken cancellationToken)
        {
            await vacationsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

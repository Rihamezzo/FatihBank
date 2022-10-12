using FatihBank.Features.IndividualsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.IndividualsFeatures.Handlers
{
    public class DeleteIndividualsHandler : IRequestHandler<DeleteIndividualsCommand, Unit>
    {
        private readonly IIndividualsRepository individualsRepository;

        public DeleteIndividualsHandler(IIndividualsRepository individualsRepository)
        {
            this.individualsRepository = individualsRepository;
        }

        public async Task<Unit> Handle(DeleteIndividualsCommand request, CancellationToken cancellationToken)
        {
            await individualsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

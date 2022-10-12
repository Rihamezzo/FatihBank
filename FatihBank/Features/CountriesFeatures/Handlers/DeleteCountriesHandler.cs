using FatihBank.Features.CountriesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CountriesFeatures.Handlers
{
    public class DeleteCountriesHandler : IRequestHandler<DeleteCountriesCommand, Unit>
    {
        private readonly ICountriesRepository countriesRepository;

        public DeleteCountriesHandler(ICountriesRepository countriesRepository)
        {
            this.countriesRepository = countriesRepository;
        }

        public async Task<Unit> Handle(DeleteCountriesCommand request, CancellationToken cancellationToken)
        {
            await countriesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
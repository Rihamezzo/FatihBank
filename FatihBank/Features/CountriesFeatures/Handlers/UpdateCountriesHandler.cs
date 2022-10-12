using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.CountriesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CountriesFeatures.Handlers
{
    public class UpdateCountriesHandler : IRequestHandler<UpdateCountriesCommand, Unit>
    {
        private readonly ICountriesRepository countriesRepository;
        private readonly IMapper mapper;

        public UpdateCountriesHandler(ICountriesRepository countriesRepository, IMapper mapper)
        {
            this.countriesRepository = countriesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCountriesCommand request, CancellationToken cancellationToken)
        {
            var countriesDto = mapper.Map<CountriesDto>(request);
            await countriesRepository.Update(request.Id, countriesDto);
            return Unit.Value;
        }
    }
}
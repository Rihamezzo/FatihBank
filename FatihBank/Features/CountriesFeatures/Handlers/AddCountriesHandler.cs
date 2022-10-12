using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.CountriesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CountriesFeatures.Handlers
{
    public class AddCountriesHandler : IRequestHandler<AddCountriesCommand, MSS_DEF_Countries>
    {
        private readonly ICountriesRepository countriesRepository;
        private readonly IMapper mapper;

        public AddCountriesHandler(ICountriesRepository countriesRepository, IMapper mapper)
        {
            this.countriesRepository = countriesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Countries> Handle(AddCountriesCommand request, CancellationToken cancellationToken)
        {
            var countriesDto = mapper.Map<CountriesDto>(request);
            return await countriesRepository.Add(countriesDto);
        }
    }
}

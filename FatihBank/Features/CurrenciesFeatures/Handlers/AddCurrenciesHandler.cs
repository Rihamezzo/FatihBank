using MediatR;
using FatihBank.Features.MSS_DEF_CurrenciesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using AutoMapper;
using FatihBank.DTOs;

namespace FatihBank.Features.MSS_DEF_CurrenciesFeatures.Handlers
{
    public class AddCurrenciesHandler : IRequestHandler<AddCurrenciesCommand, MSS_DEF_Currencies>
    {
        private readonly ICurrenciesRepository currenciesRepository;
        private readonly IMapper mapper;

        public AddCurrenciesHandler(ICurrenciesRepository currenciesRepository, IMapper mapper)
        {
            this.currenciesRepository = currenciesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Currencies> Handle(AddCurrenciesCommand request, CancellationToken cancellationToken)
        {
            var currenciesDto = mapper.Map<CurrenciesDto>(request);
            return await currenciesRepository.Add(currenciesDto);
        }
    }
}

using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CurrenciesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CurrenciesFeatures.Handlers
{
    public class UpdateCurrenciesHandler : IRequestHandler<UpdateCurrenciesCommand, Unit>
    {
        private readonly ICurrenciesRepository currenciesRepository;
        private readonly IMapper mapper;

        public UpdateCurrenciesHandler(ICurrenciesRepository currenciesRepository, IMapper mapper)
        {
            this.currenciesRepository = currenciesRepository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateCurrenciesCommand request, CancellationToken cancellationToken)
        {
            var currenciesDto = mapper.Map<CurrenciesDto>(request);
            await currenciesRepository.Update(request.Id, currenciesDto);
            return Unit.Value;
        }
    }
}

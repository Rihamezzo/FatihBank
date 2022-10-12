using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ExchangeAccountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExchangeAccountsFeatures.Handlers
{
    public class UpdateExchangeAccountsHandler : IRequestHandler<UpdateExchangeAccountsCommand, Unit>
    {
        private readonly IExchangeAccountsRepository exchangeAccountsRepository;
        private readonly IMapper mapper;

        public UpdateExchangeAccountsHandler(IExchangeAccountsRepository exchangeAccountsRepository, IMapper mapper)
        {
            this.exchangeAccountsRepository = exchangeAccountsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateExchangeAccountsCommand request, CancellationToken cancellationToken)
        {
            var exchangeAccountsDto = mapper.Map<ExchangeAccountsDto>(request);
            await exchangeAccountsRepository.Update(request.Id, exchangeAccountsDto);
            return Unit.Value;
        }
    }
}

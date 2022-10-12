using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ExchangeAccountsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExchangeAccountsFeatures.Handlers
{
    public class AddExchangeAccountsHandler : IRequestHandler<AddExchangeAccountsCommand, MSS_DEF_Exchange_Accounts>
    {
        private readonly IExchangeAccountsRepository exchangeAccountsRepository;
        private readonly IMapper mapper;

        public AddExchangeAccountsHandler(IExchangeAccountsRepository exchangeAccountsRepository, IMapper mapper)
        {
            this.exchangeAccountsRepository = exchangeAccountsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Exchange_Accounts> Handle(AddExchangeAccountsCommand request, CancellationToken cancellationToken)
        {
            var exchangeAccountsDto = mapper.Map<ExchangeAccountsDto>(request);
            return await exchangeAccountsRepository.Add(exchangeAccountsDto);
        }
    }
}
using FatihBank.DTOs;
using FatihBank.Features.ExchangeAccountsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExchangeAccountsFeatures.Handlers
{
    public class ListAllExchangeAccountsHandler : IRequestHandler<ListAllExchangeAccountsQuery, PaginationResponse<MSS_DEF_Exchange_Accounts>>
    {
        private readonly IExchangeAccountsRepository exchangeAccountsRepository;

        public ListAllExchangeAccountsHandler(IExchangeAccountsRepository exchangeAccountsRepository)
        {
            this.exchangeAccountsRepository = exchangeAccountsRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Exchange_Accounts>> Handle(ListAllExchangeAccountsQuery request, CancellationToken cancellationToken)
        {
            return await exchangeAccountsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
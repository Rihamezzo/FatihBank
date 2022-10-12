using MediatR;
using FatihBank.Repositories;
using FatihBank.Models;
using FatihBank.Features.MSS_DEF_CurrenciesFeatures.Queries;
using FatihBank.DTOs;

namespace FatihBank.Features.MSS_DEF_CurrenciesFeatures.Handlers
{
    public class ListAllCurrenciesHandler : IRequestHandler<ListAllCurrenciesQuery ,PaginationResponse<MSS_DEF_Currencies>>
    {
        private readonly ICurrenciesRepository currenciesRepository;

        public ListAllCurrenciesHandler(ICurrenciesRepository currenciesRepository)
        {
            this.currenciesRepository = currenciesRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Currencies>> Handle(ListAllCurrenciesQuery request, CancellationToken cancellationToken)
        {
            return await currenciesRepository.ListAll(request.page, request.pageSize);
        }
    }
}

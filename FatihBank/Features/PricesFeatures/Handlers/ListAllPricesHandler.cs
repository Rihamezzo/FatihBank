using FatihBank.DTOs;
using FatihBank.Features.PricesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PricesFeatures.Handlers
{
    public class ListAllPricesHandler : IRequestHandler<ListAllPricesQuery, PaginationResponse<MSS_DEF_Prices>>
    {
        private readonly IPricesRepository pricesRepository;

        public ListAllPricesHandler(IPricesRepository pricesRepository)
        {
            this.pricesRepository = pricesRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Prices>> Handle(ListAllPricesQuery request, CancellationToken cancellationToken)
        {
            return await pricesRepository.ListAll(request.page, request.pageSize);
        }
    }
}

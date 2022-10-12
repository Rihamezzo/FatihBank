using FatihBank.DTOs;
using FatihBank.Features.P_PricesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.P_PricesFeatures.Handlers
{
    public class ListAllP_PricesHandler : IRequestHandler<ListAllP_PricesQuery, PaginationResponse<MSS_DEF_P_Prices>>
    {
        private readonly IP_PricesRepository p_PricesRepository;

        public ListAllP_PricesHandler(IP_PricesRepository p_PricesRepository)
        {
            this.p_PricesRepository = p_PricesRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_P_Prices>> Handle(ListAllP_PricesQuery request, CancellationToken cancellationToken)
        {
            return await p_PricesRepository.ListAll(request.page, request.pageSize);
        }
    }
}
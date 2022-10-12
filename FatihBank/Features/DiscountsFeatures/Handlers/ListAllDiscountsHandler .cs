using FatihBank.DTOs;
using FatihBank.Features.DiscountsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DiscountsFeatures.Handlers
{
    public class ListAllDiscountsHandler : IRequestHandler<ListAllDiscountsQuery, PaginationResponse<MSS_ATT_Discounts>>
    {
        private readonly IDiscountsRepository discountsRepository;

        public ListAllDiscountsHandler(IDiscountsRepository discountsRepository)
        {
            this.discountsRepository = discountsRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_Discounts>> Handle(ListAllDiscountsQuery request, CancellationToken cancellationToken)
        {
            return await discountsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
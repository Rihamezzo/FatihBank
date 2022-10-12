using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CashiersFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CashiersFeatures.Handlers
{
    public class ListAllCashiersHandler : IRequestHandler<ListAllCashiersQuery, PaginationResponse<MSS_DEF_Cashiers>>
    {
        private readonly ICashiersRepository cashiersRepository;

        public ListAllCashiersHandler(ICashiersRepository cashiersRepository)
        {
            this.cashiersRepository = cashiersRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Cashiers>> Handle(ListAllCashiersQuery request, CancellationToken cancellationToken)
        {
            return await cashiersRepository.ListAll(request.page, request.pageSize);
        }
    }
}

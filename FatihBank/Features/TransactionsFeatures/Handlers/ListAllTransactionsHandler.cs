using FatihBank.DTOs;
using FatihBank.Features.TransactionsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.TransactionsFeatures.Handlers
{
    public class ListAllTransactionsHandler : IRequestHandler<ListAllTransactionsQuery, PaginationResponse<MSS_DEF_Transactions>>
    {
        private readonly ITransactionsRepository transactionsRepository;

        public ListAllTransactionsHandler(ITransactionsRepository transactionsRepository)
        {
            this.transactionsRepository = transactionsRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Transactions>> Handle(ListAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            return await transactionsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
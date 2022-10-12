using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_AccountsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AccountsFeatures.Handlers
{
    public class ListAllAccountsHandler : IRequestHandler<ListAllAccountsQuery, PaginationResponse<MSS_DEF_Accounts>>
    {
        private readonly IAccountsRepository accountsRepository;

        public ListAllAccountsHandler(IAccountsRepository accountsRepository)
        {
            this.accountsRepository = accountsRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Accounts>> Handle(ListAllAccountsQuery request, CancellationToken cancellationToken)
        {
            return await accountsRepository.ListAll(request.page, request.pageSize);
        }
    }
}

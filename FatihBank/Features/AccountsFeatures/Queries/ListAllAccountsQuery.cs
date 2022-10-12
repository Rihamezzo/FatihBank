using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AccountsFeatures.Queries
{
    public class ListAllAccountsQuery : IRequest<PaginationResponse<MSS_DEF_Accounts>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllAccountsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}

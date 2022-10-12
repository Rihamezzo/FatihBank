
using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ExchangeAccountsFeatures.Queries
{
    public class ListAllExchangeAccountsQuery : IRequest<PaginationResponse<MSS_DEF_Exchange_Accounts>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllExchangeAccountsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
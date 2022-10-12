using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CurrenciesFeatures.Queries
{
    public class ListAllCurrenciesQuery : IRequest<PaginationResponse<MSS_DEF_Currencies>>
    {
        public int page;
        public int pageSize;

        public ListAllCurrenciesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}

using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.TransactionsFeatures.Queries
{
    public class ListAllTransactionsQuery : IRequest<PaginationResponse<MSS_DEF_Transactions>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllTransactionsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
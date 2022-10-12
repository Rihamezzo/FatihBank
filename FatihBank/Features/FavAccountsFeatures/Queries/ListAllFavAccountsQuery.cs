using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Queries
{
    public class ListAllFavAccountsQuery : IRequest<PaginationResponse<MSS_FAV_FavAccounts>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllFavAccountsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
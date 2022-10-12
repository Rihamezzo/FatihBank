using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.CountriesFeatures.Queries
{
    public class ListAllCountriesQuery : IRequest<PaginationResponse<MSS_DEF_Countries>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllCountriesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
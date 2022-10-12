///ListAllQuery

using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Queries
{
    public class ListAllVacationsTypesQuery : IRequest<PaginationResponse<MSS_ATT_VacationsTypes>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllVacationsTypesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
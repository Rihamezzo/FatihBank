using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.CompaniesFeatures.Queries
{
    public class ListAllCompaniesQuery : IRequest<PaginationResponse<MSS_TRS_Companies>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllCompaniesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
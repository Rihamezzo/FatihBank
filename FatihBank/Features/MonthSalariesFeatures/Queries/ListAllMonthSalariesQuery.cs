
using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MonthSalariesFeatures.Queries
{
    public class ListAllMonthSalariesQuery : IRequest<PaginationResponse<MSS_ATT_Month_Salaries>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllMonthSalariesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
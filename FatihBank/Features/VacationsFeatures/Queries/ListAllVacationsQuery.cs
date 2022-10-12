
using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.VacationsFeatures.Queries
{
    public class ListAllVacationsQuery : IRequest<PaginationResponse<MSS_ATT_Vacations>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllVacationsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
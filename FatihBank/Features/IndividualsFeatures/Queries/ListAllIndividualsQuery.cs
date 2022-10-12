using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.IndividualsFeatures.Queries
{
    public class ListAllIndividualsQuery : IRequest<PaginationResponse<MSS_TRS_Individuals>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllIndividualsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
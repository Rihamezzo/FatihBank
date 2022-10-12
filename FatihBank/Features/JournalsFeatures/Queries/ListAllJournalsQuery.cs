
using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.JournalsFeatures.Queries
{
    public class ListAllJournalsQuery : IRequest<PaginationResponse<MSS_DEF_Journals>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllJournalsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }

    public class ListAllJournalsDetailsQuery : IRequest<PaginationResponse<MSS_JOU_Details>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllJournalsDetailsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
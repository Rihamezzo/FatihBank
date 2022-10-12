using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.SMSFeatures.Queries
{
    public class ListAllSMSQuery : IRequest<PaginationResponse<MSS_DEF_SMS>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllSMSQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.RegisterationFileFeatures.Queries
{
    public class ListAllRegisterationFileQuery : IRequest<PaginationResponse<MSS_INF_RegisterationFile>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllRegisterationFileQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
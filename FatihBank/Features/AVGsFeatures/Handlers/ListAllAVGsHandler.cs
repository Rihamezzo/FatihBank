using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_AVGsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AVGsFeatures.Handlers
{
    public class ListAllAVGsHandler : IRequestHandler<ListAllAVGsQuery, PaginationResponse<MSS_DEF_AVGs>>
    {
        private readonly IAVGsRepository aVGsRepository;

        public ListAllAVGsHandler(IAVGsRepository aVGsRepository)
        {
            this.aVGsRepository = aVGsRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_AVGs>> Handle(ListAllAVGsQuery request, CancellationToken cancellationToken)
        {
            return await aVGsRepository.ListAll(request.page, request.pageSize);
        }
    }
}

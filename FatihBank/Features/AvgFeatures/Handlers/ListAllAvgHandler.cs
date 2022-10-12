using FatihBank.DTOs;
using FatihBank.Features.AvgFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.AvgFeatures.Handlers
{
    public class ListAllAvgHandler : IRequestHandler<ListAllAvgQuery, PaginationResponse<MSS_FIN_Avg>>
    {
        private readonly IAvgRepository avgRepository;

        public ListAllAvgHandler(IAvgRepository avgRepository)
        {
            this.avgRepository = avgRepository;
        }

        public async Task<PaginationResponse<MSS_FIN_Avg>> Handle(ListAllAvgQuery request, CancellationToken cancellationToken)
        {
            return await avgRepository.ListAll(request.page, request.pageSize);
        }
    }
}

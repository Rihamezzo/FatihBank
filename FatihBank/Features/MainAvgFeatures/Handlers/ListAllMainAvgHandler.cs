using FatihBank.DTOs;
using FatihBank.Features.MainAvgFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MainAvgFeatures.Handlers
{
    public class ListAllMainAvgHandler : IRequestHandler<ListAllMainAvgQuery, PaginationResponse<MSS_AVG_MainAvg>>
    {
        private readonly IMainAvgRepository mainAvgRepository;

        public ListAllMainAvgHandler(IMainAvgRepository mainAvgRepository)
        {
            this.mainAvgRepository = mainAvgRepository;
        }

        public async Task<PaginationResponse<MSS_AVG_MainAvg>> Handle(ListAllMainAvgQuery request, CancellationToken cancellationToken)
        {
            return await mainAvgRepository.ListAll(request.page, request.pageSize);
        }
    }
}

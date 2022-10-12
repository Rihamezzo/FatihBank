using FatihBank.DTOs;
using FatihBank.Features.MonthInfoFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthInfoFeatures.Handlers
{
    public class ListAllMonthInfoHandler : IRequestHandler<ListAllMonthInfoQuery, PaginationResponse<MSS_ATT_Month_Info>>
    {
        private readonly IMonthInfoRepository monthInfoRepository;

        public ListAllMonthInfoHandler(IMonthInfoRepository monthInfoRepository)
        {
            this.monthInfoRepository = monthInfoRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_Month_Info>> Handle(ListAllMonthInfoQuery request, CancellationToken cancellationToken)
        {
            return await monthInfoRepository.ListAll(request.page, request.pageSize);
        }
    }
}

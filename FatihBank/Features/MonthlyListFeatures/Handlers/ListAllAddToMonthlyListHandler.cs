using FatihBank.DTOs;
using FatihBank.Features.MonthlyListFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthlyListFeatures.Handlers
{
    public class ListAllMonthlyListHandler : IRequestHandler<ListAllMonthlyListQuery, PaginationResponse<MSS_CUS_Add_To_Monthly_List>>
    
    {
        private readonly IAddToMonthlyListRepository addToMonthlyListRepository;

        public ListAllMonthlyListHandler(IAddToMonthlyListRepository addToMonthlyListRepository)
        {
            this.addToMonthlyListRepository = addToMonthlyListRepository;
        }

        public async Task<PaginationResponse<MSS_CUS_Add_To_Monthly_List>> Handle(ListAllMonthlyListQuery request, CancellationToken cancellationToken)
        {
            return await addToMonthlyListRepository.ListAll(request.page, request.pageSize);
        }
    }
}

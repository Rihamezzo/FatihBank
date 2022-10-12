using FatihBank.DTOs;
using FatihBank.Features.MonthSalariesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthSalariesFeatures.Handlers
{
    public class ListAllMonthSalariesHandler : IRequestHandler<ListAllMonthSalariesQuery, PaginationResponse<MSS_ATT_Month_Salaries>>
    {
        private readonly IMonthSalariesRepository monthSalariesRepository;

        public ListAllMonthSalariesHandler(IMonthSalariesRepository monthSalariesRepository)
        {
            this.monthSalariesRepository = monthSalariesRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_Month_Salaries>> Handle(ListAllMonthSalariesQuery request, CancellationToken cancellationToken)
        {
            return await monthSalariesRepository.ListAll(request.page, request.pageSize);
        }
    }
}
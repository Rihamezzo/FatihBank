using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CommissionFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CommissionFeatures.Handlers
{
    public class ListCommissionHandler : IRequestHandler<ListAllCommissionQuery, PaginationResponse<MSS_DEF_Commission>>
    {
        private readonly ICommissionRepository commissionRepository;

        public ListCommissionHandler(ICommissionRepository commissionRepository)
        {
            this.commissionRepository = commissionRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Commission>> Handle(ListAllCommissionQuery request, CancellationToken cancellationToken)
        {
           return await commissionRepository.ListAll(request.page, request.pageSize);
        }
    }
}

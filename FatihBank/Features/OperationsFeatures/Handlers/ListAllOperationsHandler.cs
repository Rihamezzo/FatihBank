using FatihBank.DTOs;
using FatihBank.Features.OperationsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OperationsFeatures.Handlers
{
    public class ListAllOperationsHandler : IRequestHandler<ListAllOperationsQuery, PaginationResponse<MSS_CAS_Operations>>
    {
        private readonly IOperationsRepository operationsRepository;

        public ListAllOperationsHandler(IOperationsRepository operationsRepository)
        {
            this.operationsRepository = operationsRepository;
        }

        public async Task<PaginationResponse<MSS_CAS_Operations>> Handle(ListAllOperationsQuery request, CancellationToken cancellationToken)
        {
            return await operationsRepository.ListAll(request.page, request.pageSize);
        }
    }
}

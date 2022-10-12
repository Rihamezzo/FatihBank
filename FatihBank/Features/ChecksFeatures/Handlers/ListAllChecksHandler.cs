using FatihBank.DTOs;
using FatihBank.Features.ChecksFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChecksFeatures.Handlers
{
    public class ListAllChecksHandler : IRequestHandler<ListAllChecksQuery, PaginationResponse<MSS_ACC_Checks>>
    {
        private readonly IChecksRepository checksRepository;

        public ListAllChecksHandler(IChecksRepository checksRepository)
        {
            this.checksRepository = checksRepository;
        }

        public async Task<PaginationResponse<MSS_ACC_Checks>> Handle(ListAllChecksQuery request, CancellationToken cancellationToken)
        {
           return await checksRepository.ListAll(request.page, request.pageSize);
           
        }
    }
}

using FatihBank.DTOs;
using FatihBank.Features.StoresFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.StoresFeatures.Handlers
{
    public class ListAllStoresHandler : IRequestHandler<ListAllStoresQuery, PaginationResponse<MSS_DEF_Stores>>
    {
        private readonly IStoresRepository storesRepository;

        public ListAllStoresHandler(IStoresRepository storesRepository)
        {
            this.storesRepository = storesRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Stores>> Handle(ListAllStoresQuery request, CancellationToken cancellationToken)
        {
            return await storesRepository.ListAll(request.page, request.pageSize);
        }
    }
}

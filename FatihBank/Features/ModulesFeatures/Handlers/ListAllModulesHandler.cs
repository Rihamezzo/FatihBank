using FatihBank.DTOs;
using FatihBank.Features.ModulesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Handlers
{
    public class ListAllModulesHandler : IRequestHandler<ListAllModulesQuery, PaginationResponse<MSS_DEF_Modules>>
    {
        private readonly IModulesRepository modulesRepository;

        public ListAllModulesHandler(IModulesRepository modulesRepository)
        {
            this.modulesRepository = modulesRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Modules>> Handle(ListAllModulesQuery request, CancellationToken cancellationToken)
        {
            return await modulesRepository.ListAll(request.page, request.pageSize);
        }
    }
}

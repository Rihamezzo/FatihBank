using FatihBank.DTOs;
using FatihBank.Features.PermissionsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PermissionsFeatures.Handlers
{
    public class ListAllPermissionsHandler : IRequestHandler<ListAllPermissionsQuery, PaginationResponse<MSS_DEF_Permissions>>
    {
        private readonly IPermissionsRepository permissionsRepository;

        public ListAllPermissionsHandler(IPermissionsRepository permissionsRepository)
        {
            this.permissionsRepository = permissionsRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Permissions>> Handle(ListAllPermissionsQuery request, CancellationToken cancellationToken)
        {
            return await permissionsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
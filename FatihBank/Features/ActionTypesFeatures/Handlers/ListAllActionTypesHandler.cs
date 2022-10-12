using FatihBank.DTOs;
using FatihBank.Features.ActionTypesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Handlers
{
    public class ListAllActionTypesHandler : IRequestHandler<ListAllActionTypesQuery, PaginationResponse<MSS_INF_Action_Types>>
    {
        private readonly IActionTypesRepository actionTypesRepository;

        public ListAllActionTypesHandler(IActionTypesRepository actionTypesRepository)
        {
            this.actionTypesRepository = actionTypesRepository;
        }

        public async Task<PaginationResponse<MSS_INF_Action_Types>> Handle(ListAllActionTypesQuery request, CancellationToken cancellationToken)
        {
            return await actionTypesRepository.ListAll(request.page, request.pageSize);
        }
    }
}

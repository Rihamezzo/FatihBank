using FatihBank.DTOs;
using FatihBank.Features.GroupsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.GroupsFeatures.Handlers
{
    public class ListAllGroupsHandler : IRequestHandler<ListAllGroupsQuery, PaginationResponse<MSS_DEF_Groups>>
    {
        private readonly IGroupsRepository groupsRepository;

        public ListAllGroupsHandler(IGroupsRepository groupsRepository)
        {
            this.groupsRepository = groupsRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Groups>> Handle(ListAllGroupsQuery request, CancellationToken cancellationToken)
        {
            return await groupsRepository.ListAll(request.page, request.pageSize);
        }
    }
}   
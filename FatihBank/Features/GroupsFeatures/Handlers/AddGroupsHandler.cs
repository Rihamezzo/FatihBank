using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.GroupsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.GroupsFeatures.Handlers
{
    public class AddGroupsHandler : IRequestHandler<AddGroupsCommand, MSS_DEF_Groups>
    {
        private readonly IGroupsRepository groupsRepository;
        private readonly IMapper mapper;

        public AddGroupsHandler(IGroupsRepository groupsRepository, IMapper mapper)
        {
            this.groupsRepository = groupsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Groups> Handle(AddGroupsCommand request, CancellationToken cancellationToken)
        {
            var groupsDto = mapper.Map<GroupsDto>(request);
            return await groupsRepository.Add(groupsDto);
        }
    }
}
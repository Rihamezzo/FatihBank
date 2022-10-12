using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.GroupsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.GroupsFeatures.Handlers
{
    public class UpdateGroupsHandler : IRequestHandler<UpdateGroupsCommand, Unit>
    {
        private readonly IGroupsRepository groupsRepository;
        private readonly IMapper mapper;

        public UpdateGroupsHandler(IGroupsRepository groupsRepository, IMapper mapper)
        {
            this.groupsRepository = groupsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateGroupsCommand request, CancellationToken cancellationToken)
        {
            var groupsDto = mapper.Map<GroupsDto>(request);
            await groupsRepository.Update(request.Id, groupsDto);
            return Unit.Value;
        }
    }
}
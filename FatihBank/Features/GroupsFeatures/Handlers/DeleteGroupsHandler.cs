using FatihBank.Features.GroupsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.GroupsFeatures.Handlers
{
    public class DeleteGroupsHandler : IRequestHandler<DeleteGroupsCommand, Unit>
    {
        private readonly IGroupsRepository groupsRepository;

        public DeleteGroupsHandler(IGroupsRepository groupsRepository)
        {
            this.groupsRepository = groupsRepository;
        }

        public async Task<Unit> Handle(DeleteGroupsCommand request, CancellationToken cancellationToken)
        {
            await groupsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

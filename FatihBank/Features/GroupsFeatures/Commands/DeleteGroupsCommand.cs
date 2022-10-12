using MediatR;

namespace FatihBank.Features.GroupsFeatures.Commands
{
    public class DeleteGroupsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
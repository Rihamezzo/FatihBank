
using MediatR;

namespace FatihBank.Features.GroupsFeatures.Commands
{
    public class UpdateGroupsCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
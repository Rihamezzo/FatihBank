
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.GroupsFeatures.Commands
{
    public class AddGroupsCommand : IRequest<MSS_DEF_Groups>
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
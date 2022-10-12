using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Commands
{
    public class AddModulesCommand : IRequest<MSS_DEF_Modules>
    {
        public int? Id { get; set; }
        public string name { get; set; }
        public int? group { get; set; }
        public virtual ICollection<PermissionsDto>? permissions { get; set; }
    }
}
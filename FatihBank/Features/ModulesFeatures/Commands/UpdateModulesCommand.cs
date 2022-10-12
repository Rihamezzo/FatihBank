using FatihBank.DTOs;
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Commands
{
    public class UpdateModulesCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int? group { get; set; }
        public virtual ICollection<PermissionsDto>? permissions { get; set; }
    }
}
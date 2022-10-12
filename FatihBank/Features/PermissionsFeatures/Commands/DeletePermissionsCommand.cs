using MediatR;

namespace FatihBank.Features.PermissionsFeatures.Commands
{
    public class DeletePermissionsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
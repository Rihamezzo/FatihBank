using FatihBank.Features.PermissionsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PermissionsFeatures.Handlers
{
    public class DeletePermissionsHandler : IRequestHandler<DeletePermissionsCommand, Unit>
    {
        private readonly IPermissionsRepository permissionsRepository;

        public DeletePermissionsHandler(IPermissionsRepository permissionsRepository)
        {
            this.permissionsRepository = permissionsRepository;
        }

        public async Task<Unit> Handle(DeletePermissionsCommand request, CancellationToken cancellationToken)
        {
            await permissionsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
using FatihBank.Features.ModulesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Handlers
{
    public class DeleteModulesHandler : IRequestHandler<DeleteModulesCommand, Unit>
    {
        private readonly IModulesRepository modulesRepository;

        public DeleteModulesHandler(IModulesRepository modulesRepository)
        {
            this.modulesRepository = modulesRepository;
        }

        public async Task<Unit> Handle(DeleteModulesCommand request, CancellationToken cancellationToken)
        {
            await modulesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
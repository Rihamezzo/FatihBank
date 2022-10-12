using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ModulesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Handlers
{
    public class UpdateModulesHandler : IRequestHandler<UpdateModulesCommand, Unit>
    {
        private readonly IModulesRepository modulesRepository;
        private readonly IMapper mapper;

        public UpdateModulesHandler(IModulesRepository modulesRepository, IMapper mapper)
        {
            this.modulesRepository = modulesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateModulesCommand request, CancellationToken cancellationToken)
        {
            var modulesDto = mapper.Map<ModulesDto>(request);
            await modulesRepository.Update(request.Id, modulesDto);
            return Unit.Value;
        }
    }
}
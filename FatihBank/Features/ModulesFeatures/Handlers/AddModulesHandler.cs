using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ModulesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Handlers
{
    public class AddModulesHandler : IRequestHandler<AddModulesCommand, MSS_DEF_Modules>
    {
        private readonly IModulesRepository modulesRepository;
        private readonly IMapper mapper;

        public AddModulesHandler(IModulesRepository modulesRepository, IMapper mapper)
        {
            this.modulesRepository = modulesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Modules> Handle(AddModulesCommand request, CancellationToken cancellationToken)
        {
            var modulesDto = mapper.Map<ModulesDto>(request);
            return await modulesRepository.Add(modulesDto);
        }
    }
}
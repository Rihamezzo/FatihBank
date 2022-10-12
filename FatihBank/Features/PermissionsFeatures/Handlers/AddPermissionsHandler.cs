
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.PermissionsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PermissionsFeatures.Handlers
{
    public class AddPermissionsHandler : IRequestHandler<AddPermissionsCommand, MSS_DEF_Permissions>
    {
        private readonly IPermissionsRepository permissionsRepository;
        private readonly IMapper mapper;

        public AddPermissionsHandler(IPermissionsRepository permissionsRepository, IMapper mapper)
        {
            this.permissionsRepository = permissionsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Permissions> Handle(AddPermissionsCommand request, CancellationToken cancellationToken)
        {
            var permissionsDto = mapper.Map<PermissionsDto>(request);
            return await permissionsRepository.Add(permissionsDto);
        }
    }
}
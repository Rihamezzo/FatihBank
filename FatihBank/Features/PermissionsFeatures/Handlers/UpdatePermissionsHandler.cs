using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.PermissionsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PermissionsFeatures.Handlers
{
    public class UpdatePermissionsHandler : IRequestHandler<UpdatePermissionsCommand, Unit>
    {
        private readonly IPermissionsRepository permissionsRepository;
        private readonly IMapper mapper;

        public UpdatePermissionsHandler(IPermissionsRepository permissionsRepository, IMapper mapper)
        {
            this.permissionsRepository = permissionsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePermissionsCommand request, CancellationToken cancellationToken)
        {
            var permissionsDto = mapper.Map<PermissionsDto>(request);
            await permissionsRepository.Update(request.Id, permissionsDto);
            return Unit.Value;
        }
    }
}
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ActionTypesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Handlers
{
    public class UpdateActionTypesHandler : IRequestHandler<UpdateActionTypesCommand, Unit>
    {
        private readonly IActionTypesRepository actionTypesRepository;
        private readonly IMapper mapper;

        public UpdateActionTypesHandler(IActionTypesRepository actionTypesRepository, IMapper mapper)
        {
            this.actionTypesRepository = actionTypesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateActionTypesCommand request, CancellationToken cancellationToken)
        {
            var actionTypesDto = mapper.Map<ActionTypesDto>(request);
            await actionTypesRepository.Update(request.Id, actionTypesDto);
            return Unit.Value;
        }
    }
}

using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ActionTypesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Handlers
{
    public class AddActionTypesHandler : IRequestHandler<AddActionTypesCommand, MSS_INF_Action_Types>
    {
        private readonly IActionTypesRepository actionTypesRepository;
        private readonly IMapper mapper;

        public AddActionTypesHandler(IActionTypesRepository actionTypesRepository, IMapper mapper)
        {
            this.actionTypesRepository = actionTypesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_INF_Action_Types> Handle(AddActionTypesCommand request, CancellationToken cancellationToken)
        {
            var actionTypesDto = mapper.Map<ActionTypesDto>(request);
            return await actionTypesRepository.Add(actionTypesDto);
        }
    }
}

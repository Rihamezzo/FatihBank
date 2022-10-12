using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ExcusesTypesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Handlers
{
    public class AddExcusesTypesHandler : IRequestHandler<AddExcusesTypesCommand, MSS_ATT_ExcusesTypes>
    {
        private readonly IExcusesTypesRepository excusesTypesRepository;
        private readonly IMapper mapper;

        public AddExcusesTypesHandler(IExcusesTypesRepository excusesTypesRepository, IMapper mapper)
        {
            this.excusesTypesRepository = excusesTypesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_ExcusesTypes> Handle(AddExcusesTypesCommand request, CancellationToken cancellationToken)
        {
            var excusesTypesDto = mapper.Map<ExcusesTypesDto>(request);
            return await excusesTypesRepository.Add(excusesTypesDto);
        }
    }
}
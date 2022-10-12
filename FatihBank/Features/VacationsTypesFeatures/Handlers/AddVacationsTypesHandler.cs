using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.VacationsTypesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Handlers
{
    public class AddVacationsTypesHandler : IRequestHandler<AddVacationsTypesCommand, MSS_ATT_VacationsTypes>
    {
        private readonly IVacationsTypesRepository vacationsTypesRepository;
        private readonly IMapper mapper;

        public AddVacationsTypesHandler(IVacationsTypesRepository vacationsTypesRepository, IMapper mapper)
        {
            this.vacationsTypesRepository = vacationsTypesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_VacationsTypes> Handle(AddVacationsTypesCommand request, CancellationToken cancellationToken)
        {
            var vacationsTypesDto = mapper.Map<VacationsTypesDto>(request);
            return await vacationsTypesRepository.Add(vacationsTypesDto);
        }
    }
}
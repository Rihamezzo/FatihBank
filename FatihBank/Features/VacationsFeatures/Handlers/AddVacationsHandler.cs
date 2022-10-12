using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.VacationsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsFeatures.Handlers
{
    public class AddVacationsHandler : IRequestHandler<AddVacationsCommand, MSS_ATT_Vacations>
    {
        private readonly IVacationsRepository vacationsRepository;
        private readonly IMapper mapper;

        public AddVacationsHandler(IVacationsRepository vacationsRepository, IMapper mapper)
        {
            this.vacationsRepository = vacationsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_Vacations> Handle(AddVacationsCommand request, CancellationToken cancellationToken)
        {
            var vacationsDto = mapper.Map<VacationsDto>(request);
            return await vacationsRepository.Add(vacationsDto);
        }
    }
}
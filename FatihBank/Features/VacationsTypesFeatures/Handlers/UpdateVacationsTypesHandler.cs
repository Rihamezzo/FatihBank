using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.VacationsTypesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsTypesFeatures.Handlers
{
    public class UpdateVacationsTypesHandler : IRequestHandler<UpdateVacationsTypesCommand, Unit>
    {
        private readonly IVacationsTypesRepository vacationsTypesRepository;
        private readonly IMapper mapper;

        public UpdateVacationsTypesHandler(IVacationsTypesRepository vacationsTypesRepository, IMapper mapper)
        {
            this.vacationsTypesRepository = vacationsTypesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateVacationsTypesCommand request, CancellationToken cancellationToken)
        {
            var vacationsTypesDto = mapper.Map<VacationsTypesDto>(request);
            await vacationsTypesRepository.Update(request.Id, vacationsTypesDto);
            return Unit.Value;
        }
    }
}
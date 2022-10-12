using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.VacationsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VacationsFeatures.Handlers
{
    public class UpdateVacationsHandler : IRequestHandler<UpdateVacationsCommand, Unit>
    {
        private readonly IVacationsRepository vacationsRepository;
        private readonly IMapper mapper;

        public UpdateVacationsHandler(IVacationsRepository vacationsRepository, IMapper mapper)
        {
            this.vacationsRepository = vacationsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateVacationsCommand request, CancellationToken cancellationToken)
        {
            var vacationsDto = mapper.Map<VacationsDto>(request);
            await vacationsRepository.Update(request.Id, vacationsDto);
            return Unit.Value;
        }
    }
}

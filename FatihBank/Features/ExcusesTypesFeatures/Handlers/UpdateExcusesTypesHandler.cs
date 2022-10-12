using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ExcusesTypesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Handlers
{
    public class UpdateExcusesTypesHandler : IRequestHandler<UpdateExcusesTypesCommand, Unit>
    {
        private readonly IExcusesTypesRepository excusesTypesRepository;
        private readonly IMapper mapper;

        public UpdateExcusesTypesHandler(IExcusesTypesRepository excusesTypesRepository, IMapper mapper)
        {
            this.excusesTypesRepository = excusesTypesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateExcusesTypesCommand request, CancellationToken cancellationToken)
        {
            var excusesTypesDto = mapper.Map<ExcusesTypesDto>(request);
            await excusesTypesRepository.Update(request.Id, excusesTypesDto);
            return Unit.Value;
        }
    }
}

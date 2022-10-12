using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ExcusesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExcusesFeatures.Handlers
{
    public class UpdateExcusesHandler : IRequestHandler<UpdateExcusesCommand, Unit>
    {
        private readonly IExcusesRepository excusesRepository;
        private readonly IMapper mapper;

        public UpdateExcusesHandler(IExcusesRepository excusesRepository, IMapper mapper)
        {
            this.excusesRepository = excusesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateExcusesCommand request, CancellationToken cancellationToken)
        {
            var excusesDto = mapper.Map<ExcusesDto>(request);
            await excusesRepository.Update(request.Id, excusesDto);
            return Unit.Value;
        }
    }
}
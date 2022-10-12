using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.IndividualsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.IndividualsFeatures.Handlers
{
    public class UpdateIndividualsHandler : IRequestHandler<UpdateIndividualsCommand, Unit>
    {
        private readonly IIndividualsRepository individualsRepository;
        private readonly IMapper mapper;

        public UpdateIndividualsHandler(IIndividualsRepository individualsRepository, IMapper mapper)
        {
            this.individualsRepository = individualsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateIndividualsCommand request, CancellationToken cancellationToken)
        {
            var individualsDto = mapper.Map<IndividualsDto>(request);
            await individualsRepository.Update(request.Id, individualsDto);
            return Unit.Value;
        }
    }
}
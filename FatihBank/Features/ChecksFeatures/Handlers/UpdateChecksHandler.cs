using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ChecksFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChecksFeatures.Handlers
{
    public class UpdateChecksHandler : IRequestHandler<UpdateChecksCommand, Unit>
    {
        private readonly IMapper mapper;
        private readonly IChecksRepository checksRepository;

        public UpdateChecksHandler(IMapper mapper, IChecksRepository checksRepository)
        {
            this.mapper = mapper;
            this.checksRepository = checksRepository;
        }

        public async Task<Unit> Handle(UpdateChecksCommand request, CancellationToken cancellationToken)
        {
            var checksDto = mapper.Map<ChecksDto>(request);
            await checksRepository.Update(request.Id, checksDto);
            return Unit.Value;
        }
    }
}

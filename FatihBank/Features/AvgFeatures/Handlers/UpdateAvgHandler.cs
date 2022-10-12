using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.AvgFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.AvgFeatures.Handlers
{
    public class UpdateAvgHandler : IRequestHandler<UpdateAvgCommand, Unit>
    {
        private readonly IAvgRepository avgRepository;
        private readonly IMapper mapper;

        public UpdateAvgHandler(IAvgRepository avgRepository, IMapper mapper)
        {
            this.avgRepository = avgRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateAvgCommand request, CancellationToken cancellationToken)
        {
            var avgDto = mapper.Map<AvgDto>(request);
            await avgRepository.Update(request.Id, avgDto);
            return Unit.Value;
        }
    }
}
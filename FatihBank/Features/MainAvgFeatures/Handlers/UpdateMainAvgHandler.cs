using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MainAvgFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MainAvgFeatures.Handlers
{
    public class UpdateMainAvgHandler : IRequestHandler<UpdateMainAvgCommand, Unit>
    {
        private readonly IMainAvgRepository mainAvgRepository;
        private readonly IMapper mapper;

        public UpdateMainAvgHandler(IMainAvgRepository mainAvgRepository, IMapper mapper)
        {
            this.mainAvgRepository = mainAvgRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMainAvgCommand request, CancellationToken cancellationToken)
        {
            var mainAvgDto = mapper.Map<MainAvgDto>(request);
            await mainAvgRepository.Update(request.Id, mainAvgDto);
            return Unit.Value;
        }
    }
}
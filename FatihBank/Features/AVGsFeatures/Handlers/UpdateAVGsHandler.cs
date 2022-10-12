using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_AVGsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AVGsFeatures.Handlers
{
    public class UpdateAVGsHandler : IRequestHandler<UpdateAVGsCommand, Unit>
    {
        private readonly IMapper mapper;
        private readonly IAVGsRepository aVGsRepository;

        public UpdateAVGsHandler(IMapper mapper, IAVGsRepository aVGsRepository)
        {
            this.mapper = mapper;
            this.aVGsRepository = aVGsRepository;
        }
        public async Task<Unit> Handle(UpdateAVGsCommand request, CancellationToken cancellationToken)
        {
            var aVGsDto = mapper.Map<AVGsDto>(request);
            await aVGsRepository.Update(request.Id, aVGsDto);
            return Unit.Value;
        }
    }
}

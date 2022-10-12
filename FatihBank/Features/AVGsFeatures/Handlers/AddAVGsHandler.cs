using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_AVGsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AVGsFeatures.Handlers
{
    public class AddAVGsHandler : IRequestHandler<AddAVGsCommand, MSS_DEF_AVGs>
    {
        private readonly IMapper mapper;
        private readonly IAVGsRepository aVGsRepository;

        public AddAVGsHandler(IMapper mapper, IAVGsRepository aVGsRepository)
        {
            this.mapper = mapper;
            this.aVGsRepository = aVGsRepository;
        }

        public async Task<MSS_DEF_AVGs> Handle(AddAVGsCommand request, CancellationToken cancellationToken)
        {
            var aVGsDto = mapper.Map<AVGsDto>(request);
            return await aVGsRepository.Add(aVGsDto);
        }
    }
}

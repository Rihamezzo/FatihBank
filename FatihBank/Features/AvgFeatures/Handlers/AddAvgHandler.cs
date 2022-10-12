using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.AvgFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.AvgFeatures.Handlers
{
    public class AddAvgHandler : IRequestHandler<AddAvgCommand, MSS_FIN_Avg>
    {
        private readonly IAvgRepository avgRepository;
        private readonly IMapper mapper;

        public AddAvgHandler(IAvgRepository avgRepository, IMapper mapper)
        {
            this.avgRepository = avgRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_FIN_Avg> Handle(AddAvgCommand request, CancellationToken cancellationToken)
        {
            var avgDto = mapper.Map<AvgDto>(request);
            return await avgRepository.Add(avgDto);
        }
    }
}

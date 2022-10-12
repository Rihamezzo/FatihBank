using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MainAvgFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MainAvgFeatures.Handlers
{
    public class AddMainAvgHandler : IRequestHandler<AddMainAvgCommand, MSS_AVG_MainAvg>
    {
        private readonly IMainAvgRepository mainAvgRepository;
        private readonly IMapper mapper;

        public AddMainAvgHandler(IMainAvgRepository mainAvgRepository, IMapper mapper)
        {
            this.mainAvgRepository = mainAvgRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_AVG_MainAvg> Handle(AddMainAvgCommand request, CancellationToken cancellationToken)
        {
            var mainAvgDto = mapper.Map<MainAvgDto>(request);
            return await mainAvgRepository.Add(mainAvgDto);
        }
    }
}

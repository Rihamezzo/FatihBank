using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.RewardsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RewardsFeatures.Handlers
{
    public class AddRewardsHandler : IRequestHandler<AddRewardsCommand, MSS_ATT_Rewards>
    {
        private readonly IRewardsRepository rewardsRepository;
        private readonly IMapper mapper;

        public AddRewardsHandler(IRewardsRepository rewardsRepository, IMapper mapper)
        {
            this.rewardsRepository = rewardsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_Rewards> Handle(AddRewardsCommand request, CancellationToken cancellationToken)
        {
            var rewardsDto = mapper.Map<RewardsDto>(request);
            return await rewardsRepository.Add(rewardsDto);
        }
    }
}
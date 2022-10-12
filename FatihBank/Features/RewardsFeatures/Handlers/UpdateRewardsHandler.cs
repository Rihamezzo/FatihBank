using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.RewardsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RewardsFeatures.Handlers
{
    public class UpdateRewardsHandler : IRequestHandler<UpdateRewardsCommand, Unit>
    {
        private readonly IRewardsRepository rewardsRepository;
        private readonly IMapper mapper;

        public UpdateRewardsHandler(IRewardsRepository rewardsRepository, IMapper mapper)
        {
            this.rewardsRepository = rewardsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateRewardsCommand request, CancellationToken cancellationToken)
        {
            var rewardsDto = mapper.Map<RewardsDto>(request);
            await rewardsRepository.Update(request.Id, rewardsDto);
            return Unit.Value;
        }
    }
}
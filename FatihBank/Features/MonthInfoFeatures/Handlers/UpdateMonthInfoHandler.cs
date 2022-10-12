using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MonthInfoFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthInfoFeatures.Handlers
{
    public class UpdateMonthInfoHandler : IRequestHandler<UpdateMonthInfoCommand, Unit>
    {
        private readonly IMonthInfoRepository monthInfoRepository;
        private readonly IMapper mapper;

        public UpdateMonthInfoHandler(IMonthInfoRepository monthInfoRepository, IMapper mapper)
        {
            this.monthInfoRepository = monthInfoRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMonthInfoCommand request, CancellationToken cancellationToken)
        {
            var monthInfoDto = mapper.Map<MonthInfoDto>(request);
            await monthInfoRepository.Update(request.Id, monthInfoDto);
            return Unit.Value;
        }
    }
}
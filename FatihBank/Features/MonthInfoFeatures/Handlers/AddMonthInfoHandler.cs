using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MonthInfoFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthInfoFeatures.Handlers
{
    public class AddMonthInfoHandler : IRequestHandler<AddMonthInfoCommand, MSS_ATT_Month_Info>
    {
        private readonly IMonthInfoRepository monthInfoRepository;
        private readonly IMapper mapper;

        public AddMonthInfoHandler(IMonthInfoRepository monthInfoRepository, IMapper mapper)
        {
            this.monthInfoRepository = monthInfoRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_Month_Info> Handle(AddMonthInfoCommand request, CancellationToken cancellationToken)
        {
            var monthInfoDto = mapper.Map<MonthInfoDto>(request);
            return await monthInfoRepository.Add(monthInfoDto);
        }
    }
}
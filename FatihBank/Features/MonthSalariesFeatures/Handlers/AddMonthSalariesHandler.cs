using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MonthSalariesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthSalariesFeatures.Handlers
{
    public class AddMonthSalariesHandler : IRequestHandler<AddMonthSalariesCommand, MSS_ATT_Month_Salaries>
    {
        private readonly IMonthSalariesRepository monthSalariesRepository;
        private readonly IMapper mapper;

        public AddMonthSalariesHandler(IMonthSalariesRepository monthSalariesRepository, IMapper mapper)
        {
            this.monthSalariesRepository = monthSalariesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_Month_Salaries> Handle(AddMonthSalariesCommand request, CancellationToken cancellationToken)
        {
            var monthSalariesDto = mapper.Map<MonthSalariesDto>(request);
            return await monthSalariesRepository.Add(monthSalariesDto);
        }
    }
}
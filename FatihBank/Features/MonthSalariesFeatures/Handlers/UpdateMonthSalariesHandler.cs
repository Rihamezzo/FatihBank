using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MonthSalariesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MonthSalariesFeatures.Handlers
{
    public class UpdateMonthSalariesHandler : IRequestHandler<UpdateMonthSalariesCommand, Unit>
    {
        private readonly IMonthSalariesRepository monthSalariesRepository;
        private readonly IMapper mapper;

        public UpdateMonthSalariesHandler(IMonthSalariesRepository monthSalariesRepository, IMapper mapper)
        {
            this.monthSalariesRepository = monthSalariesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMonthSalariesCommand request, CancellationToken cancellationToken)
        {
            var monthSalariesDto = mapper.Map<MonthSalariesDto>(request);
            await monthSalariesRepository.Update(request.Id, monthSalariesDto);
            return Unit.Value;
        }
    }
}
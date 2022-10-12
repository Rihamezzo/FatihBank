using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.DailyAttendanceFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DailyAttendanceFeatures.Handlers
{
    public class UpdateDailyAttendanceHandler : IRequestHandler<UpdateDailyAttendanceCommand, Unit>
    {
        private readonly IDailyAttendanceRepository dailyAttendanceRepository;
        private readonly IMapper mapper;

        public UpdateDailyAttendanceHandler(IDailyAttendanceRepository dailyAttendanceRepository, IMapper mapper)
        {
            this.dailyAttendanceRepository = dailyAttendanceRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDailyAttendanceCommand request, CancellationToken cancellationToken)
        {
            var dailyAttendanceDto = mapper.Map<DailyAttendanceDto>(request);
            await dailyAttendanceRepository.Update(request.Id, dailyAttendanceDto);
            return Unit.Value;
        }
    }
}

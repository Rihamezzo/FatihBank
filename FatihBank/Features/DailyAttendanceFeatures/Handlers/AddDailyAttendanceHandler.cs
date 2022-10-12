using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.DailyAttendanceFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DailyAttendanceFeatures.Handlers
{
    public class AddDailyAttendanceHandler : IRequestHandler<AddDailyAttendanceCommand, MSS_ATT_Daily_Attendance>
    {
        private readonly IDailyAttendanceRepository dailyAttendanceRepository;
        private readonly IMapper mapper;

        public AddDailyAttendanceHandler(IDailyAttendanceRepository dailyAttendanceRepository, IMapper mapper)
        {
            this.dailyAttendanceRepository = dailyAttendanceRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_ATT_Daily_Attendance> Handle(AddDailyAttendanceCommand request, CancellationToken cancellationToken)
        {
            var dailyAttendanceDto = mapper.Map<DailyAttendanceDto>(request);
            return await dailyAttendanceRepository.Add(dailyAttendanceDto);
        }
    }
}

using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ScheduleFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ScheduleFeatures.Handlers
{
    public class AddScheduleHandler : IRequestHandler<AddScheduleCommand, MSS_DEF_Schedule>
    {
        private readonly IScheduleRepository scheduleRepository;
        private readonly IMapper mapper;

        public AddScheduleHandler(IScheduleRepository scheduleRepository, IMapper mapper)
        {
            this.scheduleRepository = scheduleRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Schedule> Handle(AddScheduleCommand request, CancellationToken cancellationToken)
        {
            var scheduleDto = mapper.Map<ScheduleDto>(request);
            return await scheduleRepository.Add(scheduleDto);
        }
    }
}
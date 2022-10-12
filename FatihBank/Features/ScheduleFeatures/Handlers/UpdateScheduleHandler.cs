using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.ScheduleFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ScheduleFeatures.Handlers
{
    public class UpdateScheduleHandler : IRequestHandler<UpdateScheduleCommand, Unit>
    {
        private readonly IScheduleRepository scheduleRepository;
        private readonly IMapper mapper;

        public UpdateScheduleHandler(IScheduleRepository scheduleRepository, IMapper mapper)
        {
            this.scheduleRepository = scheduleRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {
            var scheduleDto = mapper.Map<ScheduleDto>(request);
            await scheduleRepository.Update(request.Id, scheduleDto);
            return Unit.Value;
        }
    }
}
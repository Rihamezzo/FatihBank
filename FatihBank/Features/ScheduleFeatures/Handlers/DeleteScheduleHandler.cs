using FatihBank.Features.ScheduleFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ScheduleFeatures.Handlers
{
    public class DeleteScheduleHandler : IRequestHandler<DeleteScheduleCommand, Unit>
    {
        private readonly IScheduleRepository scheduleRepository;

        public DeleteScheduleHandler(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }

        public async Task<Unit> Handle(DeleteScheduleCommand request, CancellationToken cancellationToken)
        {
            await scheduleRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
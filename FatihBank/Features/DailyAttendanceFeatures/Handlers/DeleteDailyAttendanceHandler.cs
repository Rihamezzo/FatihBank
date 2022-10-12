using FatihBank.Features.DailyAttendanceFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DailyAttendanceFeatures.Handlers
{
    public class DeleteDailyAttendanceHandler : IRequestHandler<DeleteDailyAttendanceCommand, Unit>
    {
        private readonly IDailyAttendanceRepository dailyAttendanceRepository;

        public DeleteDailyAttendanceHandler(IDailyAttendanceRepository dailyAttendanceRepository)
        {
            this.dailyAttendanceRepository = dailyAttendanceRepository;
        }

        public async Task<Unit> Handle(DeleteDailyAttendanceCommand request, CancellationToken cancellationToken)
        {
            await dailyAttendanceRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
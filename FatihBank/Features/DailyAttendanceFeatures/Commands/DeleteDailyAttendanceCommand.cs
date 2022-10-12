using MediatR;

namespace FatihBank.Features.DailyAttendanceFeatures.Commands
{
    public class DeleteDailyAttendanceCommand : IRequest
    {
        public int Id { get; set; }
    }
}

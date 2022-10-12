using MediatR;

namespace FatihBank.Features.ScheduleFeatures.Commands
{
    public class DeleteScheduleCommand : IRequest
    {
        public int Id { get; set; }
    }
}
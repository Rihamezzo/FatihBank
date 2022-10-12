using MediatR;

namespace FatihBank.Features.NotificationsFeatures.Commands
{
    public class DeleteNotificationsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
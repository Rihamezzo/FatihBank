using FatihBank.Features.NotificationsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.NotificationsFeatures.Handlers
{
    public class DeleteNotificationsHandler : IRequestHandler<DeleteNotificationsCommand, Unit>
    {
        private readonly INotificationsRepository notificationsRepository;

        public DeleteNotificationsHandler(INotificationsRepository notificationsRepository)
        {
            this.notificationsRepository = notificationsRepository;
        }

        public async Task<Unit> Handle(DeleteNotificationsCommand request, CancellationToken cancellationToken)
        {
            await notificationsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
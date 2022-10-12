using FatihBank.DTOs;
using FatihBank.Features.NotificationsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.NotificationsFeatures.Handlers
{
    public class ListAllNotificationsHandler : IRequestHandler<ListAllNotificationsQuery, PaginationResponse<MSS_INF_Notifications>>
    {
        private readonly INotificationsRepository notificationsRepository;

        public ListAllNotificationsHandler(INotificationsRepository notificationsRepository)
        {
            this.notificationsRepository = notificationsRepository;
        }

        public async Task<PaginationResponse<MSS_INF_Notifications>> Handle(ListAllNotificationsQuery request, CancellationToken cancellationToken)
        {
            return await notificationsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
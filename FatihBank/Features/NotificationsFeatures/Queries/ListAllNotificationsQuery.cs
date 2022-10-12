using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.NotificationsFeatures.Queries
{
    public class ListAllNotificationsQuery : IRequest<PaginationResponse<MSS_INF_Notifications>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllNotificationsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
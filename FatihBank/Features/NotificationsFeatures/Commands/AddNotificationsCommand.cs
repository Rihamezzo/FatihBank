using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.NotificationsFeatures.Commands
{
    public class AddNotificationsCommand : IRequest<MSS_INF_Notifications>
    {

        public int? Id { get; set; }
        public int from_id { get; set; }
        public int? fromId { get; set; }
        public int to_id { get; set; }
        public int? toId { get; set; }
        public int object_id { get; set; }
        public int action_id { get; set; }
        public string obj { get; set; }
        public string action { get; set; }
        public bool is_read { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? last_update { get; set; }
    }
}
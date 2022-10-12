using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ChatListFeatures.Commands
{
    public class AddChatListCommand : IRequest<MSS_CHT_ChatList>
    {
        public int? Id { get; set; }
        public int s_1 { get; set; }
        public int s_2 { get; set; }
        public int? user1Id { get; set; }
        public int? user2Id { get; set; }
        public DateTime created_at { get; set; }
    }
}
using MediatR;

namespace FatihBank.Features.ChatListFeatures.Commands
{
    public class DeleteChatListCommand : IRequest
    {
        public int Id { get; set; }
    }
}
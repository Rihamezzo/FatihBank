using FatihBank.Features.ChatListFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChatListFeatures.Handlers
{
    public class DeleteChatListHandler : IRequestHandler<DeleteChatListCommand, Unit>
    {
        private readonly IChatListRepository chatListRepository;

        public DeleteChatListHandler(IChatListRepository chatListRepository)
        {
            this.chatListRepository = chatListRepository;
        }

        public async Task<Unit> Handle(DeleteChatListCommand request, CancellationToken cancellationToken)
        {
            await chatListRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

using MediatR;
using FatihBank.Features.MSS_DEF_UsersFeatures.Commands;
using FatihBank.Repositories;

namespace FatihBank.Features.MSS_DEF_UsersFeatures.Handlers
{
    public class DeleteUsersHandler : IRequestHandler<DeleteUsersCommand, Unit>
    {
        private readonly IUsersRepository usersRepository;

        public DeleteUsersHandler(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public async Task<Unit> Handle(DeleteUsersCommand request, CancellationToken cancellationToken)
        {
            await usersRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

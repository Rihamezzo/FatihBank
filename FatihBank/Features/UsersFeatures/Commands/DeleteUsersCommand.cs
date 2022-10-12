using MediatR;
namespace FatihBank.Features.MSS_DEF_UsersFeatures.Commands
{
    public class DeleteUsersCommand : IRequest
    {
        public int Id { get; set; }

    }
}

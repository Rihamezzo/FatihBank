using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;
namespace FatihBank.Features.MSS_DEF_UsersFeatures.Commands
{
    public class AddUsersCommand : IRequest<MSS_DEF_Users?>
    {
        public int? Id { get; set; }
        public int userId { get; set; }
        public string loginName { get; set; }
        public string password { get; set; }
        public int groupId { get; set; }

        public string username { get; set; }

        public int? is_online { get; set; }
        public virtual ICollection<PermissionsDto>? permissions { get; set; }
    }
}

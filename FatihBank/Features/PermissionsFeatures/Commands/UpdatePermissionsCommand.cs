using MediatR;

namespace FatihBank.Features.PermissionsFeatures.Commands
{
    public class UpdatePermissionsCommand : IRequest
    {
        public int Id { get; set; }
        public int module_id { get; set; }
        public int? module1Id { get; set; }
        public int user_id { get; set; }
        public int? userId { get; set; }
        public int type { get; set; }

        public string module { get; set; }
    }
}
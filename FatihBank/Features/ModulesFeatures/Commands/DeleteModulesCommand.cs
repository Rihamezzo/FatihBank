
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Commands
{
    public class DeleteModulesCommand : IRequest
    {
        public int Id { get; set; }
    }
}
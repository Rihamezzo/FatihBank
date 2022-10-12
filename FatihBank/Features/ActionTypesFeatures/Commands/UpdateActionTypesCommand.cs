using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Commands
{
    public class UpdateActionTypesCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
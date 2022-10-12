using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Commands
{
    public class AddActionTypesCommand : IRequest<MSS_INF_Action_Types>
    {
        public int? Id { get; set; }
        public string name { get; set; }
    }
}
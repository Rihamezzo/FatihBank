using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Commands
{
    public class AddExcusesTypesCommand : IRequest<MSS_ATT_ExcusesTypes>
    {
        public int? Id { get; set; }
        public string name { get; set; }
    }
}
using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Commands
{
    public class UpdateExcusesTypesCommand : IRequest
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
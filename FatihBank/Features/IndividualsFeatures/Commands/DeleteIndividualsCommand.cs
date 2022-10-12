using MediatR;

namespace FatihBank.Features.IndividualsFeatures.Commands
{
    public class DeleteIndividualsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
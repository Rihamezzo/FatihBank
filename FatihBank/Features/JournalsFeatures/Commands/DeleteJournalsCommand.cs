using MediatR;

namespace FatihBank.Features.JournalsFeatures.Commands
{
    public class DeleteJournalsCommand : IRequest
    {
        public int Id { get; set; }
    }

    public class DeleteJournalsDetailsCommand : IRequest
    {
        public int Id { get; set; }
    }
}
using FatihBank.Features.JournalsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.JournalsFeatures.Handlers
{
    public class DeleteJournalsHandler : IRequestHandler<DeleteJournalsCommand, Unit>
    {
        private readonly IJournalsRepository journalsRepository;

        public DeleteJournalsHandler(IJournalsRepository journalsRepository)
        {
            this.journalsRepository = journalsRepository;
        }

        public async Task<Unit> Handle(DeleteJournalsCommand request, CancellationToken cancellationToken)
        {
            await journalsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }

    public class DeleteJournalsDetailsHandler : IRequestHandler<DeleteJournalsDetailsCommand, Unit>
    {
        private readonly IJournalsDetailsRepository journalsDetailsRepository;

        public DeleteJournalsDetailsHandler(IJournalsDetailsRepository journalsDetailsRepository)
        {
            this.journalsDetailsRepository = journalsDetailsRepository;
        }

        public async Task<Unit> Handle(DeleteJournalsDetailsCommand request, CancellationToken cancellationToken)
        {
            await journalsDetailsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
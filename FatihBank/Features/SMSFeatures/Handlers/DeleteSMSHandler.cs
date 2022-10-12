using FatihBank.Features.SMSFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.SMSFeatures.Handlers
{
    public class DeleteSMSHandler : IRequestHandler<DeleteSMSCommand, Unit>
    {
        private readonly ISMSRepository SMSRepository;

        public DeleteSMSHandler(ISMSRepository SMSRepository)
        {
            this.SMSRepository = SMSRepository;
        }

        public async Task<Unit> Handle(DeleteSMSCommand request, CancellationToken cancellationToken)
        {
            await SMSRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
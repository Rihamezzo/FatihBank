using FatihBank.Features.VouchersFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VouchersFeatures.Handlers
{
    public class DeleteVouchersHandler : IRequestHandler<DeleteVouchersCommand, Unit>
    {
        private readonly IVouchersRepository vouchersRepository;

        public DeleteVouchersHandler(IVouchersRepository vouchersRepository)
        {
            this.vouchersRepository = vouchersRepository;
        }

        public async Task<Unit> Handle(DeleteVouchersCommand request, CancellationToken cancellationToken)
        {
            await vouchersRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

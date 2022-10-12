using FatihBank.Features.MCDFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MCDFeatures.Handlers
{
    public class DeleteMCDHandler : IRequestHandler<DeleteMCDCommand, Unit>
    {
        private readonly IMCDRepository mCDRepository;

        public DeleteMCDHandler(IMCDRepository mCDRepository)
        {
            this.mCDRepository = mCDRepository;
        }

        public async Task<Unit> Handle(DeleteMCDCommand request, CancellationToken cancellationToken)
        {
            await mCDRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
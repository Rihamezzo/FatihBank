using FatihBank.Features.RegisterationFileFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RegisterationFileFeatures.Handlers
{
    public class DeleteRegisterationFileHandler : IRequestHandler<DeleteRegisterationFileCommand, Unit>
    {
        private readonly IRegisterationFileRepository registerationFileRepository;

        public DeleteRegisterationFileHandler(IRegisterationFileRepository registerationFileRepository)
        {
            this.registerationFileRepository = registerationFileRepository;
        }

        public async Task<Unit> Handle(DeleteRegisterationFileCommand request, CancellationToken cancellationToken)
        {
            await registerationFileRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.RegisterationFileFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RegisterationFileFeatures.Handlers
{
    public class UpdateRegisterationFileHandler : IRequestHandler<UpdateRegisterationFileCommand, Unit>
    {
        private readonly IRegisterationFileRepository registerationFileRepository;
        private readonly IMapper mapper;

        public UpdateRegisterationFileHandler(IRegisterationFileRepository registerationFileRepository, IMapper mapper)
        {
            this.registerationFileRepository = registerationFileRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateRegisterationFileCommand request, CancellationToken cancellationToken)
        {
            var registerationFileDto = mapper.Map<RegisterationFileDto>(request);
            await registerationFileRepository.Update(request.Id, registerationFileDto);
            return Unit.Value;
        }
    }
}

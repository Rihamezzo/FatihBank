using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.RegisterationFileFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RegisterationFileFeatures.Handlers
{
    public class AddRegisterationFileHandler : IRequestHandler<AddRegisterationFileCommand, MSS_INF_RegisterationFile>
    {
        private readonly IRegisterationFileRepository registerationFileRepository;
        private readonly IMapper mapper;

        public AddRegisterationFileHandler(IRegisterationFileRepository registerationFileRepository, IMapper mapper)
        {
            this.registerationFileRepository = registerationFileRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_INF_RegisterationFile> Handle(AddRegisterationFileCommand request, CancellationToken cancellationToken)
        {
            var registerationFileDto = mapper.Map<RegisterationFileDto>(request);
            return await registerationFileRepository.Add(registerationFileDto);
        }
    }
}

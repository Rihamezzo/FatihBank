using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MCDFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MCDFeatures.Handlers
{
    public class AddMCDHandler : IRequestHandler<AddMCDCommand, MSS_DEF_MCD>
    {
        private readonly IMCDRepository mCDRepository;
        private readonly IMapper mapper;

        public AddMCDHandler(IMCDRepository mCDRepository, IMapper mapper)
        {
            this.mCDRepository = mCDRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_MCD> Handle(AddMCDCommand request, CancellationToken cancellationToken)
        {
            var mCDDto = mapper.Map<MCDDto>(request);
            return await mCDRepository.Add(mCDDto);
        }
    }
}
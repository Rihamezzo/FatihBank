using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MCDFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MCDFeatures.Handlers
{
    public class UpdateMCDHandler : IRequestHandler<UpdateMCDCommand, Unit>
    {
        private readonly IMCDRepository mCDRepository;
        private readonly IMapper mapper;

        public UpdateMCDHandler(IMCDRepository mCDRepository, IMapper mapper)
        {
            this.mCDRepository = mCDRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMCDCommand request, CancellationToken cancellationToken)
        {
            var mCDDto = mapper.Map<MCDDto>(request);
            await mCDRepository.Update(request.Id, mCDDto);
            return Unit.Value;
        }
    }
}

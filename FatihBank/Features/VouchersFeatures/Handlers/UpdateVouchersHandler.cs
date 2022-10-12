using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.VouchersFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VouchersFeatures.Handlers
{
    public class UpdateVouchersHandler : IRequestHandler<UpdateVouchersCommand, Unit>
    {
        private readonly IVouchersRepository vouchersRepository;
        private readonly IMapper mapper;

        public UpdateVouchersHandler(IVouchersRepository vouchersRepository, IMapper mapper)
        {
            this.vouchersRepository = vouchersRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateVouchersCommand request, CancellationToken cancellationToken)
        {
            var vouchersDto = mapper.Map<VouchersDto>(request);
            await vouchersRepository.Update(request.Id, vouchersDto);
            return Unit.Value;
        }
    }
}

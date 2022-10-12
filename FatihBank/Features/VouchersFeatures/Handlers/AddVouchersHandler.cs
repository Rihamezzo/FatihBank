
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.VouchersFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VouchersFeatures.Handlers
{
    public class AddVouchersHandler : IRequestHandler<AddVouchersCommand, MSS_DEF_Vouchers>
    {
        private readonly IVouchersRepository vouchersRepository;
        private readonly IMapper mapper;

        public AddVouchersHandler(IVouchersRepository vouchersRepository, IMapper mapper)
        {
            this.vouchersRepository = vouchersRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Vouchers> Handle(AddVouchersCommand request, CancellationToken cancellationToken)
        {
            var vouchersDto = mapper.Map<VouchersDto>(request);
            return await vouchersRepository.Add(vouchersDto);
        }
    }
}

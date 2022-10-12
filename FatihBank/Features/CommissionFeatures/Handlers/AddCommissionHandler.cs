using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CommissionFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CommissionFeatures.Handlers
{
    public class AddCommissionHandler : IRequestHandler<AddCommissionCommand, MSS_DEF_Commission>
    {
        private readonly IMapper mapper;
        private readonly ICommissionRepository commissionRepository;

        public AddCommissionHandler(IMapper mapper, ICommissionRepository commissionRepository)
        {
            this.mapper = mapper;
            this.commissionRepository = commissionRepository;
        }

        public async Task<MSS_DEF_Commission> Handle(AddCommissionCommand request, CancellationToken cancellationToken)
        {
            var commissionDto = mapper.Map<CommissionDto>(request);
            return await commissionRepository.Add(commissionDto);
        }
    }
}

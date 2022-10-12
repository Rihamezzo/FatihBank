using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.MSS_DEF_CommissionFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CommissionFeatures.Handlers
{
    public class UpdateCommissionHandler : IRequestHandler<UpdateCommissionCommand, Unit>
    {
        private readonly IMapper mapper;
        private readonly ICommissionRepository commissionRepository;

        public UpdateCommissionHandler(IMapper mapper, ICommissionRepository commissionRepository)
        {
            this.mapper = mapper;
            this.commissionRepository = commissionRepository;
        }

        public async Task<Unit> Handle(UpdateCommissionCommand request, CancellationToken cancellationToken)
        {
            var commissionDto = mapper.Map<CommissionDto>(request);
            await commissionRepository.Update(request.Id, commissionDto);
            return Unit.Value;
        }
    }
}

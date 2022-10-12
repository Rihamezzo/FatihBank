
using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.OperationsFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OperationsFeatures.Handlers
{
    public class AddOperationsHandler : IRequestHandler<AddOperationsCommand, MSS_CAS_Operations>
    {
        private readonly IOperationsRepository operationsRepository;
        private readonly IMapper mapper;

        public AddOperationsHandler(IOperationsRepository operationsRepository, IMapper mapper)
        {
            this.operationsRepository = operationsRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_CAS_Operations> Handle(AddOperationsCommand request, CancellationToken cancellationToken)
        {
            var operationsDto = mapper.Map<OperationsDto>(request);
            return await operationsRepository.Add(operationsDto);
        }
    }
}

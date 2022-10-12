using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.OperationsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OperationsFeatures.Handlers
{
    public class UpdateOperationsHandler : IRequestHandler<UpdateOperationsCommand, Unit>
    {
        private readonly IOperationsRepository operationsRepository;
        private readonly IMapper mapper;

        public UpdateOperationsHandler(IOperationsRepository operationsRepository, IMapper mapper)
        {
            this.operationsRepository = operationsRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOperationsCommand request, CancellationToken cancellationToken)
        {
            var operationsDto = mapper.Map<OperationsDto>(request);
            await operationsRepository.Update(request.Id, operationsDto);
            return Unit.Value;
        }
    }
}

using MediatR;
using FatihBank.Features.MSS_DEF_CustomersFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using FatihBank.DTOs;
using AutoMapper;

namespace FatihBank.Features.MSS_DEF_CustomersFeatures.Handlers
{
    public class UpdateCustomersHandler : IRequestHandler<UpdateCustomersCommand,Unit>
    {
        private readonly ICustomersRepository customersRepository;
        private readonly IMapper mapper;

        public UpdateCustomersHandler(ICustomersRepository customersRepository, IMapper mapper)
        {
            this.customersRepository = customersRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCustomersCommand request, CancellationToken cancellationToken)
        {
            var customersDto = mapper.Map<CustomersDto>(request);
            await customersRepository.Update(request.Id, customersDto);
            return Unit.Value;
        }
    }
}

using MediatR;
using FatihBank.Features.MSS_DEF_CustomersFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using FatihBank.DTOs;
using AutoMapper;

namespace FatihBank.Features.MSS_DEF_CustomersFeatures.Handlers
{
    public class AddCustomersHandler : IRequestHandler<AddCustomersCommand,MSS_DEF_Customers>
    {
        private readonly ICustomersRepository customersRepository;
        private readonly IMapper mapper;

        public AddCustomersHandler(ICustomersRepository customersRepository, IMapper mapper)
        {
            this.customersRepository = customersRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Customers> Handle(AddCustomersCommand request, CancellationToken cancellationToken)
        {
            var customersDto = mapper.Map<CustomersDto>(request);
            return await customersRepository.Add(customersDto);
        }
    }
}

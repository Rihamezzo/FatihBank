using MediatR;
using FatihBank.Features.MSS_DEF_CustomersFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using FatihBank.DTOs;
using AutoMapper;

namespace FatihBank.Features.MSS_DEF_CustomersFeatures.Handlers
{
    public class DeleteCustomersHandler : IRequestHandler<DeleteCustomersCommand,Unit>
    {
        private readonly ICustomersRepository customersRepository;

        public DeleteCustomersHandler(ICustomersRepository customersRepository)
        {
            this.customersRepository = customersRepository;
        }

        public async Task<Unit> Handle(DeleteCustomersCommand request, CancellationToken cancellationToken)
        {
            await customersRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

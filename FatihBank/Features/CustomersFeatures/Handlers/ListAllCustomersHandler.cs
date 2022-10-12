using MediatR;
using FatihBank.Features.MSS_DEF_CustomersFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using FatihBank.DTOs;

namespace FatihBank.Features.MSS_DEF_CustomersFeatures.Handlers
{
    public class ListAllCustomersHandler : IRequestHandler<ListAllCustomersQuery,PaginationResponse<MSS_DEF_Customers>>
    {
        private readonly ICustomersRepository customersRepository;

        public ListAllCustomersHandler(ICustomersRepository customersRepository)
        {
            this.customersRepository = customersRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Customers>> Handle(ListAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return await customersRepository.ListAll(request.page, request.pageSize);
        }
    }
}

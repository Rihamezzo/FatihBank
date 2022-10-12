using FatihBank.DTOs;
using FatihBank.Features.EmployeesFeatuers.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.EmployeesFeatuers.Handlers
{
    public class ListAllEmpolyeesHandler : IRequestHandler<ListAllEmployeesQuery, PaginationResponse<MSS_DEF_Employees>>
    {
        private readonly IEmployeesRepository employeesRepository;

        public ListAllEmpolyeesHandler(IEmployeesRepository employeesRepository)
        {
            this.employeesRepository = employeesRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Employees>> Handle(ListAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await employeesRepository.ListAll(request.page, request.pageSize);
        }
    }
}

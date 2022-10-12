using FatihBank.DTOs;
using FatihBank.Features.DEF_EmployeesFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;
namespace FatihBank.Features.DEF_EmployeesFeatures.Handlers
{
    public class ListAllDEF_EmployeesHandler : IRequestHandler <ListAllDEF_EmployeesQuery, PaginationResponse<MSS_N_DEF_Employees>>
    {
        private readonly IDEF_EmployeesRepository dEF_EmployeesRepository;

        public ListAllDEF_EmployeesHandler(IDEF_EmployeesRepository dEF_EmployeesRepository)
        {
            this.dEF_EmployeesRepository = dEF_EmployeesRepository;
        }

        public async Task<PaginationResponse<MSS_N_DEF_Employees>> Handle(ListAllDEF_EmployeesQuery request, CancellationToken cancellationToken)
        {
            return await dEF_EmployeesRepository.ListAll(request.page, request.pageSize);
        }
    }
}

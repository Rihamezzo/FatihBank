using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.DEF_EmployeesFeatures.Queries
{
    public class ListAllDEF_EmployeesQuery : IRequest<PaginationResponse<MSS_N_DEF_Employees>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllDEF_EmployeesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
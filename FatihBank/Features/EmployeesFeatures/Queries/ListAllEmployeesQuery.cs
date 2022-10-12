using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.EmployeesFeatuers.Queries
{
    public class ListAllEmployeesQuery : IRequest<PaginationResponse<MSS_DEF_Employees>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllEmployeesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}

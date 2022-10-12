using MediatR;

namespace FatihBank.Features.DEF_EmployeesFeatures.Commands
{
    public class DeleteDEF_EmployeesCommand : IRequest
    {
        public int Id { get; set; }
    }
}
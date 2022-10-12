using MediatR;
namespace FatihBank.Features.EmployeesFeatuers.Commands
{
    public class DeleteEmployeesCommand : IRequest
    {
        public int Id { get; set; }
    }
}

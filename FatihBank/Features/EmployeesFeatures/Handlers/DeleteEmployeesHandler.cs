using FatihBank.Features.EmployeesFeatuers.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.EmployeesFeatuers.Handlers
{
    public class DeleteEmployeesHandler : IRequestHandler<DeleteEmployeesCommand, Unit>
    {
        private readonly IEmployeesRepository employeesRepository;

        public DeleteEmployeesHandler(IEmployeesRepository employeesRepository)
        {
            this.employeesRepository = employeesRepository;
        }

        public async Task<Unit> Handle(DeleteEmployeesCommand request, CancellationToken cancellationToken)
        {
            await employeesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

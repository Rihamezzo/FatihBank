using FatihBank.Features.DEF_EmployeesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DEF_EmployeesFeatures.Handlers
{
    public class DeleteDEF_EmployeesHandler : IRequestHandler<DeleteDEF_EmployeesCommand, Unit>
    {
        private readonly IDEF_EmployeesRepository dEF_EmployeesRepository;

        public DeleteDEF_EmployeesHandler(IDEF_EmployeesRepository dEF_EmployeesRepository)
        {
            this.dEF_EmployeesRepository = dEF_EmployeesRepository;
        }

        public async Task<Unit> Handle(DeleteDEF_EmployeesCommand request, CancellationToken cancellationToken)
        {
            await dEF_EmployeesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}

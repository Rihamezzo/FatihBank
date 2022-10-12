using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.DEF_EmployeesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DEF_EmployeesFeatures.Handlers
{
    public class UpdateDEF_EmployeesHandler : IRequestHandler<UpdateDEF_EmployeesCommand, Unit>
    {
        private readonly IDEF_EmployeesRepository dEF_EmployeesRepository;
        private readonly IMapper mapper;

        public UpdateDEF_EmployeesHandler(IDEF_EmployeesRepository dEF_EmployeesRepository, IMapper mapper)
        {
            this.dEF_EmployeesRepository = dEF_EmployeesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDEF_EmployeesCommand request, CancellationToken cancellationToken)
        {
            var dEF_EmployeesDto = mapper.Map<DEF_EmployeesDto>(request);
            await dEF_EmployeesRepository.Update(request.Id, dEF_EmployeesDto);
            return Unit.Value;
        }
    }
}
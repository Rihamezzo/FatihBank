using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.EmployeesFeatuers.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;
namespace FatihBank.Features.EmployeesFeatuers.Handlers
{
    public class UpdateEmployeesHandler : IRequestHandler<UpdateEmployeesCommand,Unit>
    {
        private readonly IEmployeesRepository employeesRepository;
        private readonly IMapper mapper;

        public UpdateEmployeesHandler(IEmployeesRepository employeesRepository, IMapper mapper)
        {
            this.employeesRepository = employeesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEmployeesCommand request, CancellationToken cancellationToken)
        {
            var employeesDto = mapper.Map<EmployeesDto>(request);
            await employeesRepository.Update(request.Id, employeesDto);
            return Unit.Value;
        }
    }
}

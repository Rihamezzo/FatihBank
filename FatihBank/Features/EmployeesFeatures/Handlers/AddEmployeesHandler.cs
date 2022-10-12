using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.EmployeesFeatuers.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.EmployeesFeatuers.Handlers
{
    public class AddEmployeesHandler : IRequestHandler<AddEmployeesCommand, MSS_DEF_Employees>
    {
        private readonly IEmployeesRepository employeesRepository;
        private readonly IMapper mapper;

        public AddEmployeesHandler(IEmployeesRepository employeesRepository, IMapper mapper)
        {
            this.employeesRepository = employeesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Employees> Handle(AddEmployeesCommand request, CancellationToken cancellationToken)
        {
            var employeesDto = mapper.Map<EmployeesDto>(request);
            return await employeesRepository.Add(employeesDto);
        }
    }
}

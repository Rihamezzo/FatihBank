using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.DEF_EmployeesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.DEF_EmployeesFeatures.Handlers
{
    public class AddDEF_EmployeesHandler : IRequestHandler<AddDEF_EmployeesCommand, MSS_N_DEF_Employees>
    {
        private readonly IDEF_EmployeesRepository dEF_EmployeesRepository;
        private readonly IMapper mapper;

        public AddDEF_EmployeesHandler(IDEF_EmployeesRepository dEF_EmployeesRepository, IMapper mapper)
        {
            this.dEF_EmployeesRepository = dEF_EmployeesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_N_DEF_Employees> Handle(AddDEF_EmployeesCommand request, CancellationToken cancellationToken)
        {
            var dEF_EmployeesDto = mapper.Map<DEF_EmployeesDto>(request);
            return await dEF_EmployeesRepository.Add(dEF_EmployeesDto);
        }
    }
}


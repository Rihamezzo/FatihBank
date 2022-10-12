using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.CompaniesFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CompaniesFeatures.Handlers
{
    public class AddCompaniesHandler : IRequestHandler<AddCompaniesCommand, MSS_TRS_Companies>
    {
        private readonly ICompaniesRepository companiesRepository;
        private readonly IMapper mapper;

        public AddCompaniesHandler(ICompaniesRepository companiesRepository, IMapper mapper)
        {
            this.companiesRepository = companiesRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_TRS_Companies> Handle(AddCompaniesCommand request, CancellationToken cancellationToken)
        {
            var companiesDto = mapper.Map<CompaniesDto>(request);
            return await companiesRepository.Add(companiesDto);
        }
    }
}

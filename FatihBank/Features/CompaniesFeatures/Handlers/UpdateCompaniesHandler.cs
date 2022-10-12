using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.CompaniesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.CompaniesFeatures.Handlers
{
    public class UpdateCompaniesHandler : IRequestHandler<UpdateCompaniesCommand, Unit>
    {
        private readonly ICompaniesRepository companiesRepository;
        private readonly IMapper mapper;

        public UpdateCompaniesHandler(ICompaniesRepository companiesRepository, IMapper mapper)
        {
            this.companiesRepository = companiesRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCompaniesCommand request, CancellationToken cancellationToken)
        {
            var companiesDto = mapper.Map<CompaniesDto>(request);
            await companiesRepository.Update(request.Id, companiesDto);
            return Unit.Value;
        }
    }
}

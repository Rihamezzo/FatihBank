using FatihBank.DTOs;
using FatihBank.Features.RegisterationFileFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RegisterationFileFeatures.Handlers
{
    public class ListAllRegisterationFileHandler : IRequestHandler<ListAllRegisterationFileQuery, PaginationResponse<MSS_INF_RegisterationFile>>
    {
        private readonly IRegisterationFileRepository registerationFileRepository;

        public ListAllRegisterationFileHandler(IRegisterationFileRepository registerationFileRepository)
        {
            this.registerationFileRepository = registerationFileRepository;
        }

        public async Task<PaginationResponse<MSS_INF_RegisterationFile>> Handle(ListAllRegisterationFileQuery request, CancellationToken cancellationToken)
        {
            return await registerationFileRepository.ListAll(request.page, request.pageSize);
        }
    }
}
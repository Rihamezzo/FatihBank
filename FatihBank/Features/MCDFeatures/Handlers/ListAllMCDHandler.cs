using FatihBank.DTOs;
using FatihBank.Features.MCDFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MCDFeatures.Handlers
{
    public class ListAllMCDHandler : IRequestHandler<ListAllMCDQuery, PaginationResponse<MSS_DEF_MCD>>
    {
        private readonly IMCDRepository mCDRepository;

        public ListAllMCDHandler(IMCDRepository mCDRepository)
        {
            this.mCDRepository = mCDRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_MCD>> Handle(ListAllMCDQuery request, CancellationToken cancellationToken)
        {
            return await mCDRepository.ListAll(request.page, request.pageSize);
        }
    }
}

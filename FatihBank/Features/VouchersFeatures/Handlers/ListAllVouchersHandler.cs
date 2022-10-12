using FatihBank.DTOs;
using FatihBank.Features.VouchersFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.VouchersFeatures.Handlers
{
    public class ListAllVouchersHandler : IRequestHandler<ListAllVouchersQuery, PaginationResponse<MSS_DEF_Vouchers>>
    {
        private readonly IVouchersRepository vouchersRepository;

        public ListAllVouchersHandler(IVouchersRepository vouchersRepository)
        {
            this.vouchersRepository = vouchersRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Vouchers>> Handle(ListAllVouchersQuery request, CancellationToken cancellationToken)
        {
            return await vouchersRepository.ListAll(request.page, request.pageSize);
        }
    }
}
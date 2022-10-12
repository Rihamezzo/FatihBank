using FatihBank.DTOs;
using FatihBank.Features.SMSFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.SMSFeatures.Handlers
{
    public class ListAllSMSHandler : IRequestHandler<ListAllSMSQuery, PaginationResponse<MSS_DEF_SMS>>
    {
        private readonly ISMSRepository SMSRepository;

        public ListAllSMSHandler(ISMSRepository SMSRepository)
        {
            this.SMSRepository = SMSRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_SMS>> Handle(ListAllSMSQuery request, CancellationToken cancellationToken)
        {
            return await SMSRepository.ListAll(request.page, request.pageSize);
        }
    }
}

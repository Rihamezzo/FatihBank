using FatihBank.DTOs;
using FatihBank.Features.JournalsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.JournalsFeatures.Handlers
{
    public class ListAllJournalsHandler : IRequestHandler<ListAllJournalsQuery, PaginationResponse<MSS_DEF_Journals>>
    {
        private readonly IJournalsRepository journalsRepository;

        public ListAllJournalsHandler(IJournalsRepository journalsRepository)
        {
            this.journalsRepository = journalsRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Journals>> Handle(ListAllJournalsQuery request, CancellationToken cancellationToken)
        {
            return await journalsRepository.ListAll(request.page, request.pageSize);
        }
    }

    public class ListAllJournalsDetailsHandler : IRequestHandler<ListAllJournalsDetailsQuery, PaginationResponse<MSS_JOU_Details>>
    {
        private readonly IJournalsDetailsRepository journalsDetailsRepository;

        public ListAllJournalsDetailsHandler(IJournalsDetailsRepository journalsDetailsRepository)
        {
            this.journalsDetailsRepository = journalsDetailsRepository;
        }

        public async Task<PaginationResponse<MSS_JOU_Details>> Handle(ListAllJournalsDetailsQuery request, CancellationToken cancellationToken)
        {
            return await journalsDetailsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
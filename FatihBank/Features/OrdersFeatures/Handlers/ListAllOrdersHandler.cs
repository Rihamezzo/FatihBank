using FatihBank.DTOs;
using FatihBank.Features.OrdersFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OrdersFeatures.Handlers
{
    public class ListAllOrdersHandler : IRequestHandler<ListAllOrdersQuery, PaginationResponse<MSS_DEF_Orders>>
    {
        private readonly IOrdersRepository ordersRepository;

        public ListAllOrdersHandler(IOrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }

        public async Task<PaginationResponse<MSS_DEF_Orders>> Handle(ListAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await ordersRepository.ListAll(request.page, request.pageSize);
        }
    }
}
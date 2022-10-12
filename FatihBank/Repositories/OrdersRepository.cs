using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public OrdersRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_Orders>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_Orders.Count() / pageSize);

            var list = await dataContext.MSS_DEF_Orders.Include(x => x.account).Include(x => x.store)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_Orders>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_Orders> Add(OrdersDto ordersDto)
        {
            var result = _mapper.Map<OrdersDto, MSS_DEF_Orders>(ordersDto);
            await dataContext.MSS_DEF_Orders.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, OrdersDto ordersDto)
        {
            var result = await dataContext.MSS_DEF_Orders.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(ordersDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_Orders.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_Orders.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}

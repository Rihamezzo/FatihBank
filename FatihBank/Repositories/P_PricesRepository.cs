using AutoMapper;
using FatihBank.Data;
using FatihBank.Models;
using FatihBank.DTOs;
using Microsoft.EntityFrameworkCore;
namespace FatihBank.Repositories
{
    public class P_PricesRepository : IP_PricesRepository
    {
        private readonly DataContext dataContext;
        private readonly IMapper _mapper;

        public P_PricesRepository(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<PaginationResponse<MSS_DEF_P_Prices>> ListAll(int page, float pageSize)
        {
            var pageCount = Math.Ceiling(dataContext.MSS_DEF_P_Prices.Count() / pageSize);

            var list = await dataContext.MSS_DEF_P_Prices.Include(x => x.currency).Include(x => x.user)
                .Skip((page - 1) * (int)pageSize)
                .Take((int)pageSize)
                .ToListAsync();
            var response = new PaginationResponse<MSS_DEF_P_Prices>
            {
                List = list,
                CurrentPage = page,
                Pages = (int)pageCount

            };
            return response;

        }
        public async Task<MSS_DEF_P_Prices> Add(P_PricesDto p_PricesDto)
        {
            var result = _mapper.Map<P_PricesDto, MSS_DEF_P_Prices>(p_PricesDto);
            await dataContext.MSS_DEF_P_Prices.AddAsync(result);
            await dataContext.SaveChangesAsync();
            return result;
        }

        public async Task Update(int id, P_PricesDto p_PricesDto)
        {
            var result = await dataContext.MSS_DEF_P_Prices.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                _mapper.Map(p_PricesDto, result);
                await dataContext.SaveChanges();
            }
        }

        public async Task Delete(int id)
        {
            var result = await dataContext.MSS_DEF_P_Prices.FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                dataContext.MSS_DEF_P_Prices.Remove(result);
                await dataContext.SaveChanges();
            }
        }
    }
}

